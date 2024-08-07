using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using util;

namespace VLG
{
    // The UI for the tutorial.
    public class TutorialsUI : MonoBehaviour
    {
        // The singleton instance.
        private static TutorialsUI instance;

        // Gets set to 'true' when the singleton has been instanced.
        // This isn't needed, but it helps with the clarity.
        private static bool instanced = false;

        // The game UI.
        public GameplayUI gameUI;

        // The tutorials object.
        public Tutorials tutorials;

        // The tutorial text box.
        public TextBox textBox;

        [Header("Diagram")]
        // The text box image object.
        public GameObject textBoxDiagram;

        // The text box image.
        public Image textBoxDiagramImage;


        [Header("Diagram/Images")]
        
        // The alpha 0 sprite. Used to hide the diagram if there's no image.
        [Tooltip("Used to hide the text box diagram image.")]
        public Sprite alpha0Sprite;

        [Header("Digram/Images/Geometry")]
        public Sprite entryBlockSprite;
        public Sprite goalBlockSprite;
        public Sprite blockSprite;
        public Sprite hazardBlockSprite;
        public Sprite limitedBlockSprite;
        public Sprite phaseBlockSprite;
        public Sprite portalBlockSprite;
        public Sprite switchBlockSprite;
        public Sprite buttonBlockSprite;

        [Header("Diagram/Images/Enemy")]
        public Sprite stationaryEnemySprite;
        public Sprite barEnemySprite;
        public Sprite copyEnemySprite;
        public Sprite finalBossEnemySprite;

        [Header("Diagram/Images/Items")]
        public Sprite keyItemSprite;
        public Sprite weaponItemSprite;

        // Constructor
        private TutorialsUI()
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
                textBox.OnTextBoxOpenedAddCallback(OnTextBoxOpened);
                textBox.OnTextBoxClosedAddCallback(OnTextBoxClosed);
                textBox.OnTextBoxFinishedAddCallback(OnTextBoxFinished);

                instanced = true;
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            // Gets the instance if it's not set.
            if (gameUI == null)
                gameUI = GameplayUI.Instance;

            // Gets the tutorials object.
            if (tutorials == null)
                tutorials = Tutorials.Instance;

            // If the text box is open, close it.
            if(textBox.gameObject.activeSelf)
            {
                textBox.gameObject.SetActive(false);
            }
        }

