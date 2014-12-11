using CharacterScripts;
using CharacterScripts.EnemyScripts;

using UnityEngine;

public class Enemy : MonoBehaviour
{

    private EnemyCharacter info = new EnemyCharacter(20, 10, "Troll King", 100, 4f);

   
    void Start()
    {
        // Animation and Transform are passed by reference.
        this.info.States = new StatesController(new string[] { "Idle_01", "Attack_01", "Die" });
        this.info.Animation = this.animation;
        this.info.Transform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {   
            this.info.ChangeState(CharacterStates.Walking);
        }
        else if (Input.GetMouseButton(0))
        {
            this.info.ChangeState(CharacterStates.Hitted);
        }

        this.info.States.PlayAnimation();
    }
}
