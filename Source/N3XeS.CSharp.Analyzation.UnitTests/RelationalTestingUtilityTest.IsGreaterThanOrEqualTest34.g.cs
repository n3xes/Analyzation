using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsGreaterThanOrEqualTest34.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsGreaterThanOrEqualTest34286()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest34(new short?((short)65), (short)32);
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsGreaterThanOrEqualTest34770()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest34(default(short?), (short)32);
	Assert.AreEqual<bool>(false, b);
}
	}
}
