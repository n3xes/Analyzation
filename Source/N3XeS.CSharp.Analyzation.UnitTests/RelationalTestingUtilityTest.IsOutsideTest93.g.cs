using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsOutsideTest93.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideTest9312()
{
	bool b;
	b = this.IsOutsideTest93(new ushort?((ushort)65), (ushort)65, default(ushort?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest93185()
{
	bool b;
	b = this.IsOutsideTest93
			(new ushort?((ushort)65), (ushort)65, new ushort?((ushort)0));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest93627()
{
	bool b;
	b = this.IsOutsideTest93
			(new ushort?((ushort)65), (ushort)64, new ushort?((ushort)0));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest93456()
{
	bool b;
	b = this.IsOutsideTest93(default(ushort?), (ushort)65, default(ushort?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
