using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using util;
using JetBrains.Annotations;
using UnityEditor.Profiling.Memory.Experimental;

namespace VLG
{
    // The gameplay UI manager.
    public class GameplayUI : MonoBehaviour
    {
        // The singleton instance.
        private static GameplayUI instance;

        // Gets set to 'true' when the singleton has been instanced.
        // This isn't needed, but it helps with the clarity.
        private static bool instanced = false;

        // The game manager.
        public GameplayManager gameManager;

        // The floor loading screen.
        public FloorLoadingScreen floorLoadingScreen;

        [Header("Floor Info")]
        // The text that displays the floor.
        public TMP_Text floorNumberText;

        // The floor code text.
        public TMP_Text floorCodeText;

        [Header("Progress")]

        // The progress bar for the game.
        public ProgressBar gameProgressBar;

        [Header("Objective")]

        // The objective for the game.
        public TMP_Text objectiveText;

        [Header("Stats")]

        // The text for the remaining amount of floor turns.
        public TMP_Text floorTurnsLeftText;

        // The time text for the whole game.
        public TMP_Text gameTimeText;

        // The time text for the current floor.
        public TMP_Text floorTimeText;

        [Header("Windows")]
        // The pause window.
        public GameObject pauseWindow;

        // The options window (main window).
        public GameObject optionsWindow;

        // The instructions window.
        public GameObject instructionsWindow;

        // The settings window.
        public GameObject settingsWindow;

        // Constructor
        private GameplayUI()
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
                instanced = true;

                // Gets the game manager.
                if (gameManager == null)
                    gameManager = GameplayManager.Instance;
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            // ...
        }

        // Gets the instance.
        public static GameplayUI Instance
        {
            get
            {
                // Checks if the instance exists.
                if (instance == null)
                {
                    // Tries to find the instance.
                    instance = FindObjectOfType<GameplayUI>(true);


                    // The instance doesn't already exist.
                    if (instance == null)
                    {
                        // Generate the instance.
                        GameObject go = new GameObject("GameplayUIManager (singleton)");
                        instance = go.AddComponent<GameplayUI>();
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

        // Show the floor loading screen.
        public void ShowFloorLoadingScreen()
        {
            floorLoadingScreen.gameObject.SetActive(true);
        }

        // Hide the floor loading screen.
        public void HideFloorLoadingScreen()
        {
            floorLoadingScreen.gameObject.SetActive(false);
        }

        // Updates the floor text.
        public void UpdateFloorText()
        {
            // Gets the floor ID and code.
            int floorId = gameManager.floorManager.currFloor.id;
            string floorCode = gameManager.floorManager.currFloor.code;

            // Sets the floor text.
            floorNumberText.text = "Floor " + floorId.ToString();
            floorCodeText.text = floorCode;
        }

        // Updates the game progress.
        public void UpdateGameProgressBar()
        {
            // Gets the clear percent.
            // It does FLOOR_COUNT - 1 because the debug floor/floor 0 is ignored.
            float percent = Mathf.Clamp01(gameManager.floorManager.currFloor.id / (FloorData.FLOOR_COUNT - 1));

            // Sets the value.
            gameProgressBar.SetValue(percent, true);
        }

        // Updates the objective text.
        public void UpdateObjectiveText()
        {
            // Update to the current objective.
            if(gameManager.floorManager.goal != null)
                UpdateObjectiveText(gameManager.floorManager.goal.objective);
            else
                UpdateObjectiveText(0); // Default/Non-specific
        }

        // Updates the objective text.
        public void UpdateObjectiveText(Goal.goalType objective)
        {
            // Updates the objective text.
            objectiveText.text = Goal.GetObjectiveDescription(objective);
        }

        // Updates the turns text.
        public void UpdateTurnsText()
        {
            // Checks if the turns are limited or not.
            if(gameManager.floorManager.limitTurns) // Limited
            {
                floorTurnsLeftText.text = 
                    (gameManager.floorManager.floorTurnsMax - gameManager.floorManager.floorTurns).ToString();
            }
            else // Not limited.
            {
                floorTurnsLeftText.text = "-";
            }
        }

        // Resets the timer text with the provided game time and floor time.
        public void UpdateTimerText(float gameTime, float floorTime)
        {
            gameTimeText.text = "GT: " + StringFormatter.FormatTime(gameTime, true, true, false);
            floorTimeText.text = "FT: " + StringFormatter.FormatTime(floorTime, true, true, false);
        }

        // Updates all the UI elements
        public void UpdateAllHUDElements()
        {
            // TODO: implement objective text into gameplay.
            UpdateFloorText();
            UpdateGameProgressBar();
            UpdateObjectiveText();
            UpdateTimerText(gameManager.gameTime, gameManager.floorManager.floorTime);
            UpdateTurnsText();
        }

        // RESET FLOOR
        // Resets the floor.
        public void ResetFloor()
        {
            gameManager.floorManager.ResetFloor();
        }

        // PAUSE //
        // Sets Paused Game
        public void SetPaused(bool pausedGame)
        {
            gameManager.SetPaused(pausedGame);
        }

        // Pauses the Game
        public void PauseGame()
        {
            gameManager.PauseGame();
        }

        // Unpauses the Game
        public void UnpauseGame()
        {
            gameManager.UnpauseGame();
        }

        // Called when the game pause state has changed.
        public void OnPausedChanged(bool paused)
        {
            // Closes all the windows, and opens the options window.
            CloseAllWindows();
            OpenWindow(optionsWindow);

            // Checks if the game is paused or not.
            if (paused)
            {
                // Open the pause window.
                pauseWindow.SetActive(true);
            }
            else
            {
                // Close the pause window.
                pauseWindow.SetActive(false);
            }
        }

        // WINDOWS //

        // Closes all windows
        public void CloseAllWindows(bool includePauseWindow)
        {
            optionsWindow.SetActive(false);
            instructionsWindow.SetActive(false);
            settingsWindow.SetActive(false);

            // The pause window is the parent of all the other windows.
            // Hence why this is turned off last.
            if(includePauseWindow)
                pauseWindow.SetActive(false);
        }

        // Closes all windows.
        public void CloseAllWindows()
        {
            // Closes all windows, including the pause window.
            CloseAllWindows(true);
        }

        // Opens the provided window.
        public void OpenWindow(GameObject window)
        {
            // Close all the windows, except the pause window.
            CloseAllWindows(false);
            
            // Activate the window.
            window.SetActive(true);
        }

        // SCENE //
        // Goes to the title scene.
        public void ToTitleScene()
        {
            gameManager.ToTitleScene();
        }

        // Update is called once per frame
        void Update()
        {
            // If the game is not paused.
            if(!gameManager.IsPaused())
            {
                // TODO: maybe change how often time text is updated so that it doesn't happen every frame.

                // Gets the game time and floor time.
                float gt = gameManager.gameTime;
                float ft = gameManager.floorManager.floorTime;

                // Updates the timer text.
                UpdateTimerText(gt, ft);
            }
        }
    }
}