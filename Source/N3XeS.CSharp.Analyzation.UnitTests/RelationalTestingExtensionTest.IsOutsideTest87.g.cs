using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsOutsideTest87.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideTest87239()
{
	bool b;
	b = this.IsOutsideTest87
			(new ulong?(1073741824uL), new ulong?(2uL), new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideTest87658()
{
	bool b;
	b = this.IsOutsideTest87
			(new ulong?(1073741824uL), new ulong?(2uL), default(ulong?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideTest87751()
{
	bool b;
	b = this.IsOutsideTest87
			(new ulong?(1uL), new ulong?(9223372036854775808uL), new ulong?(1uL));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideTest87184()
{
	bool b;
	b = this.IsOutsideTest87(default(ulong?), new ulong?(2uL), new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideTest87337()
{
	bool b;
	b = this.IsOutsideTest87
			(new ulong?(1073741824uL), default(ulong?), new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}
	}
}
