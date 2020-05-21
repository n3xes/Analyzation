using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsOutsideTest94.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideTest9432()
{
    bool b;
    b = this.IsOutsideTest94
            (new ushort?((ushort)32), new ushort?((ushort)65), (ushort)64);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideTest94565()
{
    bool b;
    b = this.IsOutsideTest94
            (new ushort?((ushort)67), new ushort?((ushort)66), (ushort)64);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideTest94711()
{
    bool b;
    b = this.IsOutsideTest94(default(ushort?), new ushort?((ushort)65), (ushort)64);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideTest94124()
{
    bool b;
    b = this.IsOutsideTest94(new ushort?((ushort)32), default(ushort?), (ushort)64);
    Assert.AreEqual<bool>(false, b);
}
	}
}
