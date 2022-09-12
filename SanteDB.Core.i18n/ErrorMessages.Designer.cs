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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SanteDB.Core.i18n.ErrorMessages", typeof(ErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to Argument type {0} is not assignable from {1}.
        /// </summary>
        public static string ARGUMENT_INCOMPATIBLE_TYPE {
            get {
                return ResourceManager.GetString("ARGUMENT_INCOMPATIBLE_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected argument of type {0} but got {1}.
        /// </summary>
        public static string ARGUMENT_INVALID_TYPE {
            get {
                return ResourceManager.GetString("ARGUMENT_INVALID_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument {0} was null.
        /// </summary>
        public static string ARGUMENT_NULL {
            get {
                return ResourceManager.GetString("ARGUMENT_NULL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value {0} was not expected (allowed values: {1}).
        /// </summary>
        public static string ARGUMENT_OUT_OF_RANGE {
            get {
                return ResourceManager.GetString("ARGUMENT_OUT_OF_RANGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error parsing response message.
        /// </summary>
        public static string COMMUNICATION_RESPONSE_FAILURE {
            get {
                return ResourceManager.GetString("COMMUNICATION_RESPONSE_FAILURE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dependent property {0} was null.
        /// </summary>
        public static string DEPENDENT_PROPERTY_NULL {
            get {
                return ResourceManager.GetString("DEPENDENT_PROPERTY_NULL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class key {0} on {1} is already registered.
        /// </summary>
        public static string DUPLICATE_CLASS_CONCEPT {
            get {
                return ResourceManager.GetString("DUPLICATE_CLASS_CONCEPT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field {0} not found in the requested type.
        /// </summary>
        public static string FIELD_NOT_FOUND {
            get {
                return ResourceManager.GetString("FIELD_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Classification code is not valid on this type.
        /// </summary>
        public static string INVALID_CLASS_CODE {
            get {
                return ResourceManager.GetString("INVALID_CLASS_CODE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid expression type. Expected {0} but was given {1}.
        /// </summary>
        public static string INVALID_EXPRESSION_TYPE {
            get {
                return ResourceManager.GetString("INVALID_EXPRESSION_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mail messages cannot be moved between mailboxes belonging to different users.
        /// </summary>
        public static string MAIL_CANNOT_MOVE_OWNERS {
            get {
                return ResourceManager.GetString("MAIL_CANNOT_MOVE_OWNERS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a general error sending mail via the persistence repository.
        /// </summary>
        public static string MAIL_ERROR_SENDING {
            get {
                return ResourceManager.GetString("MAIL_ERROR_SENDING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sending mail requires the To field to be populated.
        /// </summary>
        public static string MAIL_MISISNG_TO {
            get {
                return ResourceManager.GetString("MAIL_MISISNG_TO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Types {0} and {1} are incompatible.
        /// </summary>
        public static string MAP_INCOMPATIBLE_TYPE {
            get {
                return ResourceManager.GetString("MAP_INCOMPATIBLE_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected instance of {0}.
        /// </summary>
        public static string MAP_INVALID_TYPE {
            get {
                return ResourceManager.GetString("MAP_INVALID_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find a configured map between {0} and {1}.
        /// </summary>
        public static string MAP_NOT_FOUND {
            get {
                return ResourceManager.GetString("MAP_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Collection is not initialize.
        /// </summary>
        public static string NOT_INITIALIZED {
            get {
                return ResourceManager.GetString("NOT_INITIALIZED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The implementation of this method is not supported on this object.
        /// </summary>
        public static string NOT_SUPPORTED {
            get {
                return ResourceManager.GetString("NOT_SUPPORTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided object must implement {0} to support this function.
        /// </summary>
        public static string NOT_SUPPORTED_IMPLEMENTATION {
            get {
                return ResourceManager.GetString("NOT_SUPPORTED_IMPLEMENTATION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No persistence service has been registered with source of {1} and target of {0}.
        /// </summary>
        public static string RELATED_OBJECT_NOT_AVAILABLE {
            get {
                return ResourceManager.GetString("RELATED_OBJECT_NOT_AVAILABLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sequence contains more than one element.
        /// </summary>
        public static string SEQUENCE_MORE_THAN_ONE {
            get {
                return ResourceManager.GetString("SEQUENCE_MORE_THAN_ONE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sequence contains no elements.
        /// </summary>
        public static string SEQUENCE_NO_ELEMENTS {
            get {
                return ResourceManager.GetString("SEQUENCE_NO_ELEMENTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription does not have a server side definition for this provider.
        /// </summary>
        public static string SUBSCRIPTION_MISSING_DEFINITION {
            get {
                return ResourceManager.GetString("SUBSCRIPTION_MISSING_DEFINITION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription does not contain a definition for provider {0}.
        /// </summary>
        public static string SUBSCRIPTION_NO_DEFINITION_FOR_PROVIDER {
            get {
                return ResourceManager.GetString("SUBSCRIPTION_NO_DEFINITION_FOR_PROVIDER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription identifies an invalid target. Only {0} are allowed as targets of a subscription. Consider using these as a base type for subscription definition..
        /// </summary>
        public static string SUBSCRIPTION_NOT_SUPPORTED_RESOURCE {
            get {
                return ResourceManager.GetString("SUBSCRIPTION_NOT_SUPPORTED_RESOURCE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription requires persistence service for {0} but none is registered.
        /// </summary>
        public static string SUBSCRIPTION_RESOURCE_NOSTORE {
            get {
                return ResourceManager.GetString("SUBSCRIPTION_RESOURCE_NOSTORE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling {0} would result in an invalid state for this object.
        /// </summary>
        public static string WOULD_RESULT_INVALID_STATE {
            get {
                return ResourceManager.GetString("WOULD_RESULT_INVALID_STATE", resourceCulture);
            }
        }
    }
}
