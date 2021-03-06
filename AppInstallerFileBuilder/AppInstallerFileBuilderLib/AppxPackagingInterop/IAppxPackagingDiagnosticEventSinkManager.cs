﻿//-----------------------------------------------------------------------
// <copyright file="IAppxPackagingDiagnosticEventSinkManager.cs" company="Microsoft">
//     Copyright (c) Microsoft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Microsoft.Packaging.SDKUtils.AppxPackagingInterop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;

    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "*", Justification = "Interop")]
    [Guid("369648FA-A7EB-4909-A15D-6954A078F18A"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAppxPackagingDiagnosticEventSinkManager : IDisposable
    {
        void SetSinkForProcess(
            [In] IAppxPackagingDiagnosticEventSink sink);

        void SetSinkForThread(
            [In] IAppxPackagingDiagnosticEventSink sink);
    }
}
