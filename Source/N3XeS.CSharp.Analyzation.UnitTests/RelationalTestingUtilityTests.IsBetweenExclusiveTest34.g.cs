using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsBetweenExclusiveTest34.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Utilities.Tests
{
	public partial class RelationalTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest34766()
{
    bool b;
    b = this.IsBetweenExclusiveTest34((float)0, new float?((float)0), (float)0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest34241()
{
    bool b;
    b = this.IsBetweenExclusiveTest34((float)0, new float?((float)0), (float)1);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest34551()
{
    bool b;
    b = this.IsBetweenExclusiveTest34((float)0, default(float?), (float)0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
