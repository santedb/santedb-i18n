/*
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
 * Date: 2023-3-10
 */
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
        /// String like: Welcome to the realm {realm}
        /// </summary>
        public const string JOIN_REALM_SUCCESS = "ui.config.realm.success";

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
