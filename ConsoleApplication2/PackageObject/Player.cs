using System;

namespace PackageObject
{
	public class Player : AHero
	{
        public Player(string description, int id, float mass, string name,Characteristic attack, 
            Characteristic defence, Characteristic health, Characteristic life)
        {
            this.description = description;
            this.id = id;
            this.mass = mass;
            this.name = name;
            this.attack= attack;
		    this.defence = defence;
		    this.health = health;
		    this.life = life;
        }
		public override void Move()
		{
			throw new System.NotImplementedException();
		}

	}
}

