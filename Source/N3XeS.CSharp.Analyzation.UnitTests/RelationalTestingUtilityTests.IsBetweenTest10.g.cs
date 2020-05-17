using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsBetweenTest10.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenTest10741()
{
    bool b;
    b = this.IsBetweenTest10((byte)0, new byte?((byte)1), (byte)0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest10773()
{
    bool b;
    b = this.IsBetweenTest10((byte)1, new byte?((byte)1), (byte)0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest10421()
{
    bool b;
    b = this.IsBetweenTest10((byte)0, default(byte?), (byte)0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
