using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsBetweenTest21.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Utilities.Tests
{
	public partial class RelationalTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest21220()
{
    bool b;
    b = this.IsBetweenTest21
            (new decimal?(0e-8M), default(decimal), new decimal?(0e-4M));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest21275()
{
    bool b;
    b = this.IsBetweenTest21(new decimal?(decimal.MaxValue), 
                             default(decimal), new decimal?(2034639888M));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest21104()
{
    bool b;
    b =
      this.IsBetweenTest21(default(decimal?), default(decimal), new decimal?(0e-4M));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest21576()
{
    bool b;
    b =
      this.IsBetweenTest21(new decimal?(0e-8M), default(decimal), default(decimal?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
