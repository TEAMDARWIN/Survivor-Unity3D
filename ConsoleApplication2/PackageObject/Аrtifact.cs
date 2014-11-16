using System;

namespace PackageObject
{
	public class Аrtifact : AItem
	{
        public Аrtifact(string description, int id, float mass, string name,
            int changeAttack = 0, int changeDefence = 0, int changeHealth = 0, int changeLife = 0)
        {
            this.description = description;
            this.id = id;
            this.mass = mass;
            this.name = name;
            this.changeAttack = changeAttack;
            this.changeDefence = changeDefence;
            this.changeHealth = changeHealth;
            this.changeLife = changeLife;
        }
	}
}

