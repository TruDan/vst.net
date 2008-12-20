﻿using System;

namespace Jacobi.Vst.Core.Host
{
    /// <summary>
    /// The IVstPluginCommandStub interface is implemented by the command stub for the Plugin commands
    /// in the Interop assembly.
    /// </summary>
    /// <remarks>The interfaces derives from <see cref="IVstPluginCommands24"/>.</remarks>
    public interface IVstPluginCommandStub : IVstPluginCommands24
    {
        IVstPluginContext PluginContext { get; set; }
    }
}
