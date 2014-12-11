// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ACharacter.cs" company="">
//   
// </copyright>
// <summary>
//   The a character.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CharacterScripts
{
    using CharacterScripts.Interfaces;
    using UnityEngine;

    /// <summary>
    /// The abstract class of a character.
    /// </summary>
    public abstract class ACharacter : ICharacter
    {
        protected ACharacter(
            int attackPoints,
            int defensePoints,
            string name,
            int maxHealth,
            float movementSpeed)
        {
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.Name = name;
            this.CurHealth = maxHealth;
            this.MaxHealth = maxHealth;
            this.IsHitted = false;
            this.MovementSpeed = movementSpeed;
        }

        #region Public Properties

        /// <summary>
        /// Gets or sets the attack.
        /// </summary>
        public int AttackPoints { get; set; }

        /// <summary>
        /// Gets or sets the defense.
        /// </summary>
        public int DefensePoints { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the cur health.
        /// </summary>
        public int CurHealth { get; set; }

        /// <summary>
        /// Gets or sets the max health.
        /// </summary>
        public int MaxHealth { get; set; }

        public bool IsHitted { get; set; }

        public Transform Transform { get; set; }

        public Animation Animation
        {
            get
            {
                return this.States.Animation;
            }

            set
            {
                this.States.Animation = value;
            }
        }

        public StatesController States { get; set; }

        public float MovementSpeed { get; set; }

        #endregion

        #region Public Methods and Operators

        public abstract void ChangeState(CharacterStates state);

        public abstract void Damage(ICharacter damageReceiver);

        public abstract void Move(Vector3 newPosition);

        public abstract void TakeDamage(int damage);

        #endregion
    }
}