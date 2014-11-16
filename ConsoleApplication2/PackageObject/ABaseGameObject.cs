using System;

namespace PackageObject
{
	public abstract class ABaseGameObject
	{
		public virtual string description
		{
			get;
			set;
		}

		public virtual int id
		{
			get;
			set;
		}

		public virtual float mass
		{
			get;
			set;
		}

		public virtual string name
		{
			get;
			set;
		}

	}
}

