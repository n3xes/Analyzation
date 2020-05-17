using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingUtilityTests.IsBetweenExclusiveTest07.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Utilities.Tests
{
	public partial class GenericRelationalTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest07904()
{
    bool b;
    b = this.IsBetweenExclusiveTest07<int>
            (default(int?), default(int?), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest07538()
{
    bool b;
    b =
      this.IsBetweenExclusiveTest07<int>(new int?(0), default(int?), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest07579()
{
    bool b;
    b = this.IsBetweenExclusiveTest07<int>(new int?(0), new int?(0), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest07766()
{
    bool b;
    b = this.IsBetweenExclusiveTest07<int>(new int?(0), new int?(0), new int?(0));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest07591()
{
    bool b;
    b = this.IsBetweenExclusiveTest07<int>(new int?(1), new int?(0), new int?(88));
    Assert.AreEqual<bool>(true, b);
}
	}
}
