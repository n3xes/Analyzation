using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="EqualityTestingExtensionTests.IsNotDefaultValueTest02.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class EqualityTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTests))]
public void IsNotDefaultValueTest02956()
{
    bool b;
    Guid s0
       = new Guid(default(int), (short)32, (short)32, default(byte), default(byte), 
                  default(byte), default(byte), default(byte), 
                  default(byte), default(byte), default(byte));
    b = this.IsNotDefaultValueTest02(s0);
    Assert.AreEqual<bool>(true, b);
}
	}
}
