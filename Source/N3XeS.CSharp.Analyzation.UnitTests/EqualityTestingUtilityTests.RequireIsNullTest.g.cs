using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="EqualityTestingUtilityTests.RequireIsNullTest.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireIsNullTest666()
{
    this.RequireIsNullTest<int>(default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTests))]
[ExpectedException(typeof(InvalidOperationException))]
public void RequireIsNullTestThrowsInvalidOperationException972()
{
    this.RequireIsNullTest<int>(new int?(0));
}
	}
}
