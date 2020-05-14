using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="EqualityTestingExtensionTest.RequireIsNullTest.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void RequireIsNullTest666()
{
    this.RequireIsNullTest<int>(default(int?));
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void RequireIsNullTestThrowsInvalidOperationException2()
{
    this.RequireIsNullTest<int>(null);
}
	}
}
