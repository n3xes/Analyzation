using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingExtensionTest.IsBetweenExclusiveTest06.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class GenericRelationalTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest06865()
{
    bool b;
    b = this.IsBetweenExclusiveTest06<int>(new int?(512), new int?(1), 0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest06710()
{
    bool b;
    b = this.IsBetweenExclusiveTest06<int>(new int?(0), new int?(1), 1);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest0681()
{
    bool b;
    b = this.IsBetweenExclusiveTest06<int>(default(int?), new int?(1), 0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
