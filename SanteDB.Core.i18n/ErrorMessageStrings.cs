﻿/*
 * Copyright (C) 2021 - 2023, SanteSuite Inc. and the SanteSuite Contributors (See NOTICE.md for full copyright notices)
 * Copyright (C) 2019 - 2021, Fyfe Software Inc. and the SanteSuite Contributors
 * Portions Copyright (C) 2015-2018 Mohawk College of Applied Arts and Technology
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you
 * may not use this file except in compliance with the License. You may
 * obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 *
 * User: fyfej
 * Date: 2023-5-19
 */
namespace SanteDB.Core.i18n
{
    /// <summary>
    /// Error message strings
    /// </summary>
    /// <remarks>
    /// <para>It is recommended that these strings be used in conjuction with ILocalizationService. This allows implementers of SanteDB software
    /// to customize the error messages thrown from the server via applets. </para>
    /// <para>You should use the ILocalization method when: </para>
    /// <list type="bullet">
    ///  <item>The class is a service operating in the ApplicationServiceContext</item>
    ///  <item>The class is passing a REST based exception</item>
    ///  <item>The class is otherwise throwing end-user facing exceptions</item>
    /// </list>
    /// <para>
    /// If the class is merely throwing internal, or developer exceptions or if it is a standalone class you should use the <see cref="ErrorMessages"/> constants
    /// </para>
    /// </remarks>
    public static class ErrorMessageStrings
    {
        /// <summary>
        /// Password history violation
        /// </summary>
        public const string USR_PWD_HISTORY = "error.security.user.password.history";

        /// <summary>
        /// General error setting password
        /// </summary>
        public const string USR_PWD_GEN_ERR = "error.security.user.password.general";

        /// <summary>
        /// Password does not meet complexity
        /// </summary>
        public const string USR_PWD_COMPLEXITY = "error.security.user.password.complexity";

        /// <summary>
        /// Invalid user
        /// </summary>
        public const string USR_INVALID = "error.security.user.invalid";

        /// <summary>
        /// General error updating user
        /// </summary>
        public const string USR_GEN_ERR = "error.security.user.general";

        /// <summary>
        /// Error deleting user
        /// </summary>
        public const string USR_DEL_ERR = "error.security.user.delete";

        /// <summary>
        /// Error creating user
        /// </summary>
        public const string USR_CREATE_GEN = "error.security.user.create";

        /// <summary>
        /// General error reading or setting claim
        /// </summary>
        public const string USER_CLAIM_GEN_ERR = "error.security.claim.general";

        /// <summary>
        /// Error setting the secret for a device or application
        /// </summary>
        public const string UPDATE_SECRET = "error.security.deviceOrApplication.secret";

        /// <summary>
        /// The function is not implemented yet
        /// </summary>
        public const string TODO = "error.notImplemented";

        /// <summary>
        /// General error setting the lockout
        /// </summary>
        public const string SET_LOCKOUT = "error.security.lockout.general";

        /// <summary>
        /// Session token is not valid (time constraint)
        /// </summary>
        public const string SESSION_TOKEN_INVALID = "error.security.token.invalid";

        /// <summary>
        /// Session token has been tampered
        /// </summary>
        public const string SESSION_TAMPER = "error.security.token.tamper";

        /// <summary>
        /// Session refresh token is expired
        /// </summary>
        public const string SESSION_REFRESH_EXPIRE = "error.security.token.refreshExpiry";

        /// <summary>
        /// Attempted override without sufficient data
        /// </summary>
        public const string SESSION_OVERRIDE_WITH_INSUFFICIENT_DATA = "error.security.token.overrideConstraint";

        /// <summary>
        /// Session token is not yet valid
        /// </summary>
        public const string SESSION_NOT_VALID = "error.security.session.notValid";

        /// <summary>
        /// Session requires a claims principal to proceed
        /// </summary>
        public const string SESSION_NOT_CLAIMS_PRINCIPAL = "error.security.session.claimsPrincipal";

