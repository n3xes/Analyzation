using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsOutsideExclusiveTest91.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideExclusiveTest9116()
{
	bool b;
	b =
	  this.IsOutsideExclusiveTest91((ushort)65, default(ushort?), default(ushort?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest91376()
{
	bool b;
	b = this.IsOutsideExclusiveTest91
			((ushort)65, new ushort?((ushort)0), default(ushort?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest9114()
{
	bool b;
	b = this.IsOutsideExclusiveTest91
			((ushort)65, new ushort?((ushort)0), new ushort?((ushort)0));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest91706()
{
	bool b;
	b = this.IsOutsideExclusiveTest91
			((ushort)64, new ushort?((ushort)65), new ushort?((ushort)0));
	Assert.AreEqual<bool>(true, b);
}
	}
}
