using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsBetweenTest35.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenTest35841()
{
    bool b;
    b = this.IsBetweenTest35((float)0, new float?((float)0), new float?((float)1));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest35859()
{
    bool b;
    b =
      this.IsBetweenTest35((float)0, new float?((float)0), new float?((float)(-1)));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest3557()
{
    bool b;
    b = this.IsBetweenTest35((float)0, default(float?), new float?((float)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest35579()
{
    bool b;
    b = this.IsBetweenTest35((float)0, new float?((float)0), default(float?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
