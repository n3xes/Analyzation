using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsBetweenExclusiveTest11.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenExclusiveTest11953()
{
    bool b;
    b =
      this.IsBetweenExclusiveTest11((byte)0, new byte?((byte)1), new byte?((byte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest11331()
{
    bool b;
    b = this.IsBetweenExclusiveTest11
            ((byte)128, new byte?((byte)1), new byte?((byte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest11189()
{
    bool b;
    b = this.IsBetweenExclusiveTest11((byte)0, default(byte?), new byte?((byte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest11467()
{
    bool b;
    b = this.IsBetweenExclusiveTest11((byte)0, new byte?((byte)1), default(byte?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
