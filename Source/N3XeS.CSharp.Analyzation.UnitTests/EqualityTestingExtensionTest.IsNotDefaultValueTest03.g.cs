using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="EqualityTestingExtensionTest.IsNotDefaultValueTest03.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class EqualityTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTest))]
public void IsNotDefaultValueTest03304()
{
    bool b;
    Guid s0 = new Guid(1, (short)64, (short)64, default(byte), default(byte), 
                       default(byte), default(byte), default(byte), 
                       default(byte), default(byte), default(byte));
    b = this.IsNotDefaultValueTest03(new Guid?(s0));
    Assert.AreEqual<bool>(true, b);
}
	}
}
