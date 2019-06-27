using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsBetweenExclusiveTest12.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest12848()
{
	bool b;
	b = this.IsBetweenExclusiveTest12(new byte?((byte)1), (byte)0, (byte)0);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest12519()
{
	bool b;
	b = this.IsBetweenExclusiveTest12(new byte?((byte)2), (byte)0, (byte)3);
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest12279()
{
	bool b;
	b = this.IsBetweenExclusiveTest12(default(byte?), (byte)0, (byte)0);
	Assert.AreEqual<bool>(false, b);
}
	}
}
