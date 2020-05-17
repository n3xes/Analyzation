using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsLessThanOrEqualTest07.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsLessThanOrEqualTest07978()
{
    bool b;
    b = this.IsLessThanOrEqualTest07(new byte?((byte)1), new byte?((byte)1));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsLessThanOrEqualTest07154()
{
    bool b;
    b = this.IsLessThanOrEqualTest07(default(byte?), new byte?((byte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsLessThanOrEqualTest07620()
{
    bool b;
    b = this.IsLessThanOrEqualTest07(new byte?((byte)1), default(byte?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
