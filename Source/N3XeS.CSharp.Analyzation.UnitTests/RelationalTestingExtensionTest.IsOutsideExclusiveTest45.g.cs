using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsOutsideExclusiveTest45.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideExclusiveTest4525()
{
	bool b;
	b = this.IsOutsideExclusiveTest45(new int?(1), 1, default(int?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideExclusiveTest45872()
{
	bool b;
	b = this.IsOutsideExclusiveTest45(new int?(1), 1, new int?(0));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideExclusiveTest45868()
{
	bool b;
	b = this.IsOutsideExclusiveTest45(new int?(0), 1, new int?(0));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideExclusiveTest45801()
{
	bool b;
	b = this.IsOutsideExclusiveTest45(default(int?), 1, default(int?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
