using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsGreaterThanOrEqualTest27.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class RelationalTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsGreaterThanOrEqualTest27826()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest27(new long?(1L), new long?(1L));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsGreaterThanOrEqualTest27888()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest27(default(long?), new long?(1L));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsGreaterThanOrEqualTest27729()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest27(new long?(1L), default(long?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
