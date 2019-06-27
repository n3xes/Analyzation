using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsOutsideExclusiveTest92.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideExclusiveTest92132()
{
	bool b;
	b =
	  this.IsOutsideExclusiveTest92(new ushort?((ushort)65), (ushort)32, (ushort)64);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest92264()
{
	bool b;
	b =
	  this.IsOutsideExclusiveTest92(new ushort?((ushort)66), (ushort)67, (ushort)64);
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest92787()
{
	bool b;
	b = this.IsOutsideExclusiveTest92(default(ushort?), (ushort)32, (ushort)64);
	Assert.AreEqual<bool>(false, b);
}
	}
}