        /// <summary>
        /// Session creation attempted on an unauthenticated principal
        /// </summary>
        public const string SESSION_NOT_AUTH_PRINCIPAL = "error.security.session.notAuthorized";

        /// <summary>
        /// Session has no application security information
        /// </summary>
        public const string SESSION_NO_APPLICATION_ID = "error.security.session.noApplication";

        /// <summary>
        /// Session is missing identity data
        /// </summary>
        public const string SESSION_MISSING_IDENTITY_DATA = "error.security.session.identityMissing";

        /// <summary>
        /// General error establishing session
        /// </summary>
        public const string SESSION_GEN_ERR = "error.security.session.general";

        /// <summary>
        /// Session is expired
        /// </summary>
        public const string SESSION_EXPIRE = "error.security.session.expired";

        /// <summary>
        /// Session was abandoned
        /// </summary>
        public const string SESSION_ABANDON = "error.security.session.abandoned";

        /// <summary>
        /// Sequence contains no elements
        /// </summary>
        public const string SEQUENCE_NO_ELEMENTS = "error.data.sequence.noElements";

        /// <summary>
        /// Sequence has more than one element
        /// </summary>
        public const string SEQUENCE_MORE_THAN_ONE = "error.data.sequence.moreThanOne";

        /// <summary>
        /// General error creating a role
        /// </summary>
        public const string SEC_ROL_GEN = "error.security.role.general";

        /// <summary>
        /// General error assigning role {role} to {user}
        /// </summary>
        public const string SEC_ROL_ASSIGN = "error.security.user.roleAssign";

        /// <summary>
        /// Cannot establish provenance with an unknown identity
        /// </summary>
        public const string SEC_PROVENANCE_UNK_ID = "error.security.provenance.identityUnknown";

        /// <summary>
        /// General error establishing provenance data
        /// </summary>
        public const string SEC_PROVENANCE_GEN_ERR = "error.security.provenance.general";

        /// <summary>
        /// General error interacting with policy layer
        /// </summary>
        public const string SEC_POL_GEN = "error.security.policy.general";

        /// <summary>
        /// General error assigning policy to {object}
        /// </summary>
        public const string SEC_POL_ASSIGN = "error.security.policy.assign";

        /// <summary>
        /// Policies cannot be assigned with this object type
        /// </summary>
        public const string SEC_POL_NOT_SUPPORTED = "error.security.policy.notSupported";

        /// <summary>
        /// Error assigning roles {role} to/from {user}
        /// </summary>
        public const string ROL_ASSOC = "error.security.user.roleAssign";

        /// <summary>
        /// Error querying for roles
        /// </summary>
        public const string ROL_QUERY = "error.security.role.query";

        /// <summary>
        /// General error creating role
        /// </summary>
        public const string ROL_CREATE_GEN = "error.security.role.general";

        /// <summary>
        /// Related object not found
        /// </summary>
        public const string RELATED_OBJECT_NOT_FOUND = "error.data.related.notFound";

        /// <summary>
        /// Operation is not permitted
        /// </summary>
        public const string NOT_PERMITTED = "error.general.notAllowed";

        /// <summary>
        /// {type} with ID {id} was not found
        /// </summary>
        public const string NOT_FOUND = "error.data.notFound";

        /// <summary>
        /// Attempt was made to update an object without an identifier
        /// </summary>
        public const string NON_IDENTITY_UPDATE = "error.data.nonIdentityUpdate";

        /// <summary>
        /// Service is missing
        /// </summary>
        public const string MISSING_SERVICE = "error.general.serviceMissing";

        /// <summary>
        /// Required argument missing
        /// </summary>
        public const string MISSING_ARGUMENT = "error.general.missingArgument";

        /// <summary>
        /// Object is not in a state which permits this operation
        /// </summary>
        public const string INVALID_STATE = "error.general.invalidState";

