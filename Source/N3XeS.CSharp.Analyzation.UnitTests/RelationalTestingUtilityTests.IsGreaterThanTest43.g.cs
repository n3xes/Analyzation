using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsGreaterThanTest43.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class RelationalTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsGreaterThanTest43148()
{
    bool b;
    b = this.IsGreaterThanTest43(new ulong?(1uL), new ulong?(1uL));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsGreaterThanTest43888()
{
    bool b;
    b = this.IsGreaterThanTest43(default(ulong?), new ulong?(1uL));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsGreaterThanTest43729()
{
    bool b;
    b = this.IsGreaterThanTest43(new ulong?(1uL), default(ulong?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
