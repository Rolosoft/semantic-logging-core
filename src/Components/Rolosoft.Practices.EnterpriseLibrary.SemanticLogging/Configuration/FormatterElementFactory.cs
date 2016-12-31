// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Rolosoft.Practices.EnterpriseLibrary.SemanticLogging.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Xml.Linq;
    using Formatters;
    using Properties;
    using Utility;

    /// <summary>
    /// Creates formatter instances from configuration.
    /// </summary>
    public static class FormatterElementFactory
    {
        internal static IEnumerable<Lazy<IFormatterElement>> FormatterElements { get; set; }

        /// <summary>
        /// Creates the specified formatter name.
        /// </summary>
        /// <param name="element">The configuration element.</param>
        /// <returns>The formatter instance.</returns>
        public static IEventTextFormatter Get(XElement element)
        {
            Guard.ArgumentNotNull(element, "element");

            // If we only have a single child (sources element), 
            // there are no formatters so return null 
            // Or we are in testing env and FormatterElements is null
            if (element.Elements().Count() <= 1 || FormatterElements == null)
            {
                return null;
            }

            var instance = FormatterElements.FirstOrDefault(f => f.Value.CanCreateFormatter(element));
            if (instance == null)
            {
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.FormatterElementNotResolvedError, element.Name.LocalName));
            }

            return instance.Value.CreateFormatter(element);
        }
    }
}
