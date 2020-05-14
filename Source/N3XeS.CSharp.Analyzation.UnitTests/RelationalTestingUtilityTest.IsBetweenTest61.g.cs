using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsBetweenTest61.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class RelationalTestingUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenTest6194()
{
	bool b;
	b = this.IsBetweenTest61(new sbyte?((sbyte)1), (sbyte)0, new sbyte?((sbyte)1));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenTest61429()
{
	bool b;
	b = this.IsBetweenTest61(new sbyte?((sbyte)3), (sbyte)0, new sbyte?((sbyte)2));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenTest61180()
{
	bool b;
	b = this.IsBetweenTest61(default(sbyte?), (sbyte)0, new sbyte?((sbyte)1));
	Assert.AreEqual<bool>(false, b);
}
	}
}
