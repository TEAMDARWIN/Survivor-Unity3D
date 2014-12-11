// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICharacter.cs" company="">
//   
// </copyright>
// <summary>
//   The ACharacter interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CharacterScripts.Interfaces
{
    using UnityEngine;

    /// <summary>
    /// The ACharacter interface.
    /// </summary>
    public interface ICharacter
    {
        #region Public Methods and Operators

        /// <summary>
        /// Changes the animation state.
        /// </summary>
        void ChangeState(CharacterStates state);

        /// <summary>
        /// Does damage to the selected character.
        /// </summary>
        void Damage(ICharacter damageReceiver);

        /// <summary>
        /// Moves the character to selected Vector3 position
        /// </summary>
        void Move(Vector3 newPosition);

        /// <summary>
        /// The take damage.
        /// </summary>
        void TakeDamage(int damage);

        #endregion
    }
}