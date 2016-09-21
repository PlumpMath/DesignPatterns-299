using System;

namespace Prototype
{
	public abstract class Module : ICloneable
	{
		public Int32 Wearability { get; set; }

		public virtual Object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}