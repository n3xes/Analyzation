using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsGreaterThanOrEqualTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsGreaterThanOrEqualTest03984()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest03(default(DateTime?), default(DateTime?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsGreaterThanOrEqualTest03156()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest03
			(new DateTime?(default(DateTime)), default(DateTime?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsGreaterThanOrEqualTest0392()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest03
			(new DateTime?(default(DateTime)), new DateTime?(default(DateTime)));
	Assert.AreEqual<bool>(true, b);
}
	}
}
