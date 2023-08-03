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
        ///   Looks up a localized string similar to Multiple records returned where one expected.
        /// </summary>
        public static string AMBIGUOUS_DATA_REFERENCE {
            get {
                return ResourceManager.GetString("AMBIGUOUS_DATA_REFERENCE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected {0} arguments but only {1} were provided.
        /// </summary>
        public static string ARGUMENT_COUNT_MISMATCH {
            get {
                return ResourceManager.GetString("ARGUMENT_COUNT_MISMATCH", resourceCulture);
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
        ///   Looks up a localized string similar to Required argument was null.
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
        ///   Looks up a localized string similar to Assertion failed. Expected {0} but was {1}.
        /// </summary>
        public static string ASSERTION_MISMATCH {
            get {
                return ResourceManager.GetString("ASSERTION_MISMATCH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error inserting transaction bundle (#{0}) - {1}.
        /// </summary>
        public static string BUNDLE_PERSISTENCE_ERROR {
            get {
                return ResourceManager.GetString("BUNDLE_PERSISTENCE_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot bind initial endpoint to HTTPS ensure a certificate is bound or that this process can bind a self-signed certificate.
        /// </summary>
        public static string CANNOT_BIND_CERTIFICATES {
            get {
                return ResourceManager.GetString("CANNOT_BIND_CERTIFICATES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot initialize the service host context - fatal startup error..
        /// </summary>
        public static string CANNOT_INITIALIZE_APPLICATION {
            get {
                return ResourceManager.GetString("CANNOT_INITIALIZE_APPLICATION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set value at path {0} (type: {1}).
        /// </summary>
        public static string CANNOT_SET_VALUE_AT_PATH {
            get {
                return ResourceManager.GetString("CANNOT_SET_VALUE_AT_PATH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot read data from this stream/source (write-only).
        /// </summary>
        public static string CANT_READ_WRITE_ONLY_STREAM {
            get {
                return ResourceManager.GetString("CANT_READ_WRITE_ONLY_STREAM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write data to this stream/source (read-only).
        /// </summary>
        public static string CANT_WRITE_READ_ONLY_STREAM {
            get {
                return ResourceManager.GetString("CANT_WRITE_READ_ONLY_STREAM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate installation failed.
        /// </summary>
        public static string CERTIFICATE_INSTALL_FAILED {
            get {
                return ResourceManager.GetString("CERTIFICATE_INSTALL_FAILED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication certificate could not be found.
        /// </summary>
        public static string CERTIFICATE_NOT_FOUND {
            get {
                return ResourceManager.GetString("CERTIFICATE_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate is not valid for use in this context.
        /// </summary>
        public static string CERTIFICATE_NOT_VALID {
            get {
                return ResourceManager.GetString("CERTIFICATE_NOT_VALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected certificate cannot be used to sign this request - Invalid Purpose.
        /// </summary>
        public static string CERTIFICATE_REQ_CANT_SIGN {
            get {
                return ResourceManager.GetString("CERTIFICATE_REQ_CANT_SIGN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate signing request is not valid.
        /// </summary>
        public static string CERTIFICATE_REQ_NOT_VALID {
            get {
                return ResourceManager.GetString("CERTIFICATE_REQ_NOT_VALID", resourceCulture);
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
        ///   Looks up a localized string similar to Connection string {0} not found.
        /// </summary>
        public static string CONNECTION_STRING_NOT_FOUND {
            get {
                return ResourceManager.GetString("CONNECTION_STRING_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data structure is not appropriate for {0} due to {1}.
        /// </summary>
        public static string DATA_STRUCTURE_NOT_APPROPRIATE {
            get {
                return ResourceManager.GetString("DATA_STRUCTURE_NOT_APPROPRIATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This service relies on the presence of a configuration for {0}.
        /// </summary>
        public static string DEPENDENT_CONFIGURATION_MISSING {
            get {
                return ResourceManager.GetString("DEPENDENT_CONFIGURATION_MISSING", resourceCulture);
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
        ///   Looks up a localized string similar to Device name changed - an override is required.
        /// </summary>
        public static string DEVICE_NAME_CONFIGURATION_CHANGED {
            get {
                return ResourceManager.GetString("DEVICE_NAME_CONFIGURATION_CHANGED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find appropriate script for {0}.
        /// </summary>
        public static string DIALECT_NOT_FOUND {
            get {
                return ResourceManager.GetString("DIALECT_NOT_FOUND", resourceCulture);
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
        ///   Looks up a localized string similar to Object {0} already exists.
        /// </summary>
        public static string DUPLICATE_OBJECT {
            get {
                return ResourceManager.GetString("DUPLICATE_OBJECT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error providing fault message.
        /// </summary>
        public static string ERROR_PROVIDING_FAULT {
            get {
                return ResourceManager.GetString("ERROR_PROVIDING_FAULT", resourceCulture);
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
        ///   Looks up a localized string similar to File is encrypted (invalid decryption information present).
        /// </summary>
        public static string FILE_ENCRYPTED {
            get {
                return ResourceManager.GetString("FILE_ENCRYPTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid passphrase to decrypt the file.
        /// </summary>
        public static string FILE_ENCRYPTED_INVALID_PASSPHRASE {
            get {
                return ResourceManager.GetString("FILE_ENCRYPTED_INVALID_PASSPHRASE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only exact equal filters are supported on encrypted fields.
        /// </summary>
        public static string FILTER_ENCRYPTED_FIELD {
            get {
                return ResourceManager.GetString("FILTER_ENCRYPTED_FIELD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filtering on encrypted fields when RANDOM method is configured is not supported.
        /// </summary>
        public static string FILTER_RANDOM_ENCRYPTION_NOT_SUPPORTED {
            get {
                return ResourceManager.GetString("FILTER_RANDOM_ENCRYPTION_NOT_SUPPORTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Header {0} is not permitted for this HTTP method.
        /// </summary>
        public static string FORBIDDEN_HEADER {
            get {
                return ResourceManager.GetString("FORBIDDEN_HEADER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General error querying data from underlying data source.
        /// </summary>
        public static string GENERAL_QUERY_ERROR {
            get {
                return ResourceManager.GetString("GENERAL_QUERY_ERROR", resourceCulture);
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
        ///   Looks up a localized string similar to Invalid file format encountered.
        /// </summary>
        public static string INVALID_FILE_FORMAT {
            get {
                return ResourceManager.GetString("INVALID_FILE_FORMAT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data {0} was not in the expected format {1}.
        /// </summary>
        public static string INVALID_FORMAT {
            get {
                return ResourceManager.GetString("INVALID_FORMAT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error executing JavaScript rule/trigger {0}.
        /// </summary>
        public static string JS_BUSINESS_RULE_ERROR {
            get {
                return ResourceManager.GetString("JS_BUSINESS_RULE_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This instance is configured for online use only - no local methods are supported ({0}).
        /// </summary>
        public static string LOCAL_SERVICE_NOT_SUPPORTED {
            get {
                return ResourceManager.GetString("LOCAL_SERVICE_NOT_SUPPORTED", resourceCulture);
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
        ///   Looks up a localized string similar to Failure mapping expression to/from underlying domain models. Ensure the property paths are correct.
        /// </summary>
        public static string MAP_EXPRESSION_NOT_POSSIBLE {
            get {
                return ResourceManager.GetString("MAP_EXPRESSION_NOT_POSSIBLE", resourceCulture);
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
        ///   Looks up a localized string similar to Required method {0} not found.
        /// </summary>
        public static string METHOD_NOT_FOUND {
            get {
                return ResourceManager.GetString("METHOD_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entry point named {0} cannot be found.
        /// </summary>
        public static string MISSING_ENTRY_POINT {
            get {
                return ResourceManager.GetString("MISSING_ENTRY_POINT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dependent background job {0} is not registered.
        /// </summary>
        public static string MISSING_JOB {
            get {
                return ResourceManager.GetString("MISSING_JOB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required field {0} not supplied.
        /// </summary>
        public static string MISSING_VALUE {
            get {
                return ResourceManager.GetString("MISSING_VALUE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple calls to {0} are not supported.
        /// </summary>
        public static string MULTIPLE_CALLS_NOT_ALLOWED {
            get {
                return ResourceManager.GetString("MULTIPLE_CALLS_NOT_ALLOWED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object {0} cannot be resolved because it does not define a key.
        /// </summary>
        public static string NO_DATA_KEY_DEFINED {
            get {
                return ResourceManager.GetString("NO_DATA_KEY_DEFINED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Security reset is not available on this object.
        /// </summary>
        public static string NO_RESET_POSSIBLE {
            get {
                return ResourceManager.GetString("NO_RESET_POSSIBLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This class has not been initialized.
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
        ///   Looks up a localized string similar to Object {0} not found.
        /// </summary>
        public static string OBJECT_NOT_FOUND {
            get {
                return ResourceManager.GetString("OBJECT_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This object is readonly and cannot be modified or saved.
        /// </summary>
        public static string OBJECT_READONLY {
            get {
                return ResourceManager.GetString("OBJECT_READONLY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation requires a filter (global queries are not permitted).
        /// </summary>
        public static string OPERATION_REQUIRES_QUERY_PARAMETER {
            get {
                return ResourceManager.GetString("OPERATION_REQUIRES_QUERY_PARAMETER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination peer and this node are not connected.
        /// </summary>
        public static string PEER_NOT_CONNECTED {
            get {
                return ResourceManager.GetString("PEER_NOT_CONNECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination peer is unknown.
        /// </summary>
        public static string PEER_UNKNOWN {
            get {
                return ResourceManager.GetString("PEER_UNKNOWN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided principal is not valid in this context.
        /// </summary>
        public static string PRINCIPAL_NOT_APPROPRIATE {
            get {
                return ResourceManager.GetString("PRINCIPAL_NOT_APPROPRIATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Privacy control violation has been detected.
        /// </summary>
        public static string PRIVACY_VIOLATION_DETECTED {
            get {
                return ResourceManager.GetString("PRIVACY_VIOLATION_DETECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error reading resource {0}.
        /// </summary>
        public static string READ_ERROR {
            get {
                return ResourceManager.GetString("READ_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reference to resource {0} could not be resolved.
        /// </summary>
        public static string REFERENCE_NOT_FOUND {
            get {
                return ResourceManager.GetString("REFERENCE_NOT_FOUND", resourceCulture);
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
        ///   Looks up a localized string similar to Header {0} is required for this HTTP method.
        /// </summary>
        public static string REQUIRED_HEADER {
            get {
                return ResourceManager.GetString("REQUIRED_HEADER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rest client configuration for {0} not found.
        /// </summary>
        public static string REST_CLIENT_NOT_FOUND {
            get {
                return ResourceManager.GetString("REST_CLIENT_NOT_FOUND", resourceCulture);
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
        ///   Looks up a localized string similar to Required service {0} is not found.
        /// </summary>
        public static string SERVICE_NOT_FOUND {
            get {
                return ResourceManager.GetString("SERVICE_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Digital signature failed validation.
        /// </summary>
        public static string SIGNATURE_VALIDATION_ERROR {
            get {
                return ResourceManager.GetString("SIGNATURE_VALIDATION_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Applet solutions are not permitted.
        /// </summary>
        public static string SOLUTIONS_NOT_SUPPORTED {
            get {
                return ResourceManager.GetString("SOLUTIONS_NOT_SUPPORTED", resourceCulture);
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
        ///   Looks up a localized string similar to Reference term {0}#{1} not found.
        /// </summary>
        public static string TERM_NOT_FOUND {
            get {
                return ResourceManager.GetString("TERM_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Referenced type {0} not available.
        /// </summary>
        public static string TYPE_NOT_FOUND {
            get {
                return ResourceManager.GetString("TYPE_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine appropriate export policy.
        /// </summary>
        public static string UNABLE_TO_DETERMINE_EXPORT_POLICY {
            get {
                return ResourceManager.GetString("UNABLE_TO_DETERMINE_EXPORT_POLICY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This function requires the upstream to be configured.
        /// </summary>
        public static string UPSTREAM_NOT_CONFIGURED {
            get {
                return ResourceManager.GetString("UPSTREAM_NOT_CONFIGURED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This service should no longer be used - please use alternate {0}.
        /// </summary>
        public static string USE_ALTERNATE_SERVICE {
            get {
                return ResourceManager.GetString("USE_ALTERNATE_SERVICE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable {0} is not declared.
        /// </summary>
        public static string VARIABLE_NOT_FOUND {
            get {
                return ResourceManager.GetString("VARIABLE_NOT_FOUND", resourceCulture);
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
