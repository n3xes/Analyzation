using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="EqualityTestingExtensionTests.IsNotDefaultValueTest19.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class EqualityTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTests))]
public void IsNotDefaultValueTest19162()
{
    bool b;
    b = this.IsNotDefaultValueTest19(default(short?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTests))]
public void IsNotDefaultValueTest19613()
{
    bool b;
    b = this.IsNotDefaultValueTest19(new short?((short)0));
    Assert.AreEqual<bool>(true, b);
}
	}
}
