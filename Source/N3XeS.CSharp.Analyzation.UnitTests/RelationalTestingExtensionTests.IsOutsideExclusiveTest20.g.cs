using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsOutsideExclusiveTest20.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideExclusiveTest205()
{
    bool b;
    b = this.IsOutsideExclusiveTest20
            (new decimal?(0e-4M), default(decimal), default(decimal));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest20213()
{
    bool b;
    b = this.IsOutsideExclusiveTest20
            (new decimal?(-76819052936496198642298613574e-19M), 1M, default(decimal));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideExclusiveTest20811()
{
    bool b;
    b = this.IsOutsideExclusiveTest20
            (default(decimal?), default(decimal), default(decimal));
    Assert.AreEqual<bool>(false, b);
}
	}
}
