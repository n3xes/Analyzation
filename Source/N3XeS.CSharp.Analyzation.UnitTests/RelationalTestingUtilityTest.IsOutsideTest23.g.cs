using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsOutsideTest23.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideTest23438()
{
	bool b;
	b = this.IsOutsideTest23
			(new decimal?(0e-4M), new decimal?(0e-4M), new decimal?(0e-4M));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest2365()
{
	bool b;
	b = this.IsOutsideTest23
			(new decimal?(0e-4M), new decimal?(0e-4M), default(decimal?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest23689()
{
	bool b;
	b = this.IsOutsideTest23(new decimal?(decimal.MaxValue), 
							 new decimal?(2034639888M), new decimal?(0e-4M));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest23284()
{
	bool b;
	b = this.IsOutsideTest23
			(default(decimal?), new decimal?(0e-4M), new decimal?(0e-4M));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest23877()
{
	bool b;
	b = this.IsOutsideTest23
			(new decimal?(0e-4M), default(decimal?), new decimal?(0e-4M));
	Assert.AreEqual<bool>(false, b);
}
	}
}
