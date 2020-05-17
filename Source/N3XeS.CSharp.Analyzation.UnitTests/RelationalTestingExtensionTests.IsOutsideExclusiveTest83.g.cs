using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsOutsideExclusiveTest83.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Extensions.Tests
{
	public partial class RelationalTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest83710()
{
    bool b;
    b = this.IsOutsideExclusiveTest83(0uL, new ulong?(1uL), new ulong?(1uL));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest83103()
{
    bool b;
    b = this.IsOutsideExclusiveTest83
            (9223372036854775808uL, new ulong?(1uL), new ulong?(1uL));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest8357()
{
    bool b;
    b = this.IsOutsideExclusiveTest83(0uL, default(ulong?), new ulong?(1uL));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest83859()
{
    bool b;
    b = this.IsOutsideExclusiveTest83(0uL, new ulong?(1uL), default(ulong?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
