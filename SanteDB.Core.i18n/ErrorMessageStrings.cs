using System;
using System.Collections.Generic;
using System.Text;

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
        /// General error creating a policy
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
        /// Error un-assigning role {role} from {user}
        /// </summary>
        public const string ROL_UNASSOC = "error.security.user.roleUnAssign";

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
    }
}