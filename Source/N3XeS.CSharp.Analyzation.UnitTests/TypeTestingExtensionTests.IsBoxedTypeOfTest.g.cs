using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="TypeTestingExtensionTests.IsBoxedTypeOfTest.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class TypeTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(TypeTestingExtensionTests))]
public void IsBoxedTypeOfTest120()
{
    bool b;
    b = this.IsBoxedTypeOfTest<int>((object)null);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeTestingExtensionTests))]
public void IsBoxedTypeOfTest939()
{
    bool b;
    object s0 = new object();
    b = this.IsBoxedTypeOfTest<int>(s0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
