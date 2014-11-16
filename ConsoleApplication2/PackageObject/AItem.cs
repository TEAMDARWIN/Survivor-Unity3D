using System;

namespace PackageObject
{
	public abstract class AItem : ABaseGameObject
	{
		public virtual int changeAttack
		{
			get;
			set;
		}

		public virtual int changeDefence
		{
			get;
			set;
		}

		public virtual int changeHealth
		{
			get;
			set;
		}

		public virtual int changeLife
		{
			get;
			set;
		}

	}
}

