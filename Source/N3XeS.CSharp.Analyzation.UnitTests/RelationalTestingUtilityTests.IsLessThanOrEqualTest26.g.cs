using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsLessThanOrEqualTest26.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
	public partial class RelationalTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsLessThanOrEqualTest26464()
{
    bool b;
    b = this.IsLessThanOrEqualTest26(new long?(1L), 0L);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsLessThanOrEqualTest26495()
{
    bool b;
    b = this.IsLessThanOrEqualTest26(default(long?), 0L);
    Assert.AreEqual<bool>(false, b);
}
	}
}
