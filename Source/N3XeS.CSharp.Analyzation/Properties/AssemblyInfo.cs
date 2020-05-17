#region Header: Copyright © 2013, John Caruthers

// --------------------------------------------------------------------------------------------------------------------
// <copyright company="John Caruthers" file="AssemblyInfo.cs">
//		Copyright © 2013, John Caruthers
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
////-------------------------------------------------------------------------------------------------------------------

#endregion

#region Directives

using System;
using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#endregion


// System.Reflection

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("N3XeS C# - Analyzation Library")]
[assembly: AssemblyDescription("The N3XeS C# library containing extensions and utilities that are intended to increase code readability when analyzing variables.")]
[assembly: AssemblyCompany("John Caruthers")]
[assembly: AssemblyProduct("N3XeS.CSharp.Analyzation")]
[assembly: AssemblyCopyright("Copyright (c) 2013, John Caruthers")]
[assembly: AssemblyTrademark("N3XeS is a registered trademark of, John Caruthers")]

[assembly: AssemblyMetadata("ImplicitNullability.AppliesTo", "InputParameters, RefParameters, OutParametersAndResult, Fields, Properties")]
[assembly: AssemblyMetadata("ImplicitNullability.Fields", "RestrictToReadonly, RestrictToReferenceTypes")]
[assembly: AssemblyMetadata("ImplicitNullability.Properties", "RestrictToGetterOnly, RestrictToReferenceTypes")]
[assembly: AssemblyMetadata("ImplicitNullability.GeneratedCode", "Exclude")]

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

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35 && !NETFX_V4)

[assembly: AssemblySignatureKey("002400000c8000009400000006020000002400005253413100040000010001000575155da724746c5cd0924ba40223b08058c57c980d3c48e5a92d2ee6f622df8aaee8d08a1f668c782e28b43c2686f5d1f6dab34e91327a7fdac253a210099ce1cd90af8ad086d2894937e8b35a737516f2b445462f058e440d170c8b35908cf8fcb88116a9f3fe82ff2a0dce3002bbb6241f768a9ab3e85e2afb257db15cb3",
								"0dd0a57727d6887f8a19b4ae7c39ec465f04224332b14b0396c20112e24da0fb9a6e87f54ba7ed9a4d32ab9c9806e08258ee0aace5ff1641000078a84db73f19e7d3686309ee1f6917f24d39d82974d4fbf1bff4950d65d19dbdbadd7468b0cb657cb96f35ad692ac7e5b574a08839fce7baafdbe135450c412c6906d92ba305")]
#endif

// System
[assembly: CLSCompliant(true)]

// System.Runtime.InteropServices

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
// The following Guid is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("485ddb92-fd42-4002-a432-fff59476f6e4")]

// System.Runtime.CompilerServices
[assembly: InternalsVisibleTo("N3XeS.CSharp.Analyzation.UnitTests, PublicKey=00240000048000009400000006020000002400005253413100040000010001005180f617f4a8705e297ce657715631e5589d5eeb3cc17ceec4c08a85c7dbb65d0896fd0f2ffa45d93fd28b0f01e5ed4bc36649ed1e29bb08198bf5806dfeece17d81404cc7ee1f5d06cf68a73a79af6d9c06033b24d3cc50ec7e818520e483c2a3549ac218cfbde74ee9c398b1b3ecb92f0f65b55b972c52ae14e076f1f386be")]
[assembly: InternalsVisibleTo("N3XeS.CSharp.Analyzation.Explorables, PublicKey=00240000048000009400000006020000002400005253413100040000010001005180f617f4a8705e297ce657715631e5589d5eeb3cc17ceec4c08a85c7dbb65d0896fd0f2ffa45d93fd28b0f01e5ed4bc36649ed1e29bb08198bf5806dfeece17d81404cc7ee1f5d06cf68a73a79af6d9c06033b24d3cc50ec7e818520e483c2a3549ac218cfbde74ee9c398b1b3ecb92f0f65b55b972c52ae14e076f1f386be")]

