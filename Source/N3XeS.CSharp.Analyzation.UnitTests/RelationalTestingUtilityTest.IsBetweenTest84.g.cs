using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsBetweenTest84.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenTest84393()
{
	bool b;
	b = this.IsBetweenTest84(new ulong?(1uL), 0uL, 0uL);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenTest84818()
{
	bool b;
	b = this.IsBetweenTest84(new ulong?(1uL), 0uL, 9223372036854775808uL);
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenTest84811()
{
	bool b;
	b = this.IsBetweenTest84(default(ulong?), 0uL, 0uL);
	Assert.AreEqual<bool>(false, b);
}
	}
}
