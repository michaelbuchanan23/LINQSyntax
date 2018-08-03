using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSyntax {
	class Program {
		static void Main(string[] args) {

			var ints = new int[] { 1, 2, 3, 4, 5 };

			//sums the array using linq syntax
			var sum = ints.Sum();

			//gives the length of the array via linq syntax
			var length = ints.Length;

			//where gives us a subset of items
			var evens = ints.Where(i => i % 2 == 0).ToList();

			//this is the same as above without using linq syntax
			foreach (int i in ints) {
				if (i % 2 == 0)
					evens.ToList();
			}

		}
	}
}
