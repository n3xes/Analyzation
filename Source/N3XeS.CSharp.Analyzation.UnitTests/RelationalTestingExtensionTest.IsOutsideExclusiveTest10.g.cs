using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsOutsideExclusiveTest10.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class RelationalTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideExclusiveTest10741()
{
	bool b;
	b = this.IsOutsideExclusiveTest10((byte)0, new byte?((byte)1), (byte)0);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideExclusiveTest10214()
{
	bool b;
	b = this.IsOutsideExclusiveTest10((byte)128, new byte?((byte)1), (byte)0);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideExclusiveTest10421()
{
	bool b;
	b = this.IsOutsideExclusiveTest10((byte)0, default(byte?), (byte)0);
	Assert.AreEqual<bool>(false, b);
}
	}
}
