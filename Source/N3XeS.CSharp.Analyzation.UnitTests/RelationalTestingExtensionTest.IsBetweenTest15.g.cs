using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsBetweenTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenTest15295()
{
	bool b;
	b = this.IsBetweenTest15
			(new byte?((byte)1), new byte?((byte)2), new byte?((byte)1));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest15279()
{
	bool b;
	b = this.IsBetweenTest15(new byte?((byte)1), new byte?((byte)2), default(byte?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest15829()
{
	bool b;
	b = this.IsBetweenTest15
			(new byte?((byte)3), new byte?((byte)2), new byte?((byte)2));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest15771()
{
	bool b;
	b = this.IsBetweenTest15(default(byte?), new byte?((byte)2), new byte?((byte)1));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest15939()
{
	bool b;
	b = this.IsBetweenTest15(new byte?((byte)1), default(byte?), new byte?((byte)1));
	Assert.AreEqual<bool>(false, b);
}
	}
}
