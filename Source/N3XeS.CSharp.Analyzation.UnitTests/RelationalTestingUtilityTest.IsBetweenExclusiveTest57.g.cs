using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsBetweenExclusiveTest57.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest57175()
{
	bool b;
	b = this.IsBetweenExclusiveTest57((sbyte)0, (sbyte)0, new sbyte?((sbyte)1));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest57788()
{
	bool b;
	b = this.IsBetweenExclusiveTest57((sbyte)0, (sbyte)0, new sbyte?((sbyte)(-127)));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest57204()
{
	bool b;
	b = this.IsBetweenExclusiveTest57((sbyte)0, (sbyte)0, default(sbyte?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
