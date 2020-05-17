using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsBetweenTest95.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenTest95904()
{
    bool b;
    b = this.IsBetweenTest95(default(ushort?), default(ushort?), default(ushort?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest95538()
{
    bool b;
    b = this.IsBetweenTest95
            (new ushort?((ushort)0), default(ushort?), default(ushort?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest95579()
{
    bool b;
    b = this.IsBetweenTest95
            (new ushort?((ushort)0), new ushort?((ushort)0), default(ushort?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest95128()
{
    bool b;
    b = this.IsBetweenTest95
            (new ushort?((ushort)0), new ushort?((ushort)0), new ushort?((ushort)0));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest9553()
{
    bool b;
    b = this.IsBetweenTest95
            (new ushort?((ushort)66), new ushort?((ushort)0), new ushort?((ushort)0));
    Assert.AreEqual<bool>(false, b);
}
	}
}
