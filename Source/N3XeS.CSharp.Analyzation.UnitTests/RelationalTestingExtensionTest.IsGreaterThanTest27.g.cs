using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsGreaterThanTest27.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsGreaterThanTest27148()
{
	bool b;
	b = this.IsGreaterThanTest27(new long?(1L), new long?(1L));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsGreaterThanTest27729()
{
	bool b;
	b = this.IsGreaterThanTest27(new long?(1L), default(long?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsGreaterThanTest27888()
{
	bool b;
	b = this.IsGreaterThanTest27(default(long?), new long?(1L));
	Assert.AreEqual<bool>(false, b);
}
	}
}
