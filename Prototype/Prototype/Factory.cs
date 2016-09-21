using System;

namespace Prototype
{
	public class Factory
	{
		public static void Replace<TModule>(ref TModule module1, ref TModule module2) where TModule : Module
		{
			Module clone1 = module1.Clone() as Module;
			Module clone2 = module2.Clone() as Module;

			module1 = clone2 as TModule;
			module2 = clone1 as TModule;
		}
	}
}