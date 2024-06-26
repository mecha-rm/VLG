using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace VLG
{
    // The gameplay manager.
    public class GameplayManager : MonoBehaviour
    {
        // The singleton instance.
        private static GameplayManager instance;

        // Gets set to 'true' when the singleton has been instanced.
        // This isn't needed, but it helps with the clarity.
        private static bool instanced = false;

        // The gameplay UI.
        public GameplayUI gameUI;

        // The player for the game.
        public Player player;

        // The floor manager.
        public FloorManager floorManager;

        [Header("Stats")]

        // The game time (total)
        public float gameTime = 0;

        // The floor times (total)
        public float[] floorTimes;

        // The game turns (total)
        public int gameTurns = 0;

        // The floor turns (total)
        public int[] floorTurns;

        // Determines if the game is paused or not.
        public bool paused = false;

        [Header("Other")]

        // Gets set to 'true' if the game manager should allow saves.
        public bool allowSaves = false;

        // Gets set to 'true' when the post start function has been called.
        private bool calledPostStart = false;


        // TODO: add floor array for moving around entites.

        // Constructor
        private GameplayManager()
        {
            // ...
        }

        // Awake is called when the script is being loaded
        protected virtual void Awake()
        {
            // If the instance hasn't been set, set it to this object.
            if (instance == null)
            {
                instance = this;
            }
            // If the instance isn't this, destroy the game object.
            else if (instance != this)
            {
                Destroy(gameObject);
                return;
            }

            // Run code for initialization.
            if (!instanced)
            {
                // Initializes arrays.
                // This is done here so that the inspector doesn't override these values.
                floorTimes = new float[FloorData.FLOOR_COUNT];
                floorTurns = new int[FloorData.FLOOR_COUNT];

                instanced = true;
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            // TODO: comment out when you want to test saving.

            // If the game isn't running in WebGL, allow the game to save.
            allowSaves = false;
            // allowSaves = Application.platform != RuntimePlatform.WebGLPlayer;

            // Finds the game info object.
            GameInfo gameInfo = FindObjectOfType<GameInfo>(true);

            // If the game info object couldn't be found...
            if(gameInfo != null)
            {
                // Checks if saved data should be loaded.
                if(gameInfo.loadFromSave) // Load from save.
                {
                    // Loads the saved game. If the load failed, load from the game info floor ID.
                    if(!LoadGame())
                        floorManager.GenerateFloor(gameInfo.floorId);
                }
                else // Start from applicable floor.
                {
                    floorManager.GenerateFloor(gameInfo.floorId);
                }

                // Destroy the game object now that it's done being used.
                Destroy(gameInfo.gameObject);
            }
            else // Default load.
            {
                // TODO: change default floor load to floor 0, not floor one.
                // Generates floor 1.
                floorManager.GenerateFloor(0); // Debug
                // floorManager.GenerateFloor(1);
            }
        }

        // Called after the Start function 
        public void PostStart()
        {
            // TODO: put any relevant code here.

            // This function has been called.
            calledPostStart = true;
        }

        // Gets the instance.
        public static GameplayManager Instance
        {
            get
            {
                // Checks if the instance exists.
                if (instance == null)
                {
                    // Tries to find the instance.
                    instance = FindObjectOfType<GameplayManager>(true);


                    // The instance doesn't already exist.
                    if (instance == null)
                    {
                        // Generate the instance.
                        GameObject go = new GameObject("Gameplay Manager (singleton)");
                        instance = go.AddComponent<GameplayManager>();
                    }

                }

                // Return the instance.
                return instance;
            }
        }

        // Returns 'true' if the object has been initialized.
        public static bool Instantiated
        {
            get
            {
                return instanced;
            }
        }

        // Updates game turns.
        public void UpdateTurns()
        {
            // If the game is paused, don't updatre the turns.
            if (paused)
                return;

            // TODO: implement turn update.
            gameTurns++;

            floorManager.UpdateTurns();
            gameUI.UpdateTurnsText();
        }

        // SAVING/LOADING
        public VLG_GameData GenerateSaveData()
        {
            // The game data.
            VLG_GameData data = new VLG_GameData();

            // Saves the floor id and code.
            data.floorId = floorManager.currFloor.id;
            data.floorCode = floorManager.currFloor.code;

            // Saves the time.
            data.gameTime = gameTime;
            data.floorTimes = floorTimes;

            // Saves the turns.
            data.gameTurns = gameTurns;
            data.floorTurns = floorTurns;

            // The data is safe to read from.
            data.valid = true;

            // Returns the data.
            return data;
        }

        // Saves the game.
        public bool SaveGame()
        {
            // Grab the save system (creates it if it doesn't exist).
            SaveSystem saveSystem = SaveSystem.Instance;

            // Sets the game manager.
            saveSystem.gameManager = this;

            // Saves the game asynchronously.
            bool result = saveSystem.SaveGame(true);

            // Return the result of the save.
            return result;
        }

        // Loads the game.
        public bool LoadGame()
        {
            // If the save system hasn't been instantiated, there's no data to load.
            if (!SaveSystem.Instantiated)
            {
                Debug.LogError("The save system has not been instantiated. Load failed.");
                return false;
            }
            
            // Grab the save system.
            SaveSystem saveSystem = SaveSystem.Instance;

            // If the save system doesn't have loaded data, try to load it.
            if(!saveSystem.HasLoadedData())
            {
                // Tries to load the game.
                saveSystem.LoadGame();

                // If the game load failed, don't do anything else.
                if (!saveSystem.HasLoadedData())
                {
                    Debug.LogError("No loaded data could be found.");
                    return false;
                }

            }

            // Grabs the loaded data.
            VLG_GameData data = saveSystem.loadedData;

            // Data validity check.
            if(!data.valid)
            {
                Debug.LogError("The loaded data is invalid.");
                return false;
            }

            // Loads the time data.
            gameTime = data.gameTime;
            floorTimes = data.floorTimes;

            // Loads the floor data.
            gameTurns = data.gameTurns;
            floorTurns = data.floorTurns;

            // Loads the floor using the ID number (could also use code).
            floorManager.GenerateFloor(data.floorId);

            // Load successful.
            return true;
        }

        // Called to finish the game.
        public void FinishGame()
        {
            // Creates the results info object.
            GameObject newObject = new GameObject("Results Info");
            ResultsInfo resultsInfo = newObject.AddComponent<ResultsInfo>();
            DontDestroyOnLoad(newObject);

            // Saving data.
            resultsInfo.gameTime = gameTime;

            // Results scene.
            ToResultsScene();
        }

        // Goes to the results scene.
        public void ToResultsScene()
        {
            SceneManager.LoadScene("ResultsScene");
        }

        // Update is called once per frame
        void Update()
        {
            // If PostStart hasn't been called yet, call it.
            if (!calledPostStart)
                PostStart();

            // The game is not paused.
            if(!paused)
            {
                gameTime += Time.deltaTime;
            }
            
        }

        // This function is called when the MonoBehaviour will be destroyed.
        private void OnDestroy()
        {
            // If the saved instance is being deleted, set 'instanced' to false.
            if (instance == this)
            {
                instanced = false;
            }
        }
    }
}