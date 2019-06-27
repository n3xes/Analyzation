using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingUtilityTest.IsBetweenExclusiveTest05.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class GenericRelationalTestingUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest0525()
{
    bool b;
    b = this.IsBetweenExclusiveTest05<int>(new int?(1), 1, default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest05872()
{
    bool b;
    b = this.IsBetweenExclusiveTest05<int>(new int?(1), 1, new int?(0));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest05708()
{
    bool b;
    b = this.IsBetweenExclusiveTest05<int>(new int?(1), 1, new int?(2));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest05801()
{
    bool b;
    b = this.IsBetweenExclusiveTest05<int>(default(int?), 1, default(int?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
