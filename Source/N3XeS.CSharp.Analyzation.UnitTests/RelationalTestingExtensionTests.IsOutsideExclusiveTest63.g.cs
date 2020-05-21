using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsOutsideExclusiveTest63.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideExclusiveTest63295()
{
    bool b;
    b = this.IsOutsideExclusiveTest63
            (new sbyte?((sbyte)1), new sbyte?((sbyte)2), new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest63487()
{
    bool b;
    b = this.IsOutsideExclusiveTest63
            (new sbyte?((sbyte)2), new sbyte?((sbyte)(-125)), new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest63771()
{
    bool b;
    b = this.IsOutsideExclusiveTest63
            (default(sbyte?), new sbyte?((sbyte)2), new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest63279()
{
    bool b;
    b = this.IsOutsideExclusiveTest63
            (new sbyte?((sbyte)1), new sbyte?((sbyte)2), default(sbyte?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest63939()
{
    bool b;
    b = this.IsOutsideExclusiveTest63
            (new sbyte?((sbyte)1), default(sbyte?), new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(false, b);
}
	}
}