        /// <summary>
        /// The device {key} doesn't exist
        /// </summary>
        public const string FETCH_DEVICE_KEY = "error.security.device.notExist";

        /// <summary>
        /// The application {key} doesn't exist
        /// </summary>
        public const string FETCH_APPLICATION_KEY = "error.security.application.notExist";

        /// <summary>
        /// The application {name} doesn't exist
        /// </summary>
        public const string FETCH_APPLICATION = "error.security.application.notExistName";

        /// <summary>
        /// Elevated sessions cannot be extended
        /// </summary>
        public const string ELEVATED_SESSION_NO_EXTENSION = "error.security.session.elevatedExtension";

        /// <summary>
        /// General error deleting device
        /// </summary>
        public const string DEV_DELETE_ERROR = "error.security.device.delete";

        /// <summary>
        /// Unspecified database error
        /// </summary>
        public const string DATA_GENERAL = "error.data.general";

        /// <summary>
        /// User requires MFA authentication
        /// </summary>
        public const string AUTH_USR_TFA_REQ = "error.security.user.tfaRequired";

        /// <summary>
        /// User account is locked until {time}
        /// </summary>
        public const string AUTH_USR_LOCKED = "error.security.user.auth.locked";

        /// <summary>
        /// Invalid username or password
        /// </summary>
        public const string AUTH_USR_INVALID = "error.security.user.auth.invalid";

        /// <summary>
        /// Reauthorization of this principal is not permitted
        /// </summary>
        public const string AUTH_USR_REAUTH_NOT_ALLOWED = "error.security.user.auth.reauthNotAllowed";

        /// <summary>
        /// General error authenticating user
        /// </summary>
        public const string AUTH_USR_GENERAL = "error.security.user.auth.general";

        /// <summary>
        /// Device account locked until {time}
        /// </summary>
        public const string AUTH_DEV_LOCKED = "error.security.device.auth.locked";

        /// <summary>
        /// Only local devices can be authenticated with this provider
        /// </summary>
        public const string AUTH_DEV_LOCAL_ONLY_SUPPORTED = "error.security.device.auth.localOnly";

        /// <summary>
        /// Invalid device identifier or secret
        /// </summary>
        public const string AUTH_DEV_INVALID = "error.security.device.auth.invalid";

        /// <summary>
        /// General error authenticating device
        /// </summary>
        public const string AUTH_DEV_GENERAL = "error.security.device.auth.general";

        /// <summary>
        /// Error registering device {name}
        /// </summary>
        public const string AUTH_DEV_CREATE = "error.security.device.create.general";

        /// <summary>
        /// Authentication was cancelled
        /// </summary>
        public const string AUTH_CANCELLED = "error.security.auth.cancelled";

        /// <summary>
        /// Application is locked until {time}
        /// </summary>
        public const string AUTH_APP_LOCKED = "error.security.application.auth.locked";

        /// <summary>
        /// Invalid application id or secret
        /// </summary>
        public const string AUTH_APP_INVALID = "error.security.application.auth.invalid";

        /// <summary>
        /// General error authenticating application
        /// </summary>
        public const string AUTH_APP_GENERAL = "error.security.application.auth.general";

        /// <summary>
        /// Error creating device credential {name}
        /// </summary>
        public const string AUTH_APP_CREATE = "error.security.application.create.general";

        /// <summary>
        /// Argument was out of range
        /// </summary>
        public const string ARGUMENT_RANGE = "error.general.argument.range";

        /// <summary>
        /// Argument was null
        /// </summary>
        public const string ARGUMENT_NULL = "error.general.argument.null";

        /// <summary>
        /// General error updating application {name}
        /// </summary>
        public const string APP_UPDATE_ERROR = "error.security.application.update.general";

        /// <summary>
        /// General error deleting application {name}
        /// </summary>
        public const string APP_DELETE_ERROR = "error.security.application.delete.general";

