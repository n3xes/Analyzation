using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsGreaterThanOrEqualTest17.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	public partial class RelationalTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsGreaterThanOrEqualTest17567()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest17((float)0, new float?((float)0));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsGreaterThanOrEqualTest17775()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest17((float)0, default(float?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
