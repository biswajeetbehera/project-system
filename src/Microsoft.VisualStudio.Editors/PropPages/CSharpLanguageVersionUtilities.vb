﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Namespace Microsoft.VisualStudio.Editors.PropertyPages

    ''' <summary>
    ''' Helpers for the C# language version switch
    ''' </summary>
    Friend NotInheritable Class CSharpLanguageVersionUtilities

        Public Const LanguageVersion_PropertyName As String = "LanguageVersion"

        ''' <summary>
        ''' Helper to get all language versions
        ''' </summary>
        Public Shared Function GetAllLanguageVersions() As CSharpLanguageVersion()

            Return New CSharpLanguageVersion() {
                CSharpLanguageVersion.Default,
                CSharpLanguageVersion.LatestMajor,
                CSharpLanguageVersion.Latest,
                CSharpLanguageVersion.Preview,
                CSharpLanguageVersion.ISO1,
                CSharpLanguageVersion.ISO2,
                CSharpLanguageVersion.Version3,
                CSharpLanguageVersion.Version4,
                CSharpLanguageVersion.Version5,
                CSharpLanguageVersion.Version6,
                CSharpLanguageVersion.Version7,
                CSharpLanguageVersion.Version7_1,
                CSharpLanguageVersion.Version7_2,
                CSharpLanguageVersion.Version7_3,
                CSharpLanguageVersion.Version8_0}

        End Function

    End Class

End Namespace
