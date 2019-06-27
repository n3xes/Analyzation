using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsOutsideTest22.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideTest22354()
{
	bool b;
	b = this.IsOutsideTest22
			(new decimal?(0e-4M), new decimal?(0e-4M), default(decimal));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest22407()
{
	bool b;
	b = this.IsOutsideTest22(new decimal?(decimal.MaxValue), 
							 new decimal?(2034639888M), default(decimal));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest22578()
{
	bool b;
	b =
	  this.IsOutsideTest22(default(decimal?), new decimal?(0e-4M), default(decimal));
	Assert.AreEqual<bool>(false, b);
}
	}
}
