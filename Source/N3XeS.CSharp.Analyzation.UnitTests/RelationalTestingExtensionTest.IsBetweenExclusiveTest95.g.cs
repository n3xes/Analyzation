using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsBetweenExclusiveTest95.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest95904()
{
	bool b;
	b = this.IsBetweenExclusiveTest95
			(default(ushort?), default(ushort?), default(ushort?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest95538()
{
	bool b;
	b = this.IsBetweenExclusiveTest95
			(new ushort?((ushort)0), default(ushort?), default(ushort?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest95579()
{
	bool b;
	b = this.IsBetweenExclusiveTest95
			(new ushort?((ushort)0), new ushort?((ushort)0), default(ushort?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest95766()
{
	bool b;
	b = this.IsBetweenExclusiveTest95
			(new ushort?((ushort)0), new ushort?((ushort)0), new ushort?((ushort)0));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest95235()
{
	bool b;
	b = this.IsBetweenExclusiveTest95
			(new ushort?((ushort)0), new ushort?((ushort)0), new ushort?((ushort)66));
	Assert.AreEqual<bool>(false, b);
}
	}
}
