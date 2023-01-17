﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crowdin.Api.Tests.Core.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Projects_FileFormatSettings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Projects_FileFormatSettings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Crowdin.Api.Tests.Core.Resources.Projects_FileFormatSettings", typeof(Projects_FileFormatSettings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;format&quot;: &quot;properties&quot;,
        ///  &quot;settings&quot;: {
        ///    &quot;escapeQuotes&quot;: 1,
        ///    &quot;escapeSpecialCharacters&quot;: 1,
        ///    &quot;exportPattern&quot;: &quot;string&quot;
        ///  }
        ///}.
        /// </summary>
        internal static string AddProjectFileFormatSettings_Request {
            get {
                return ResourceManager.GetString("AddProjectFileFormatSettings_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: {
        ///    &quot;id&quot;: 44,
        ///    &quot;name&quot;: &quot;My Properties&quot;,
        ///    &quot;format&quot;: &quot;properties&quot;,
        ///    &quot;extensions&quot;: [],
        ///    &quot;settings&quot;: {
        ///      &quot;escapeQuotes&quot;: 1,
        ///      &quot;escapeSpecialCharacters&quot;: 1,
        ///      &quot;exportPattern&quot;: &quot;string&quot;
        ///    },
        ///    &quot;createdAt&quot;: &quot;2019-09-19T15:10:43+00:00&quot;,
        ///    &quot;updatedAt&quot;: &quot;2019-09-19T15:10:46+00:00&quot;
        ///  }
        ///}.
        /// </summary>
        internal static string AddProjectFileFormatSettings_Response {
            get {
                return ResourceManager.GetString("AddProjectFileFormatSettings_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: {
        ///    &quot;url&quot;: &quot;https://production-enterprise-importer.downloads.crowdin.com/992000002/2/14.xliff?response-content-disposition=attachment%3B%20filename%3D%22APP.xliff%22&amp;X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&amp;X-Amz-Algorithm=AWS4-HMAC-SHA256&amp;X-Amz-Credential=AKIAIGJKLQV66ZXPMMEA%2F20190920%2Fus-east-1%2Fs3%2Faws4_request&amp;X-Amz-Date=20190920T093121Z&amp;X-Amz-SignedHeaders=host&amp;X-Amz-Expires=3600&amp;X-Amz-Signature=439ebd69a1b7e4c23e6d17891a491c94f832e0c82e4692dedb35a6cd1e624b62&quot;,
        ///    &quot;expireIn&quot;: &quot;2019- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DownloadProjectFileFormatSettingsCustomSegmentation_Response {
            get {
                return ResourceManager.GetString("DownloadProjectFileFormatSettingsCustomSegmentation_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;path&quot;: &quot;/format&quot;,
        ///    &quot;op&quot;: &quot;replace&quot;,
        ///    &quot;value&quot;: &quot;properties&quot;
        ///  },
        ///  {
        ///    &quot;path&quot;: &quot;/settings&quot;,
        ///    &quot;op&quot;: &quot;replace&quot;,
        ///    &quot;value&quot;: {
        ///
        ///      &quot;escapeQuotes&quot;: 1,
        ///
        ///      &quot;escapeSpecialCharacters&quot;: 1
        ///    }
        ///  }
        ///].
        /// </summary>
        internal static string EditProjectFileFormatSettings_Request {
            get {
                return ResourceManager.GetString("EditProjectFileFormatSettings_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: {
        ///    &quot;id&quot;: 44,
        ///    &quot;name&quot;: &quot;My Properties&quot;,
        ///    &quot;format&quot;: &quot;properties&quot;,
        ///    &quot;extensions&quot;: [
        ///      &quot;docx&quot;,
        ///      &quot;odt&quot;,
        ///      &quot;xlsx&quot;,
        ///      &quot;pptx&quot;,
        ///      &quot;ods&quot;,
        ///      &quot;odg&quot;,
        ///      &quot;odp&quot;,
        ///      &quot;mif&quot;
        ///    ],
        ///    &quot;settings&quot;: {
        ///      &quot;escapeQuotes&quot;: 1,
        ///      &quot;escapeSpecialCharacters&quot;: 1,
        ///      &quot;exportPattern&quot;: &quot;string&quot;
        ///    },
        ///    &quot;createdAt&quot;: &quot;2019-09-19T15:10:43+00:00&quot;,
        ///    &quot;updatedAt&quot;: &quot;2019-09-19T15:10:46+00:00&quot;
        ///  }
        ///}.
        /// </summary>
        internal static string EditProjectFileFormatSettings_Response {
            get {
                return ResourceManager.GetString("EditProjectFileFormatSettings_Response", resourceCulture);
            }
        }
    }
}
