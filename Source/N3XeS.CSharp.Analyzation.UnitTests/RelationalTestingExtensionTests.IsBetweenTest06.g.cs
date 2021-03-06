using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsBetweenTest06.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenTest06419()
{
    bool b;
    b = this.IsBetweenTest06(new DateTime?
                                 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
                             new DateTime?
                                 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
                             default(DateTime));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenTest0641901()
{
    bool b;
    b = this.IsBetweenTest06(new DateTime?(default(DateTime)), new DateTime?
                                                                   (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
                                                               new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenTest06951()
{
    bool b;
    b = this.IsBetweenTest06(default(DateTime?), new DateTime?
                                                     (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
                                                 default(DateTime));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsBetweenTest06441()
{
    bool b;
    b = this.IsBetweenTest06(new DateTime?
                                 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
                             default(DateTime?), default(DateTime));
    Assert.AreEqual<bool>(false, b);
}
	}
}
