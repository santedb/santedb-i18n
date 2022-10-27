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
    }
}
