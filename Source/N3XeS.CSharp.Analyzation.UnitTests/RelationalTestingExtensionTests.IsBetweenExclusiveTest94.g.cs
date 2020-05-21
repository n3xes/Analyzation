using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsBetweenExclusiveTest94.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenExclusiveTest9432()
{
    bool b;
    b = this.IsBetweenExclusiveTest94
            (new ushort?((ushort)32), new ushort?((ushort)65), (ushort)64);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest94600()
{
    bool b;
    b = this.IsBetweenExclusiveTest94
            (new ushort?((ushort)32), new ushort?((ushort)65), (ushort)32);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest94711()
{
    bool b;
    b = this.IsBetweenExclusiveTest94
            (default(ushort?), new ushort?((ushort)65), (ushort)64);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest94124()
{
    bool b;
    b = this.IsBetweenExclusiveTest94
            (new ushort?((ushort)32), default(ushort?), (ushort)64);
    Assert.AreEqual<bool>(false, b);
}
	}
}
