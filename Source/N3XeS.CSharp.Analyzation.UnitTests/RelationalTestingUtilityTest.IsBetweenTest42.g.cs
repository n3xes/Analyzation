using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsBetweenTest42.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenTest42868()
{
	bool b;
	b = this.IsBetweenTest42(0, new int?(1), 0);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenTest42781()
{
	bool b;
	b = this.IsBetweenTest42(3, new int?(1), 2);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenTest42551()
{
	bool b;
	b = this.IsBetweenTest42(0, default(int?), 0);
	Assert.AreEqual<bool>(false, b);
}
	}
}
