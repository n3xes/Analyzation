using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsBetweenTest70.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenTest7032()
{
	bool b;
	b =
	  this.IsBetweenTest70(new short?((short)32), new short?((short)65), (short)64);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest70198()
{
	bool b;
	b =
	  this.IsBetweenTest70(new short?((short)68), new short?((short)65), (short)64);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest70711()
{
	bool b;
	b = this.IsBetweenTest70(default(short?), new short?((short)65), (short)64);
	Assert.AreEqual<bool>(false, b);
}
	}
}
