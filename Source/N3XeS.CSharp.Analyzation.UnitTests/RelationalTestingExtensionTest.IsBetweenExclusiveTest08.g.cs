using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsBetweenExclusiveTest08.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest08488()
{
	bool b;
	b = this.IsBetweenExclusiveTest08((byte)0, (byte)0, (byte)0);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest08175()
{
	bool b;
	b = this.IsBetweenExclusiveTest08((byte)0, (byte)0, (byte)1);
	Assert.AreEqual<bool>(false, b);
}
	}
}
