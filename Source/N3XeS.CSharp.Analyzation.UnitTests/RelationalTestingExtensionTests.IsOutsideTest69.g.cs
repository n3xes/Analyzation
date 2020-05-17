using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsOutsideTest69.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Extensions.Tests
{
	public partial class RelationalTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest6912()
{
    bool b;
    b = this.IsOutsideTest69(new short?((short)65), (short)65, default(short?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest69456()
{
    bool b;
    b = this.IsOutsideTest69(default(short?), (short)65, default(short?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest69185()
{
    bool b;
    b = this.IsOutsideTest69(new short?((short)65), (short)65, new short?((short)0));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest69488()
{
    bool b;
    b = this.IsOutsideTest69(new short?((short)68), (short)64, new short?((short)0));
    Assert.AreEqual<bool>(false, b);
}
	}
}
