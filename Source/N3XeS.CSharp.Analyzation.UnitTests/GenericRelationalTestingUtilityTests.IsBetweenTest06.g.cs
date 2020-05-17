using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingUtilityTests.IsBetweenTest06.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenTest06865()
{
    bool b;
    b = this.IsBetweenTest06<int>(new int?(512), new int?(1), 0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsBetweenTest06710()
{
    bool b;
    b = this.IsBetweenTest06<int>(new int?(0), new int?(1), 1);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsBetweenTest0681()
{
    bool b;
    b = this.IsBetweenTest06<int>(default(int?), new int?(1), 0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsBetweenTest06717()
{
    bool b;
    b = this.IsBetweenTest06<int>(new int?(512), default(int?), 0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
