using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsBetweenExclusiveTest60.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest60848()
{
	bool b;
	b = this.IsBetweenExclusiveTest60(new sbyte?((sbyte)1), (sbyte)0, (sbyte)0);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest60519()
{
	bool b;
	b = this.IsBetweenExclusiveTest60(new sbyte?((sbyte)2), (sbyte)0, (sbyte)3);
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest60279()
{
	bool b;
	b = this.IsBetweenExclusiveTest60(default(sbyte?), (sbyte)0, (sbyte)0);
	Assert.AreEqual<bool>(false, b);
}
	}
}
