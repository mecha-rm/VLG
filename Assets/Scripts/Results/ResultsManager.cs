using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VLG
{
    // The results manager.
    public class ResultsManager : MonoBehaviour
    {
        // The singleton instance.
        private static ResultsManager instance;

        // Gets set to 'true' when the singleton has been instanced.
        // This isn't needed, but it helps with the clarity.
        private static bool instanced = false;

        // The Results UI.
        public ResultsUI resultsUI;

        // The results info
        public ResultsInfo resultsInfo;

        // Constructor
        private ResultsManager()
        {
            // ...
        }

        // Awake is called when the script is being loaded
        void Awake()
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
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            // Checks if the results info object exists.
            if(resultsInfo == null)
            {
                resultsInfo = FindObjectOfType<ResultsInfo>(true);
            }

            LoadResultsInfo();
        }

        // Gets the instance.
        public static ResultsManager Instance
        {
            get
            {
                // Checks if the instance exists.
                if (instance == null)
                {
                    // Tries to find the instance.
                    instance = FindObjectOfType<ResultsManager>(true);


                    // The instance doesn't already exist.
                    if (instance == null)
                    {
                        // Generate the instance.
                        GameObject go = new GameObject("ResultsManager (singleton)");
                        instance = go.AddComponent<ResultsManager>();
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

        // Loads the results information.
        public void LoadResultsInfo()
        {
            LoadResultsInfo(resultsInfo);
        }

        // Loads the results information.
        public void LoadResultsInfo(ResultsInfo info)
        {
            // Loads the information for the UI.
            resultsUI.LoadResultsInfo(info);

            // Checks that the info exists.
            if (info != null)
            {
                // ...
            }
            else // Doesn't exist, so load default values.
            {
                // ...
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        // This function is called when the MonoBehaviour will be destroyed
        private void OnDestroy()
        {
            // Destroys the game object.
            // This is set to not destroy on load, hence why it must be destroyed this way.
            if (resultsInfo != null)
                Destroy(resultsInfo.gameObject);
        }
    }
}