using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsOutsideExclusiveTest60.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideExclusiveTest60848()
{
    bool b;
    b = this.IsOutsideExclusiveTest60(new sbyte?((sbyte)1), (sbyte)0, (sbyte)0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest60495()
{
    bool b;
    b = this.IsOutsideExclusiveTest60(new sbyte?((sbyte)2), (sbyte)3, (sbyte)0);
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest60279()
{
    bool b;
    b = this.IsOutsideExclusiveTest60(default(sbyte?), (sbyte)0, (sbyte)0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
