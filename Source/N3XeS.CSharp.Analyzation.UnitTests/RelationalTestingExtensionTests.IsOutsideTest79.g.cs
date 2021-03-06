using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsOutsideTest79.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideTest79904()
{
    bool b;
    b = this.IsOutsideTest79(default(uint?), default(uint?), default(uint?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest79538()
{
    bool b;
    b = this.IsOutsideTest79(new uint?(0u), default(uint?), default(uint?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest79579()
{
    bool b;
    b = this.IsOutsideTest79(new uint?(0u), new uint?(0u), default(uint?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest79128()
{
    bool b;
    b = this.IsOutsideTest79(new uint?(0u), new uint?(0u), new uint?(0u));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest79393()
{
    bool b;
    b = this.IsOutsideTest79(new uint?(1u), new uint?(0u), new uint?(0u));
    Assert.AreEqual<bool>(false, b);
}
	}
}
