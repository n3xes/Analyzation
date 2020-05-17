using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsOutsideTest02.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideTest02675()
{
    bool b;
    b = this.IsOutsideTest02(default(DateTime), new DateTime?
                                                    (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
                                                default(DateTime));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest02419()
{
    bool b;
    b = this.IsOutsideTest02(new DateTime
                                 (4611686018427387903L & 65537L, (DateTimeKind)(65537uL >> 62)), 
                             new DateTime?(new DateTime
                                               (4611686018427387903L & 65536L, (DateTimeKind)(65536uL >> 62))), 
                             default(DateTime));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest02441()
{
    bool b;
    b =
      this.IsOutsideTest02(default(DateTime), default(DateTime?), default(DateTime));
    Assert.AreEqual<bool>(false, b);
}
	}
}
