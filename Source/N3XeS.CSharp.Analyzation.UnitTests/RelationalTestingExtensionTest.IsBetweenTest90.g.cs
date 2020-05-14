using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsBetweenTest90.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenTest90761()
{
	bool b;
	b = this.IsBetweenTest90((ushort)64, new ushort?((ushort)65), (ushort)64);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest90664()
{
	bool b;
	b = this.IsBetweenTest90((ushort)67, new ushort?((ushort)65), (ushort)66);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest90722()
{
	bool b;
	b = this.IsBetweenTest90((ushort)64, default(ushort?), (ushort)64);
	Assert.AreEqual<bool>(false, b);
}
	}
}