        /// <summary>
        /// Invalid expression type provided. Expected {expected} but got {actual}
        /// </summary>
        public const string INVALID_EXPRESSION_TYPE = "error.general.expression.type";

        /// <summary>
        /// Expression already has a where clause
        /// </summary>
        public const string ALREADY_HAS_WHERE = "error.data.alreadyHasWhere";

        /// <summary>
        /// String Like: Session audience has changed on refresh - not permitted!
        /// </summary>
        public const string SESSION_AUDIENCE_CHANGED = "error.security.session.refresh.audience";

        /// <summary>
        /// Session identity is invalid
        /// </summary>
        public const string SESSION_IDENTITY_INVALID = "error.security.session.identity.invalid";

        /// <summary>
        /// Session identity is locked
        /// </summary>
        public const string SESSION_IDENTITY_LOCKED = "error.security.session.identity.locked";

        /// <summary>
        /// Delete mode / method {mode} is not supported
        /// </summary>
        public const string DATA_DELETE_MODE_SUPPORT = "error.data.delete.modeNotSupported";

        /// <summary>
        /// Circular dependency
        /// </summary>
        public const string DATA_CIRCULAR_DEPENDENCY = "error.data.resolve.circularDependency";

        /// <summary>
        /// String like: Error ensuring dependent value {data} exists 
        /// </summary>
        public const string DATA_DEPENDENT_ENSURE_ERROR = "error.data.exists.error";

        /// <summary>
        /// The key on key property {keyProperty} does not match the data on data property {dataProperty}
        /// </summary>
        public const string DATA_KEY_PROPERTY_DISAGREEMENT = "error.data.keyDataDisagreement";

        /// <summary>
        /// The function {name} is obsolete - please consult the latest developer documentation
        /// </summary>
        public const string OBSOLETE_FUNCTION = "error.obsolete";

        /// <summary>
        /// General error with security challenge
        /// </summary>
        public const string USR_CHL_GEN_ERR = "error.security.user.challenge.general";

        /// <summary>
        /// String like Challenge response cannot be the same as previous
        /// </summary>
        public const string USR_CHL_DUP_RSP = "error.security.user.challenge.duplicate";

        /// <summary>
        /// String like: Certificate time is not valid (check not before and not after data)
        /// </summary>
        public const string AUTH_CERT_NOT_BEFORE_AFTER = "error.security.cert.auth.nbfnaf";

        /// <summary>
        /// String like: General error creating authentication certificate 
        /// </summary>
        public const string AUTH_CERT_CREATE_GEN = "error.security.cert.auth.create.gen";

        /// <summary>
        /// String like: The certificate {x5a} has already been associated with another identity
        /// </summary>
        public const string AUTH_CERT_ALREADY_ASSIGNED = "error.security.cert.auth.duplicate";

        /// <summary>
        /// String like: Two Factor Authentication is not supported with certificate authentication
        /// </summary>
        public const string AUTH_CERT_TFA_INVALID = "error.security.cert.auth.tfa";

        /// <summary>
        /// String like: General error performing certificate authentication
        /// </summary>
        public const string AUTH_CERT_GENERAL = "error.security.cert.auth.gen";

        /// <summary>
        /// String like: This identity or certificate is not mapped for authentication between {identity} and {thumbprint}
        /// </summary>
        public const string AUTH_NO_CERT_MAP = "error.security.cert.auth.nomap";

        /// <summary>
        /// String like: The specified data has failed digital signature validation
        /// </summary>
        public const string SIGNATURE_INVALID = "error.security.signatureFail";

        /// <summary>
        /// String like: The extension type {extensionType} is invalid for the extension {extension}
        /// </summary>
        public const string EXTENSION_INVALID_TYPE = "error.model.extension.type";

        /// <summary>
        /// String like: Error modifying claims on application
        /// </summary>
        public const string APP_CLAIM_GEN_ERR = "error.security.application.claim";

