namespace CharacterScripts
{
    using System;

    using UnityEngine;

    public class StatesController
    {
        public StatesController(string[] animationNames)
        {
            this.AnimationNames = animationNames;
            this.ChangeState(CharacterStates.Idle);
        }

        public CharacterStates CurrentState { get; set; }

        public string CurrentAnimation { get; set; }

        public string[] AnimationNames { get; set; }

        public Animation Animation { get; set; }

        public void ChangeState(CharacterStates state)
        {
            try
            {
                switch (state)
                {
                    case CharacterStates.Idle:
                        this.CurrentAnimation = this.AnimationNames[0];
                        break;
                    case CharacterStates.Walking:
                        this.CurrentAnimation = this.AnimationNames[1];
                        break;
                    case CharacterStates.Running:
                        this.CurrentAnimation = this.AnimationNames[2];
                        break;
                    case CharacterStates.Jumping:
                        this.CurrentAnimation = this.AnimationNames[3];
                        break;
                    case CharacterStates.Hitted:
                        this.CurrentAnimation = this.AnimationNames[4];
                        break;
                    case CharacterStates.Attacking:
                        this.CurrentAnimation = this.AnimationNames[5];
                        break;
                    case CharacterStates.Dying:
                        this.CurrentAnimation = this.AnimationNames[6];
                        break;
                    default:
                        this.CurrentAnimation = this.AnimationNames[0];
                        break;
                }
            }
            catch (IndexOutOfRangeException)
            {
                this.CurrentAnimation = this.AnimationNames[0];
            }
            
        }

        public void PlayAnimation()
        {
            this.Animation.CrossFade(this.CurrentAnimation);
        }
    }
}
