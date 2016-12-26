using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public class CoolHasher : Hasher
	{
		protected override void GetString(string str)
		{
			_stringValue = str.Trim();
		}

		protected override void GetHash()
		{
			_hashedValue = new string(_stringValue.Reverse().ToArray());
		}
	}
}
