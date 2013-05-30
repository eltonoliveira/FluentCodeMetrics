using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.Cc
{
	public class SamplesCc
	{
		private int field1;
		private int field2;

		public SamplesCc()
		{
			field1 = 10;
			field2 = 20;
		}

		public SamplesCc(int field1, int field2)
		{
			this.field1 = field1;
			if (field1 > 50)
				field2 = 10;
			else
				field2 = 20;
		}

		public void SimpleMethod()
		{
			Console.WriteLine(field1.ToString());
		}

		public void OnePathMethod()
		{
			if (field1 == 1)
				Console.WriteLine(field1.ToString());
			else
				Console.WriteLine(field2.ToString());
		}

		public void TwoPathsMethod()
		{
			if (field1 > 1)
				if (field2 > 1)
					Console.WriteLine(field1.ToString());
				else
					Console.WriteLine(field2.ToString());
			else
				if (field2 < 10)
					Console.WriteLine(field1.ToString());
				else
					Console.WriteLine(field2.ToString());
		}
	}
}
