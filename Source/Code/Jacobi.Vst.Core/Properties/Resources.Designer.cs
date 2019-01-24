﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jacobi.Vst.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Jacobi.Vst.Core.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value is not a valid four character code..
        /// </summary>
        internal static string FourCharacterCode_InvalidValue {
            get {
                return ResourceManager.GetString("FourCharacterCode_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the managed VST plugin assembly with either the .net.dll or .net.vstdll extension..
        /// </summary>
        internal static string ManagedPluginFactory_FileNotFound {
            get {
                return ResourceManager.GetString("ManagedPluginFactory_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; does not expose a public class that implements the IVstPluginCommandStub interface..
        /// </summary>
        internal static string ManagedPluginFactory_NoPublicStub {
            get {
                return ResourceManager.GetString("ManagedPluginFactory_NoPublicStub", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument is empty..
        /// </summary>
        internal static string Throw_ArgumentIsEmpty {
            get {
                return ResourceManager.GetString("Throw_ArgumentIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value should lie between &apos;{0}&apos; and &apos;{1}&apos;..
        /// </summary>
        internal static string Throw_ArgumentNotInRange {
            get {
                return ResourceManager.GetString("Throw_ArgumentNotInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is too long. Maximum length is {1} characters..
        /// </summary>
        internal static string Throw_ArgumentTooLong {
            get {
                return ResourceManager.GetString("Throw_ArgumentTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Audio buffer is read-only..
        /// </summary>
        internal static string VstAudioBuffer_BufferNotWritable {
            get {
                return ResourceManager.GetString("VstAudioBuffer_BufferNotWritable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The destination buffer is too small..
        /// </summary>
        internal static string VstAudioBuffer_BufferTooSmall {
            get {
                return ResourceManager.GetString("VstAudioBuffer_BufferTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot construct an event of type Unknown..
        /// </summary>
        internal static string VstEvent_InvalidEventType {
            get {
                return ResourceManager.GetString("VstEvent_InvalidEventType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified eventType is not generic (deprecated)..
        /// </summary>
        internal static string VstGenericEvent_InvalidEventType {
            get {
                return ResourceManager.GetString("VstGenericEvent_InvalidEventType", resourceCulture);
            }
        }
    }
}
