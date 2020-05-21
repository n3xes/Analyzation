using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsBetweenTest85.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenTest85831()
{
    bool b;
    b = this.IsBetweenTest85(new ulong?(1uL), 0uL, new ulong?(1uL));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenTest85865()
{
    bool b;
    b = this.IsBetweenTest85(new ulong?(3uL), 0uL, new ulong?(2uL));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenTest85483()
{
    bool b;
    b = this.IsBetweenTest85(default(ulong?), 0uL, new ulong?(1uL));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenTest85724()
{
    bool b;
    b = this.IsBetweenTest85(new ulong?(1uL), 0uL, default(ulong?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
