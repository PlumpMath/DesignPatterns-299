using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
	internal abstract class DocumentWriter
	{
		public abstract void Write(UserData userData, string path);
	}
}
