using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="EqualityTestingUtilityTests.IsNullTest01.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class EqualityTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTests))]
public void IsNullTest0172()
{
    bool b;
    b = this.IsNullTest01<int>(default(int?));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTests))]
public void IsNullTest72()
{
    bool b;
    b = this.IsNullTest<string>((string)null);
    Assert.AreEqual<bool>(true, b);
}
	}
}
