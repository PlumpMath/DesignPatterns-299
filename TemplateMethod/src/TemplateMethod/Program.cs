using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
			SillyHasher sillyHasher = new SillyHasher();
			Console.WriteLine("Hashing with silly hasher");
			Console.WriteLine(sillyHasher.Hash("SomeOldWord"));

			CoolHasher coolHasher = new CoolHasher();
			Console.WriteLine("Hashing with cool hasher");
			Console.WriteLine(coolHasher.Hash("SomeOldWord"));

			Console.ReadKey(true);
        }
    }
}
