using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using util;

namespace VLG
{
    // The licenses for the game.
    public class Licenses : MonoBehaviour
    {
        // The credits interface.
        public AudioCreditsInterface creditsInterface;

        // The BGM audio credits for the game.
        public AudioCredits bgmCredits;

        // The BGM credits page.
        public int bgmCreditsIndex = 0;

        // The SFX audio credits for the game.
        public AudioCredits sfxCredits;
        
        // The sound effects credit page.
        public int sfxCreditsIndex = 0;

        [Header("UI")]

        // BGM Button
        public Button bgmButton;

        // SFX Button
        public Button sfxButton;

        // Start is called before the first frame update
        void Start()
        {
            // Loads the credits.
            LoadBackgroundMusicCredits();
            LoadSoundEffectCredits();

            // Sets this if it has not been set already.
            if(creditsInterface == null)
                creditsInterface = GetComponent<AudioCreditsInterface>();

            // Show the background credits.
            ShowBackgroundMusicCredits();
        }

        // Loads the BGM credits.
        private void LoadBackgroundMusicCredits()
        {
            AudioCredits.AudioCredit credit = new AudioCredits.AudioCredit();

            // TODO: load BGM credits
        }

        // Loads the SFX credits.
        private void LoadSoundEffectCredits()
        {
            AudioCredits.AudioCredit credit = new AudioCredits.AudioCredit();

            // TODO: load SFX credits
        }

        // Shows the BGM credits.
        public void ShowBackgroundMusicCredits()
        {
            // Saves the current credit index, switches over, and then sets the new credit index.
            bgmCreditsIndex = creditsInterface.GetCurrentCreditIndex();
            creditsInterface.audioCredits = bgmCredits;
            creditsInterface.SetCreditIndex(bgmCreditsIndex);

            // Change button settings.
            bgmButton.interactable = false;
            sfxButton.interactable = true;
        }

        // Shows the SFX credits.
        public void ShowSoundEffectCredits()
        {
            // Saves the current credit index, switches over, and then sets the new credit index.
            sfxCreditsIndex = creditsInterface.GetCurrentCreditIndex();
            creditsInterface.audioCredits = sfxCredits;
            creditsInterface.SetCreditIndex(sfxCreditsIndex);

            // Change button settings.
            bgmButton.interactable = true;
            sfxButton.interactable = false;
        }
    }
}