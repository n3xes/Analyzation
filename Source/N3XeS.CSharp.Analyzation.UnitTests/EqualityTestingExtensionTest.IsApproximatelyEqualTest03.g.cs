using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="EqualityTestingExtensionTest.IsApproximatelyEqualTest03.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class EqualityTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTest))]
public void IsApproximatelyEqualTest0330()
{
    bool b;
    b = this.IsApproximatelyEqualTest03(new double?(0), new double?(1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTest))]
public void IsApproximatelyEqualTest03210()
{
    bool b;
    b = this.IsApproximatelyEqualTest03(new double?(0), default(double?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTest))]
public void IsApproximatelyEqualTest03280()
{
    bool b;
    b = this.IsApproximatelyEqualTest03(default(double?), new double?(1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTest))]
public void IsApproximatelyEqualTest03143()
{
    bool b;
    b = this.IsApproximatelyEqualTest03(default(double?), default(double?));
    Assert.AreEqual<bool>(true, b);
}
	}
}
