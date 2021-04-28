using System;
using System.Collections.Generic;
using System.Text;

namespace SanteDB.Core.i18n
{
    /// <summary>
    /// Localization extensions
    /// </summary>
    public static class LocalizationExtensions
    {


        /// <summary>
        /// Wrapper around String.Format that allows localization strings to be called via resource name and .WithParamters
        /// </summary>
        /// <example>
        /// ErrorMessages.ERR_USR_CREATE_GEN.Format(userName);
        /// </example>
        public static String Format(this String me, params object[] objects)
        {
            return String.Format(me, objects);
        }
    }
}
