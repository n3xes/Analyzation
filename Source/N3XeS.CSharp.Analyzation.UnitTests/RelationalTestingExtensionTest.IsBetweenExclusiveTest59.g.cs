using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsBetweenExclusiveTest59.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest59953()
{
	bool b;
	b = this.IsBetweenExclusiveTest59
			((sbyte)0, new sbyte?((sbyte)1), new sbyte?((sbyte)1));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest59401()
{
	bool b;
	b = this.IsBetweenExclusiveTest59
			((sbyte)0, new sbyte?((sbyte)1), new sbyte?((sbyte)(-127)));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest59189()
{
	bool b;
	b =
	  this.IsBetweenExclusiveTest59((sbyte)0, default(sbyte?), new sbyte?((sbyte)1));
	Assert.AreEqual<bool>(false, b);
}
	}
}
