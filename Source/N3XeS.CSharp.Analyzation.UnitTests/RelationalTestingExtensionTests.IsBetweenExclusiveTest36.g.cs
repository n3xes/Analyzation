using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsBetweenExclusiveTest36.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenExclusiveTest36766()
{
    bool b;
    b = this.IsBetweenExclusiveTest36(new float?((float)0), (float)0, (float)0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest36914()
{
    bool b;
    b = this.IsBetweenExclusiveTest36(new float?((float)(-1)), (float)0, (float)0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest36811()
{
    bool b;
    b = this.IsBetweenExclusiveTest36(default(float?), (float)0, (float)0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