        /// <summary>
        /// String like: Error modifying claims on device
        /// </summary>
        public const string DEV_CLAIM_GEN_ERR = "error.security.device.claim";

        /// <summary>
        /// String like: Error reading {data} from upstream
        /// </summary>
        public const string UPSTREAM_READ_ERR = "error.upstream.read";

        /// <summary>
        /// String like: Error sending {data} to upstream
        /// </summary>
        public const string UPSTREAM_WRITE_ERR = "error.upstream.write";

        /// <summary>
        /// String like: General error interacting with upstream
        /// </summary>
        public const string UPSTREAM_GEN_ERR = "error.upstream.gen";

        /// <summary>
        /// String like: Error joining upstream domain
        /// </summary>
        public const string UPSTREAM_JOIN_ERR = "error.upstream.join";

        /// <summary>
        /// String like: Error authenticating the device against the upstream
        /// </summary>
        public const string UPSTREAM_AUTH_ERR = "error.upstream.auth";

        /// <summary>
        /// String like: Remote server version is incompatible with this interface (remote: {remote})
        /// </summary>
        public const string UPSTREAM_VERSION_MISMATCH = "error.upstream.version";

        /// <summary>
        /// String like: Device {device} has already been registered
        /// </summary>
        public const string UPSTREAM_JOIN_DEVICE_DUPLICATE = "error.upstream.duplicate";

        /// <summary>
        /// String like: Upstream requires certificate authentication but this device cannot generate certificates
        /// </summary>
        public const string UPSTREAM_JOIN_CANNOT_GENERATE_CERTIFICATE = "error.upstream.certificate.csr";

        /// <summary>
        /// String like: Upstream approval of certificate request from this device has been witheld with status {status} (CA response: {message})
        /// </summary>
        public const string UPSTREAM_JOIN_CERTIFICATE_HOLD = "error.upstream.certificate.held";
        /// <summary>
        /// String like: The upstream cannot be the same as the client
        /// </summary>
        public const string UPSTREAM_CANNOT_JOIN_YOURSELF = "error.upstream.self";

        /// <summary>
        /// String like: Configured backup policy requires backups to have encryption
        /// </summary>
        public const string BACKUP_POLICY_REQUIRES_ENCRYPTION = "error.backup.policy.encryption";

        /// <summary>
        /// String like: General error working with backup system
        /// </summary>
        public const string BACKUP_GEN_ERR = "error.backup.gen";

        /// <summary>
        /// String like: Error restoring backup information
        /// </summary>
        public const string BACKUP_RESTORE_ERR = "error.backup.restore";

        /// <summary>
        /// String like: The foreign data map for {subsetName} could not be found
        /// </summary>
        public const string FOREIGN_MAP_NOT_FOUND = "error.foreign.map.notFound";

        /// <summary>
        /// String like: Error applying {name} to value
        /// </summary>
        public const string FOREIGN_DATA_TRANSFORM_ERROR = "error.foreign.transform";

        /// <summary>
        /// String like: Error applying transform at row {row}
        /// </summary>
        public const string FOREIGN_DATA_MAP_ERROR = "error.foreign.map";

        /// <summary>
        /// String like: Could not apply the map becuase the map is missing a target
        /// </summary>
        public const string FOREIGN_DATA_TRANSFORM_MISSING_TARGET = "error.foreign.map.target";

        /// <summary>
        /// String like: General error applying the mapping at {row} because of {ex}
        /// </summary>
        public const string FOREIGN_DATA_GEN_ERR = "error.foreign.map.gen";

        /// <summary>
        /// String like: The field {field} at row {row} is null or missing a value whenone is required
        /// </summary>
        public const string FOREIGN_DATA_MAP_REQUIRED_MISSING = "error.foreign.map.required";

