using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsOutsideTest55.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideTest55239()
{
    bool b;
    b = this.IsOutsideTest55(new long?(1073741824L), new long?(2L), new long?(1L));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest55737()
{
    bool b;
    b = this.IsOutsideTest55
            (new long?(-9223372036854775805L), new long?(2L), new long?(1L));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest55184()
{
    bool b;
    b = this.IsOutsideTest55(default(long?), new long?(2L), new long?(1L));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest55658()
{
    bool b;
    b = this.IsOutsideTest55(new long?(1073741824L), new long?(2L), default(long?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest55337()
{
    bool b;
    b = this.IsOutsideTest55(new long?(1073741824L), default(long?), new long?(1L));
    Assert.AreEqual<bool>(false, b);
}
	}
}
