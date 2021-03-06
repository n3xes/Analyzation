using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsBetweenExclusiveTest71.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenExclusiveTest71904()
{
    bool b;
    b = this.IsBetweenExclusiveTest71
            (default(short?), default(short?), default(short?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest71538()
{
    bool b;
    b = this.IsBetweenExclusiveTest71
            (new short?((short)0), default(short?), default(short?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest71579()
{
    bool b;
    b = this.IsBetweenExclusiveTest71
            (new short?((short)0), new short?((short)0), default(short?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest71766()
{
    bool b;
    b = this.IsBetweenExclusiveTest71
            (new short?((short)0), new short?((short)0), new short?((short)0));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest71945()
{
    bool b;
    b = this.IsBetweenExclusiveTest71
            (new short?((short)0), new short?((short)0), new short?((short)34));
    Assert.AreEqual<bool>(false, b);
}
	}
}
