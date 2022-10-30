using System;
using System.Collections.Generic;
using System.Text;

namespace SanteDB.Core.i18n
{
    /// <summary>
    /// User message status strings
    /// </summary>
    public static class UserMessageStrings
    {

        /// <summary>
        /// String like: Downloading {file}
        /// </summary>
        public const String DOWNLOADING = "ui.app.downloading";

        /// <summary>
        /// String like: Update {package} {version} installed
        /// </summary>
        public const String UPDATE_INSTALLED = "ui.app.updated";

        /// <summary>
        /// String like: Updates exist for {package}, would you like to install them?
        /// </summary>
        public const string UPDATE_INSTALL_CONFIRM = "ui.app.update.confirm";

        /// <summary>
        /// String like: Checking upstream for updates...
        /// </summary>
        public const string UPDATE_CHECK = "ui.app.update.checking";

        /// <summary>
        /// String like: Creating backup of system information
        /// </summary>
        public const string BACKUP_CREATE_PROGRESS = "ui.app.backup.create";

        /// <summary>
        /// String like: Restoring backup of system information
        /// </summary>
        public const string BACKUP_RESTORE_PROGRESS = "ui.app.backup.restore";

        /// <summary>
        /// String like: The certificate {cert} is not trusted. Do you want to trust it?
        /// </summary>
        public const string CONFIRM_CERTIFICATE_TRUST = "ui.app.certificate.trust";

        /// <summary>
        /// String like: {source} requires that the application be restarted. Do you want to restart the application?
        /// </summary>
        public const string CONFIRM_RESTART_REQUEST = "ui.app.restart.required";
    }
}
