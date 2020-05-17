using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsBetweenExclusiveTest63.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenExclusiveTest63295()
{
    bool b;
    b = this.IsBetweenExclusiveTest63
            (new sbyte?((sbyte)1), new sbyte?((sbyte)2), new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest63586()
{
    bool b;
    b = this.IsBetweenExclusiveTest63
            (new sbyte?((sbyte)2), new sbyte?((sbyte)2), new sbyte?((sbyte)3));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest63771()
{
    bool b;
    b = this.IsBetweenExclusiveTest63
            (default(sbyte?), new sbyte?((sbyte)2), new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest63279()
{
    bool b;
    b = this.IsBetweenExclusiveTest63
            (new sbyte?((sbyte)1), new sbyte?((sbyte)2), default(sbyte?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest63939()
{
    bool b;
    b = this.IsBetweenExclusiveTest63
            (new sbyte?((sbyte)1), default(sbyte?), new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(false, b);
}
	}
}