        /// <summary>
        /// String like: {field} with value {value} could not be translated - check for missing mapping data (at row {row})
        /// </summary>
        public const string FOREIGN_DATA_TARGET_MISSING = "error.foreign.map.target.null";

        /// <summary>
        /// String like: {field} with value {value} could not be translated - check for missing mapping data (at row {row})
        /// </summary>
        public const string FOREIGN_DATA_TRANSFORM_MISSING = "error.foreign.map.transform.missing";

        /// <summary>
        /// String like: General error in foreign data stage manager
        /// </summary>
        public const string FOREIGN_DATA_MANAGE_ERROR = "error.foreign.manager.gen";

        /// <summary>
        /// String like: The staged foreign data is not in a valid state to perform this operation
        /// </summary>
        public const string FOREIGN_DATA_INVALID_STATE = "error.foreign.manager.state";

        /// <summary>
        /// String like: The foreign data map {map} which is referenced on this foreign data cannot be found
        /// </summary>
        public const string FOREIGN_DATA_MAP_NOT_FOUND = "error.foreign.manager.map.notfound";

        /// <summary>
        /// String like: The foreign data format {format} cannot be interpreted by this instance of SanteDB
        /// </summary>
        public const string FOREIGN_DATA_UNSUPPORTED_FORMAT = "error.foreign.manager.map.format";

        /// <summary>
        /// String like: General error in datamart manager
        /// </summary>
        public const string DATAMART_MANAGE_ERROR = "error.datamart.manager.gen";

        /// <summary>
        /// String like: Error while dropping data mart {id}
        /// </summary>
        public const string DATAMART_DROP_ERROR = "error.datamart.drop";

        /// <summary>
        /// String like: Error while creating data mart {id}
        /// </summary>
        public const string DATAMART_CREATE_ERROR = "error.datamart.create";

        /// <summary>
        /// String like: Error while refreshing data mart {id}
        /// </summary>
        public const string DATAMART_REFRESH_ERROR = "error.datamart.refresh";

        /// <summary>
        /// String like: Error while assigning job schedule for {job}
        /// </summary>
        public const string JOB_SCHEDULE_ASSIGN = "error.job.schedule.assign";

        /// <summary>
        /// String like: Error while querying job schedules
        /// </summary>
        public const string JOB_SCHEDULE_QUERY = "error.job.schedule.query";

        /// <summary>
        /// String like: Error while assigning job state
        /// </summary>
        public const string JOB_STATE_SET = "error.job.state.assign";

        /// <summary>
        /// String like: Error while querying job state
        /// </summary>
        public const string JOB_STATE_QUERY = "error.job.state.query";

        /// <summary>
        /// String like: Error executing BI metadata query
        /// </summary>
        public const string BI_QUERY_ERR = "error.bi.meta.query";

        /// <summary>
        /// String like: Error executing BI read for {id}
        /// </summary>
        public const string BI_READ_ERR = "error.bi.meta.read";

        /// <summary>
        /// String like: Error executing BI store for {id}
        /// </summary>
        public const string BI_STORE_ERR = "error.bi.meta.store";

        /// <summary>
        /// String like: Error storing match configuration {id}
        /// </summary>
        public const string MATCH_CONFIG_ERR = "error.match.config.store";

        /// <summary>
        /// String like: This operation requires an active connection to the central server
        /// </summary>
        public const string CONNECTION_REQUIRED = "error.connection.required";

        /// <summary>
        /// String like: General error querying signing certificates
        /// </summary>
        public const string SIG_CERT_GENERAL = "error.signing.cert.gen";

        /// <summary>
        /// String like: Error assigning signing certificate {subject} to {identity}
        /// </summary>
        public const string SIG_CERT_CREATE_GEN = "error.signing.cert.create";

        /// <summary>
        /// String like: Error removing signing certificate {subject} from {identity}
        /// </summary>
        public const string SIG_CERT_REMOVE_GEN = "error.signing.cert.remove";
    }
}