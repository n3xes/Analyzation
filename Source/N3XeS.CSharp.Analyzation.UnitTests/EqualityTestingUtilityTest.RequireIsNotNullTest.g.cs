using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="EqualityTestingUtilityTest.RequireIsNotNullTest.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class EqualityTestingUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void RequireIsNotNullTestThrowsInvalidOperationException180()
{
    this.RequireIsNotNullTest<string>((string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTest))]
public void RequireIsNotNullTest552()
{
    this.RequireIsNotNullTest<string>("");
}
	}
}
