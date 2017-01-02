// <copyright file="AssemblyInfo.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Enterprise Library Semantic Logging Application Block")]
[assembly: AssemblyDescription("The Semantic Logging Application Block provides a set of destinations (sinks) to persist application events published using a subclass of the EventSource class from the System.Diagnostics.Tracing namespace. Sinks include Azure table storage, SQL Server databases, file, console and rolling files with several formats and you can extend the block by creating your own custom formatters and sinks. The console sink is part of this nuget package. Other Sinks mentioned above are available as separate nuget packages. For the sinks that can store structured data, the block preserves the full structure of the event payload in order to facilitate analysing or processing the logged data.\r\n\r\nThis re-implementation is because, as of Dec '16, SematicLogging seems to have been abandoned by Microsoft. By re-implementing, it allows The Community to maintain and update software.\r\n\r\nFull credit, license and attribution for original source go to Microsoft.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Rolosoft")]
[assembly: AssemblyProduct("Rolosoft.Practices.EnterpriseLibrary.SemanticLogging")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("2c0182ab-46ea-4f44-a128-2e286da7a378")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0.0")]
[assembly: CLSCompliant(false)]
[assembly: InternalsVisibleTo("Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010077DC615552087D107CF90EBCCDDF5E53CE31A210855193971D636B31628F04CF22CCA67EA333831A51F058DDD1DA121C10D054268DF9EDC058EEC5145195B22A3A9FE3E80A3B67F399F727C7359A4277E15BA84EDC66E38C9466B778109ACA4A4A9C2CD93ED83B9C453E26130E3B74293AA6660D954AD25ABBE057A37B18F99B")]
[assembly: InternalsVisibleTo("Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.EventSourceAnalyzer, PublicKey=00240000048000009400000006020000002400005253413100040000010001004F5D50B10856A8D1D8C1B0DCB51A79CACF6AD7162F773493B9705850025DA4DFF41D8297A66B431727AEF9A94AA54B1A7778EC7633BBCA6C25DA0FFF93995A45503741114948AD62D9DAC651D0D99D9FB52DFE889BFB729E27866CCFF046EBEC5EBABE9573EEA72CEFED92C0A07F058D40DE6236B54183DB5DA7D27983E38CBD")]
[assembly: InternalsVisibleTo("Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.WindowsAzure, PublicKey=002400000480000094000000060200000024000052534131000400000100010045F4D910AC894166CAEBE3AD57F3D1CA368CD2F487F943C1CA444D742AC35B5D2DBE0F8C45EE7B5A4945DF74989AD102846FF281ACDE75FD0F2C6E8C0F811AD12B8BC1C5AA7FA613569E13F20AC7AD2876FBEC479D8B0FE06C14C72C0B57D791EED310C6EF9F15873DB637A7E772B486729321D5D52FC01A55730255EB1C4FA5")]