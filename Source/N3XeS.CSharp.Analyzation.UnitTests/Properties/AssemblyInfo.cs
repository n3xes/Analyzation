#region Header: Copyright © 2016, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="AssemblyInfo.cs">
//		Copyright © 2016, John Caruthers
//		All rights reserved.
//
//		THIS PROGRAM ND ALL OF THE INFORMATION CONTAINED HEREIN IS FREE SOFTWARE:
//		YOU CAN REDISTRIBUTE IT AND/OR MODIFY IT UNDER THE TERMS OF THE GNU GENERAL
//		PUBLIC LICENSE AS PUBLISHED BY THE FREE SOFTWARE FOUNDATION, EITHER VERSION
//		3 OF THE LICENSE, OR (AT YOUR OPTION) ANY LATER VERSION.
//
//		THIS PROGRAM IS DISTRIBUTED IN THE HOPE THAT IT WILL BE USEFUL, BUT WITHOUT
//		ANY WARRANTY; WITHOUT EVEN THE IMPLIED WARRANTY OF MERCHANTABILITY OR FITNESS
//		FOR A PARTICULAR PURPOSE.SEE THE GNU GENERAL PUBLIC LICENSE FOR MORE DETAILS.
//
//		YOU SHOULD HAVE RECEIVED A COPY OF THE GNU GENERAL PUBLIC LICENSE ALONG
//		WITH THIS PROGRAM.  IF NOT, SEE https://www.gnu.org/licenses/.
//
// </copyright>
////====================================================================================================================

#endregion

#region Directives

using System;
using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

#endregion

// System.Reflection

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("N3XeS C# - Analyzation Library Unit Tests")]
[assembly: AssemblyDescription("The N3XeS C# library containing extensions and utilities that are intended to increase code readability when analyzing variables IntelliTest unit tests.")]
[assembly: AssemblyCompany("John Caruthers")]
[assembly: AssemblyProduct("N3XeS.CSharp.Analyzation.UnitTests")]
[assembly: AssemblyCopyright("Copyright (c) 2016, John Caruthers")]
[assembly: AssemblyTrademark("N3XeS is a registered trademark of, John Caruthers")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyFileVersion("1.0.*")]
[assembly: AssemblyVersion("1.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0")]

[assembly: AssemblyCulture("neutral")]
[assembly: NeutralResourcesLanguage("en-US")]

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]

#else

[assembly: AssemblyConfiguration("Release")]

#endif

// ReSharper disable CommentTypo
/*
#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35 && !NETFX_V4)

[assembly: AssemblySignatureKey("002400000c8000009400000006020000002400005253413100040000010001000575155da724746c5cd0924ba40223b08058c57c980d3c48e5a92d2ee6f622df8aaee8d08a1f668c782e28b43c2686f5d1f6dab34e91327a7fdac253a210099ce1cd90af8ad086d2894937e8b35a737516f2b445462f058e440d170c8b35908cf8fcb88116a9f3fe82ff2a0dce3002bbb6241f768a9ab3e85e2afb257db15cb3",
								"0dd0a57727d6887f8a19b4ae7c39ec465f04224332b14b0396c20112e24da0fb9a6e87f54ba7ed9a4d32ab9c9806e08258ee0aace5ff1641000078a84db73f19e7d3686309ee1f6917f24d39d82974d4fbf1bff4950d65d19dbdbadd7468b0cb657cb96f35ad692ac7e5b574a08839fce7baafdbe135450c412c6906d92ba305")]
#endif
*/
// ReSharper restore CommentTypo

// System
[assembly: CLSCompliant(false)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following Guid is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("94a57223-2e73-4d7a-aa15-14ad611d0cc1")]

// System.Runtime.CompilerServices
[assembly: InternalsVisibleTo("Microsoft.Pex, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]

// System.Security
[assembly: SecurityRules(SecurityRuleSet.Level1)]
