using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsBetweenExclusiveTest69.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class RelationalTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest6912()
{
    bool b;
    b = this.IsBetweenExclusiveTest69
            (new short?((short)65), (short)65, default(short?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest69456()
{
    bool b;
    b = this.IsBetweenExclusiveTest69(default(short?), (short)65, default(short?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest69609()
{
    bool b;
    b = this.IsBetweenExclusiveTest69
            (new short?((short)65), (short)65, new short?((short)0));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest69492()
{
    bool b;
    b = this.IsBetweenExclusiveTest69
            (new short?((short)0), (short)65, new short?((short)66));
    Assert.AreEqual<bool>(false, b);
}
	}
}
