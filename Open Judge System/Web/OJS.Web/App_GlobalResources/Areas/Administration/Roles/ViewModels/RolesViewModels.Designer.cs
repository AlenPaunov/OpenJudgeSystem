﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources.Areas.Administration.Roles.ViewModels {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class RolesViewModels {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RolesViewModels() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OJS.Web.App_GlobalResources.Areas.Administration.Roles.ViewModels.RolesViewModels" +
                            "", typeof(RolesViewModels).Assembly);
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
        ///   Looks up a localized string similar to E-mail.
        /// </summary>
        public static string Email {
            get {
                return ResourceManager.GetString("Email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Фамилия.
        /// </summary>
        public static string Last_name {
            get {
                return ResourceManager.GetString("Last_name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Име.
        /// </summary>
        public static string Name {
            get {
                return ResourceManager.GetString("Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Името е задължително!.
        /// </summary>
        public static string Name_required {
            get {
                return ResourceManager.GetString("Name_required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Няма.
        /// </summary>
        public static string Not_entered {
            get {
                return ResourceManager.GetString("Not_entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Потребителско име.
        /// </summary>
        public static string UserName {
            get {
                return ResourceManager.GetString("UserName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username is mandatory.
        /// </summary>
        public static string UserName_required {
            get {
                return ResourceManager.GetString("UserName_required", resourceCulture);
            }
        }
    }
}
