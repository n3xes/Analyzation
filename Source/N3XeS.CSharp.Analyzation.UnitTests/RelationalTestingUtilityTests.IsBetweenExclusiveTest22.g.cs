using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsBetweenExclusiveTest22.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenExclusiveTest22952()
{
    bool b;
    b = this.IsBetweenExclusiveTest22
            (new decimal?(0e-4M), new decimal?(0e-4M), default(decimal));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest2269()
{
    bool b;
    b = this.IsBetweenExclusiveTest22
            (new decimal?(-76819052936496198642298613574e-19M), 
             new decimal?(0e-4M), 1M);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest22578()
{
    bool b;
    b = this.IsBetweenExclusiveTest22
            (default(decimal?), new decimal?(0e-4M), default(decimal));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest22947()
{
    bool b;
    b = this.IsBetweenExclusiveTest22
            (new decimal?(0e-4M), default(decimal?), default(decimal));
    Assert.AreEqual<bool>(false, b);
}
	}
}