        // Gets the instance.
        public static TutorialsUI Instance
        {
            get
            {
                // Checks if the instance exists.
                if (instance == null)
                {
                    // Tries to find the instance.
                    instance = FindObjectOfType<TutorialsUI>(true);


                    // The instance doesn't already exist.
                    if (instance == null)
                    {
                        // Generate the instance.
                        GameObject go = new GameObject("Tutorial UI (singleton)");
                        instance = go.AddComponent<TutorialsUI>();
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

        // Is the tutorial active?
        public bool IsTutorialRunning()
        {
            // If the textbox is isible, then the tutorial is active.
            return textBox.IsVisible();
        }

        // Starts a tutorial.
        public void StartTutorial()
        {
            textBox.SetPage(0);
            OpenTextBox();
        }

        // Restarts the tutorial.
        public void RestartTutorial()
        {
            // Gets the pages from the text box.
            List<Page> pages = textBox.pages;

            // Ends the tutorial, sets the textbox pages, and starts the tutorial again.
            EndTutorial();
            textBox.pages = pages;
            StartTutorial();
        }

        // Ends the tutorial.
        public void EndTutorial()
        {
            // If the tutorial is running, end it.
            if(IsTutorialRunning())
            {
                // Sets to the last page and closes the text box.
                textBox.SetPage(textBox.GetPageCount() - 1);
                CloseTextBox();
            }
        }

        // Called when a tutorial is started.
        public void OnTutorialStart()
        {
            // ...
        }

        // Called when a tutorail ends.
        public void OnTutorialEnd()
        {
            // ...
        }

        // TEXT BOX
        // Loads pages for the textbox.
        public void LoadPages(ref List<Page> pages, bool clearPages)
        {
            // If the pages should be cleared.
            if (clearPages)
                textBox.ClearPages();

            // Adds pages to the end of the text box.
            textBox.pages.AddRange(pages);

        }

        // Opens Text Box
        public void OpenTextBox()
        {
            textBox.Open();
        }

        // Closes the Text Box
        public void CloseTextBox()
        {
            textBox.Close();
        }

        // Text box operations.
        // Called when the text box is opened.
        private void OnTextBoxOpened()
        {
            // These should be handled by the pages.
            // Hides the diagram by default.
            // HideDiagram();

            // The tutorial has started.
            tutorials.OnTutorialStart();
        }

        // Called when the text box is closed.
        private void OnTextBoxClosed()
        {
            // ...
        }

        // Called when the text box is finished.
        private void OnTextBoxFinished()
        {
            // Remove all the pages.
            textBox.ClearPages();

            // These should be handled by the pages.
            // // Clear the diagram and hides it.
            // ClearDiagram();
            // HideDiagram();

            // The tutorial has ended.
            tutorials.OnTutorialEnd();
        }

        // Diagram
        // Sets the diagram's visibility.
        public void SetDiagramVisibility(bool visible)
        {
            textBoxDiagram.SetActive(visible);
        }

        // Show the diagram.
        public void ShowDiagram()
        {
            SetDiagramVisibility(true);
        }

        // Hide the diagram.
        public void HideDiagram()
        {
            SetDiagramVisibility(false);
        }

        // Clears the diagram.
        public void ClearDiagram()
        {
            // Clear out the sprite.
            textBoxDiagramImage.sprite = alpha0Sprite;
        }

        // DIAGRAM IMAGES
        // Set diagram image by type.
        public void SetDiagramImageByTutorialType(Tutorials.tutorialType tutorial)
        {
                // Checks the tutorial type to see what to load.
            switch (tutorial)
            {
                default:
                case Tutorials.tutorialType.none: // Clear if no specific type
                    textBoxDiagramImage.sprite = alpha0Sprite;
                    break;

                // GEOMETRY
                case Tutorials.tutorialType.entryBlock:
                    textBoxDiagramImage.sprite = entryBlockSprite;
                    break;

                case Tutorials.tutorialType.goalBlock:
                    textBoxDiagramImage.sprite = goalBlockSprite;
                    break;

                case Tutorials.tutorialType.block:
                    textBoxDiagramImage.sprite = blockSprite;
                    break;

                case Tutorials.tutorialType.hazardBlock:
                    textBoxDiagramImage.sprite = hazardBlockSprite;
                    break;

                case Tutorials.tutorialType.limitedBlock:
                    textBoxDiagramImage.sprite = limitedBlockSprite;
                    break;

                case Tutorials.tutorialType.phaseBlock:
                    textBoxDiagramImage.sprite = phaseBlockSprite;
                    break;

                case Tutorials.tutorialType.portalBlock:
                    textBoxDiagramImage.sprite = portalBlockSprite;
                    break;

                case Tutorials.tutorialType.switchBlock:
                    textBoxDiagramImage.sprite = switchBlockSprite;
                    break;

                case Tutorials.tutorialType.buttonBlock:
                    textBoxDiagramImage.sprite = buttonBlockSprite;
                    break;


                // ENEMY
                case Tutorials.tutorialType.stationaryEnemy:
                    textBoxDiagramImage.sprite = stationaryEnemySprite;
                    break;

                case Tutorials.tutorialType.barEnemy:
                    textBoxDiagramImage.sprite = barEnemySprite;
                    break;

                case Tutorials.tutorialType.copyEnemy:
                    textBoxDiagramImage.sprite = copyEnemySprite;
                    break;

                case Tutorials.tutorialType.finalBossEnemy:
                    textBoxDiagramImage.sprite = finalBossEnemySprite;
                    break;

                // ITEM
                case Tutorials.tutorialType.keyItem:
                    textBoxDiagramImage.sprite = keyItemSprite;
                    break;

                case Tutorials.tutorialType.weaponItem:
                    textBoxDiagramImage.sprite = weaponItemSprite;
                    break;
            }
        }

        // BLOCKS
        // Sets the diagram to the entry block diagram.
        public void SetDiagramToEntryBlockDiagram()
        {
            textBoxDiagramImage.sprite = entryBlockSprite;
        }

        // Sets the diagram to the goal block diagram.
        public void SetDiagramToGoalBlockDiagram()
        {
            textBoxDiagramImage.sprite = goalBlockSprite;
        }

        // Sets the diagram to the block diagram.
        public void SetDiagramToBlockDiagram()
        {
            textBoxDiagramImage.sprite = blockSprite;
        }

        // Sets the diagram to the hazard block diagram.
        public void SetDiagramToHazardBlockDiagram()
        {
            textBoxDiagramImage.sprite = hazardBlockSprite;
        }

        // Sets the diagram to the limited block diagram.
        public void SetDiagramToLimitedBlockDiagram()
        {
            textBoxDiagramImage.sprite = limitedBlockSprite;
        }

        // Sets the diagram to the phase block diagram.
        public void SetDiagramToPhaseBlockDiagram()
        {
            textBoxDiagramImage.sprite = phaseBlockSprite;
        }

        // Sets the diagram to the portal block diagram.
        public void SetDiagramToPortalBlockDiagram()
        {
            textBoxDiagramImage.sprite = portalBlockSprite;
        }

        // Sets the diagram to the switch block diagram.
        public void SetDiagramToSwitchBlockDiagram()
        {
            textBoxDiagramImage.sprite = switchBlockSprite;
        }

        // ENEMIES
        // Sets the diagram to the button block diagram.
        public void SetDiagramToButtonBlockDiagram()
        {
            textBoxDiagramImage.sprite = buttonBlockSprite;
        }

        // Sets the diagram to the stationary enemy diagram.
        public void SetDiagramToStationaryEnemyDiagram()
        {
            textBoxDiagramImage.sprite = stationaryEnemySprite;
        }

        // Sets the diagram to the bar enemy diagram.
        public void SetDiagramToBarEnemyDiagram()
        {
            textBoxDiagramImage.sprite = barEnemySprite;
        }

        // Sets the diagram to the copy enemy diagram.
        public void SetDiagramToCopyEnemyDiagram()
        {
            textBoxDiagramImage.sprite = copyEnemySprite;
        }

        // Sets the diagram to the final boss enemy diagram.
        public void SetDiagramToFinalBossEnemyDiagram()
        {
            textBoxDiagramImage.sprite = finalBossEnemySprite;
        }

        // ITEMS
        // Sets the diagram to the key item diagram.
        public void SetDiagramToKeyItemDiagram()
        {
            textBoxDiagramImage.sprite = keyItemSprite;
        }

        // Sets the diagram to the weapon item diagram.
        public void SetDiagramToWeaponItemDiagram()
        {
            textBoxDiagramImage.sprite = weaponItemSprite;
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