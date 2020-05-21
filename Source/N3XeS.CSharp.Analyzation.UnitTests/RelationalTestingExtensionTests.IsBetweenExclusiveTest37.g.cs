using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsBetweenExclusiveTest37.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenExclusiveTest37241()
{
    bool b;
    b = this.IsBetweenExclusiveTest37
            (new float?((float)0), (float)0, new float?((float)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest37540()
{
    bool b;
    b = this.IsBetweenExclusiveTest37
            (new float?((float)(-1)), (float)0, new float?((float)(-39)));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest37483()
{
    bool b;
    b =
      this.IsBetweenExclusiveTest37(default(float?), (float)0, new float?((float)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest37579()
{
    bool b;
    b =
      this.IsBetweenExclusiveTest37(new float?((float)0), (float)0, default(float?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
