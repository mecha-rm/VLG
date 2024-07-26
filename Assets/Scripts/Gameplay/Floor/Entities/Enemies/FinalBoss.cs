using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VLG
{
    // The final boss of the game.
    public class FinalBoss : Boss
    {
        // The singleton instance.
        private static FinalBoss instance;

        // Gets set to 'true' when the singleton has been instanced.
        // This isn't needed, but it helps with the clarity.
        private static bool instanced = false;

        [Header("Final Boss")]

        // The lighting strike prefab
        public LightningStrike lightningStrikePrefab;

        // The pool of lighitng strikes to pull from.
        private Queue<LightningStrike> lightningStrikePool = new Queue<LightningStrike>();

        // Constructor
        private FinalBoss()
        {
            // ...
        }

        // Awake is called when the script is being loaded
        protected override void Awake()
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

                // Base Awake
                base.Awake();
            }
        }

        // Start is called before the first frame update
        protected override void Start()
        {
            base.Start();
        }

        // Called on the first frame.
        protected override void PostStart()
        {
            base.PostStart();

            // Lighting Strike Test - Make Sure to Remove
            SpawnLightingStrike(new Vector2Int(6, 0));

        }

        // Gets the instance.
        public static FinalBoss Instance
        {
            get
            {
                // Checks if the instance exists.
                if (instance == null)
                {
                    // Tries to find the instance.
                    instance = FindObjectOfType<FinalBoss>(true);


                    // The instance doesn't already exist.
                    if (instance == null)
                    {
                        // Generate the instance.
                        GameObject go = new GameObject("FinalBoss (singleton)");
                        instance = go.AddComponent<FinalBoss>();
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

        // Spawns a lighting strike at the provided position.
        public void SpawnLightingStrike(Vector2Int strikePos)
        {
            // The lighting strike object.
            LightningStrike strike;

            // Checks if there's already a saved lighting strike object.
            if(lightningStrikePool.Count > 0)
            {
                strike = lightningStrikePool.Dequeue();
            }
            else // No object.
            {
                // Generate a new one.
                strike = Instantiate(lightningStrikePrefab);

                // Parent
                strike.transform.parent = transform.parent;

                // Return the lighting strike object to the pool when it's done.
                strike.OnLightingStrikeEndAddCallback(ReturnLightingStrike);
            }

            // Activates the object and triggers a ligthing strike.
            strike.gameObject.SetActive(true);
            strike.TriggerLightningStrike(strikePos);
        }

        // Returns the lighting strike to the pool.
        public void ReturnLightingStrike(LightningStrike strike)
        {
            strike.gameObject.SetActive(false);
            lightningStrikePool.Enqueue(strike);
        }

        // Run the AI for the Final Boss
        public override void UpdateAI()
        {
            base.UpdateAI();

            // Checks what phase the final boss in is.
            switch(phase)
            {
                case 0:
                case 1:
                default: // Phase 1

                    break;
            }
        }

        // Update is called once per frame
        protected override void Update()
        {
            base.Update();

        }

        // This function is called when the MonoBehaviour will be destroyed.
        protected override void OnDestroy()
        {
            // If the saved instance is being deleted, set 'instanced' to false.
            if (instance == this)
            {
                instanced = false;
            }
        }

    }
}