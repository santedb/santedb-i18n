﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SanteDB.Core.i18n {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class UserMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UserMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SanteDB.Core.i18n.UserMessages", typeof(UserMessages).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Complete.
        /// </summary>
        public static string COMPLETE {
            get {
                return ResourceManager.GetString("COMPLETE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading {0}.
        /// </summary>
        public static string DOWNLOADING {
            get {
                return ResourceManager.GetString("DOWNLOADING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encrypting {0}....
        /// </summary>
        public static string ENCRYPTING {
            get {
                return ResourceManager.GetString("ENCRYPTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fetching data from upstream server....
        /// </summary>
        public static string FETCH_FROM_UPSTREAM {
            get {
                return ResourceManager.GetString("FETCH_FROM_UPSTREAM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} records processed ({1:#.#} rec/s).
        /// </summary>
        public static string IMPORTING {
            get {
                return ResourceManager.GetString("IMPORTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Importing {0}....
        /// </summary>
        public static string IMPORTING_NAME {
            get {
                return ResourceManager.GetString("IMPORTING_NAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing Databases - {0}.
        /// </summary>
        public static string INITIALIZE_DATABASE {
            get {
                return ResourceManager.GetString("INITIALIZE_DATABASE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing Services.
        /// </summary>
        public static string INITIALIZE_SERVICE {
            get {
                return ResourceManager.GetString("INITIALIZE_SERVICE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Service Instances.
        /// </summary>
        public static string INITIALIZE_SINGLETONS {
            get {
                return ResourceManager.GetString("INITIALIZE_SINGLETONS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing {0}.
        /// </summary>
        public static string INSTALLING {
            get {
                return ResourceManager.GetString("INSTALLING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing data.
        /// </summary>
        public static string PROCESSING {
            get {
                return ResourceManager.GetString("PROCESSING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The application configuration has been changed. Do you want to restart the application?.
        /// </summary>
        public static string RESTART_REQUESTED_CONFIRM {
            get {
                return ResourceManager.GetString("RESTART_REQUESTED_CONFIRM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting {0}....
        /// </summary>
        public static string START_DAEMON {
            get {
                return ResourceManager.GetString("START_DAEMON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting SanteDB.
        /// </summary>
        public static string STARTING_CONTEXT {
            get {
                return ResourceManager.GetString("STARTING_CONTEXT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping SanteDB.
        /// </summary>
        public static string STOPPING_CONTEXT {
            get {
                return ResourceManager.GetString("STOPPING_CONTEXT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking for updates.
        /// </summary>
        public static string UPDATE_CHECK {
            get {
                return ResourceManager.GetString("UPDATE_CHECK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Applying Updates - {0}.
        /// </summary>
        public static string UPDATE_DATABASE {
            get {
                return ResourceManager.GetString("UPDATE_DATABASE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updates are available for {0}. Do you wish to install them?.
        /// </summary>
        public static string UPDATE_INSTALL_CONFIRM {
            get {
                return ResourceManager.GetString("UPDATE_INSTALL_CONFIRM", resourceCulture);
            }
        }
    }
}
