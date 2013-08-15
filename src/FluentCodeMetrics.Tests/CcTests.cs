using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FluentCodeMetrics.Core;

namespace FluentCodeMetrics.Tests
{
	[TestFixture]
	public class CcTests
	{
		[Test]
		public void CcForTwoPathMethod()
		{
			Assert.AreEqual(4, Type.GetType("Samples.Cc.SamplesCc").GetMethod("TwoPathsMethod").ComputeCc());
		}

		[Test]
		public void CcForConstructorWithNoParams()
		{			
			Assert.AreEqual(1, Type.GetType("Samples.Cc.SamplesCc").GetConstructor(new Type[0]).ComputeCc());
		}
	}
}
