using System;
namespace ACM.BL
{
	public enum EntityStateOption
	{
		Active,
		Ddeleted
	}
	public abstract class EntityClass
	{
		public EntityClass()
		{
		}

		public bool isNew{ get; private set; }
		public bool hasChanges { get; set; }
		public bool isValid => Validate();
		public EntityStateOption entityState { get; set; }

		public abstract bool Validate();
	}
}

