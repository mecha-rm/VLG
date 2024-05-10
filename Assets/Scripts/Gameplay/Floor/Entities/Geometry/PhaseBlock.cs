using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VLG
{
    // The phase block, which goes from tangible to intangible (and vice-versa)
    public class PhaseBlock : Block
    {
        [Header("PhaseBlock")]
        // The phase start upon the game starting (tangible/instangible).
        [Tooltip("Determines the starting state of the phase block (tangible/intangible).")]
        public bool tangibleStart = true;

        // Sets if the phase block is tangible or intangible.
        protected bool tangible = true;

        // Start is called before the first frame update
        protected override void Start()
        {
            base.Start();

            // Sets the tangible state.
            SetTangible(tangibleStart, false);
        }

        // Returns the tangibility of the object.
        public bool IsTangible()
        {
            return tangible;
        }

        // Sets that the object is tangible.
        public virtual void SetTangible(bool value, bool animate = true)
        {
            tangible = value;
        }    
        
        // Makes the block tangible.
        public void MakeTangible(bool animate = true)
        {
            SetTangible(true, animate);
        }

        // Makes the block intangible.
        public void MakeIntangible(bool animate = true)
        {
            SetTangible(false, animate);
        }

        // Called to see if this block is valid to use.
        public override bool UsableBlock()
        {
            // If the block is tangle, it is usable.
            // If the block is intangible, it is not.
            return tangible;
        }

        // Resets the floor entity.
        public override void ResetEntity()
        {
            base.ResetEntity();
            SetTangible(tangibleStart, false); // Set value to default.
        }
    }
}