using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsBetweenExclusiveTest19.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class RelationalTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest1948()
{
	bool b;
	b = this.IsBetweenExclusiveTest19
			(default(decimal), new decimal?(0e-4M), new decimal?(0e-4M));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest1969()
{
	bool b;
	b = this.IsBetweenExclusiveTest19(-76819052936496198642298613574e-19M, 
									  new decimal?(0e-4M), new decimal?(1M));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest19219()
{
	bool b;
	b = this.IsBetweenExclusiveTest19
			(default(decimal), default(decimal?), new decimal?(0e-4M));
	Assert.AreEqual<bool>(false, b);
}
	}
}
