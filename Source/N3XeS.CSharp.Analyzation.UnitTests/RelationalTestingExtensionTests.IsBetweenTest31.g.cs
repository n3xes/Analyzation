using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsBetweenTest31.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenTest31809()
{
    bool b;
    b = this.IsBetweenTest31(new double?(0), new double?(1), new double?(2));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenTest31466()
{
    bool b;
    b = this.IsBetweenTest31(new double?(-1), new double?(1), new double?(-2));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenTest31316()
{
    bool b;
    b = this.IsBetweenTest31(default(double?), new double?(1), new double?(2));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenTest31859()
{
    bool b;
    b = this.IsBetweenTest31(new double?(0), new double?(1), default(double?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenTest31745()
{
    bool b;
    b = this.IsBetweenTest31(new double?(0), default(double?), new double?(2));
    Assert.AreEqual<bool>(false, b);
}
	}
}
