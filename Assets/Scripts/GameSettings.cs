using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using util;

namespace VLG
{
    // The game settings.
    public class GameSettings : MonoBehaviour
    {
        // The game settings instance.
        private static GameSettings instance;

        // Gets set to 'true' when the singleton is initialized.
        private bool initialized = false;

        // The audio controls for the game.
        public AudioControls audioControls;

        // If 'true', tutorial elements are used.
        public bool useTutorial = true;

        // Constructor
        private GameSettings()
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
            }

            // Run code for initialization.
            if (!initialized)
            {
                initialized = true;
            }
        }

        // Start is called just before any of the Update methods is called the first time
        private void Start()
        {
            // Don't destroy this object on load.
            DontDestroyOnLoad(this);

            // Checks if audio controls exists.
            if (audioControls == null)
            {
                // Tries to grab the component.
                audioControls = GetComponent<AudioControls>();

                // Adds the component for audio controls.
                if (audioControls == null)
                    audioControls = gameObject.AddComponent<AudioControls>();

            }
        }

        // Gets the instance.
        public static GameSettings Instance
        {
            get
            {
                // Checks if the instance exists.
                if (instance == null)
                {
                    // Tries to find the instance.
                    instance = FindObjectOfType<GameSettings>(true);


                    // The instance doesn't already exist.
                    if (instance == null)
                    {
                        // Generate the instance.
                        GameObject go = new GameObject("Game Settings (singleton)");
                        instance = go.AddComponent<GameSettings>();
                    }

                }

                // Return the instance.
                return instance;
            }
        }

        // Returns 'true' if the object has been initialized.
        public bool Initialized
        {
            get
            {
                return initialized;
            }
        }

        // RESOLUTION //
        // Changes full-screen settings.
        public bool FullScreen
        {
            get
            {
                return Screen.fullScreen;
            }

            set
            {
                Screen.fullScreen = value;
            }
        }

        // Toggles the full screen.
        public static void ToggleFullScreen()
        {
            Screen.fullScreen = !Screen.fullScreen;
        }

        // Called to change the screen size.
        public void ChangeScreenSize(int width, int height, FullScreenMode mode)
        {
            Screen.SetResolution(width, height, mode);
        }


        // Called to change the screen size.
        public void ChangeScreenSize(int width, int height, FullScreenMode mode, bool fullScreen)
        {
            ChangeScreenSize(width, height, mode);
            Screen.fullScreen = fullScreen;
        }


        // Set Screen Size (1080 Resolution - 16:9)
        public void SetScreenSize1920x1080(FullScreenMode mode = FullScreenMode.MaximizedWindow)
        {
            ChangeScreenSize(1920, 1080, mode, false);
        }

        // Set Screen Size (720 Resolution - 16:9)
        public void SetScreenSize1280x720(FullScreenMode mode = FullScreenMode.Windowed)
        {
            ChangeScreenSize(1280, 720, mode, false);
        }



        // VOLUME //

        // Muting the game audio.
        public bool Mute
        {
            get
            {
                return AudioListener.pause;
            }

            set
            {
                AudioListener.pause = value;
            }
        }

        // Master volume.
        public float Volume
        {
            get
            {
                return AudioListener.volume;
            }

            set
            {
                AudioListener.volume = Mathf.Clamp01(value);
            }
        }


        // Quits the application.
        public static void QuitApplication()
        {
            Application.Quit();
        }
    }
}
