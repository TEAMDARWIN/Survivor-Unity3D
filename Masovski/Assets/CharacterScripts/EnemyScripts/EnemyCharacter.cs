namespace CharacterScripts.EnemyScripts
{
    using CharacterScripts.Interfaces;

    using UnityEngine;

    public class EnemyCharacter : ACharacter
    {
        public EnemyCharacter(int attackPoints, int defensePoints, string name, int maxHealth, float movementSpeed)
            : base(attackPoints, defensePoints, name, maxHealth, movementSpeed)
        {

        }

        public override void ChangeState(CharacterStates state)
        {
            this.States.ChangeState(state);
        }

        public override void Damage(ICharacter damageReceiver)
        {
            damageReceiver.TakeDamage(this.AttackPoints);
        }

        public override void Move(Vector3 newPosition)
        {
            this.Transform.position = newPosition * Time.deltaTime * this.MovementSpeed;
        }

        public override void TakeDamage(int damage)
        {
            this.IsHitted = true;

            // TODO: Implement defense damage reduction.

            if (this.CurHealth > 0)
            {
                this.CurHealth -= damage;
            }
        }
    }
}
