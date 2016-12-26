using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class SillyHasher : Hasher
    {
	    protected override void GetString(string str)
	    {
		    _stringValue = str;
	    }

	    protected override void GetHash()
	    {
		    _hashedValue = _stringValue;
		    _hashedValue = _hashedValue.Replace(_hashedValue[0], _hashedValue[_hashedValue.Length - 1]);
	    }
    }
}
