using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace TemplateMethod
{
	[ContractClass(typeof(HasherContract))]
    public abstract class Hasher
	{
		protected string _stringValue;
		protected string _hashedValue;
	    protected abstract void GetString(string str);
	    protected abstract void GetHash();

		public string Hash(string str)
		{
			GetString(str);
			GetHash();
			return _hashedValue;
		}
    }

	[ContractClassFor(typeof(Hasher))]
	public abstract class HasherContract : Hasher
	{
		protected override void GetString(string str)
		{
			Contract.Requires(str != null);
			Contract.Ensures(_stringValue != null);
			throw new System.NotImplementedException();
		}

		protected override void GetHash()
		{
			Contract.Ensures(_hashedValue != null);
			throw new System.NotImplementedException();
		}
	}
}
