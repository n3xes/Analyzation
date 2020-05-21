using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsOutsideExclusiveTest17.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideExclusiveTest17181()
{
    bool b;
    b = this.IsOutsideExclusiveTest17
            (default(decimal), default(decimal), new decimal?(0e-4M));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest17423()
{
    bool b;
    b = this.IsOutsideExclusiveTest17
            (-76819052936496198642298613574e-19M, 1M, new decimal?(0e-4M));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest17579()
{
    bool b;
    b = this.IsOutsideExclusiveTest17
            (default(decimal), default(decimal), default(decimal?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
