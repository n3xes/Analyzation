using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsOutsideExclusiveTest19.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
	public partial class RelationalTestingUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest1948()
{
	bool b;
	b = this.IsOutsideExclusiveTest19
			(default(decimal), new decimal?(0e-4M), new decimal?(0e-4M));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest19284()
{
	bool b;
	b = this.IsOutsideExclusiveTest19(default(decimal), 
									  new decimal?(36893488147419103232M), new decimal?(0e-4M));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest19219()
{
	bool b;
	b = this.IsOutsideExclusiveTest19
			(default(decimal), default(decimal?), new decimal?(0e-4M));
	Assert.AreEqual<bool>(false, b);
}
	}
}
