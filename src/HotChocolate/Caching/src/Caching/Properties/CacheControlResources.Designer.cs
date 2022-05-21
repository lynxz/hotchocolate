﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Caching.Properties {
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
    internal class CacheControlResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CacheControlResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HotChocolate.Caching.Properties.CacheControlResources", typeof(CacheControlResources).Assembly);
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
        ///   Looks up a localized string similar to The `@cacheControl` directive may be provided for individual fields or entire object, interface or union types to provide caching hints to the executor..
        /// </summary>
        internal static string CacheControlDirectiveType_Description {
            get {
                return ResourceManager.GetString("CacheControlDirectiveType_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If `true`, the field inherits the `maxAge` of its parent field..
        /// </summary>
        internal static string CacheControlDirectiveType_InheritMaxAge {
            get {
                return ResourceManager.GetString("CacheControlDirectiveType_InheritMaxAge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum amount of time this field&apos;s cached value is valid, in seconds..
        /// </summary>
        internal static string CacheControlDirectiveType_MaxAge {
            get {
                return ResourceManager.GetString("CacheControlDirectiveType_MaxAge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If `PRIVATE`, the field&apos;s value is specific to a single user. The default value is `PUBLIC`, which means the field&apos;s value is not tied to a single user..
        /// </summary>
        internal static string CacheControlDirectiveType_Scope {
            get {
                return ResourceManager.GetString("CacheControlDirectiveType_Scope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scope of a cache hint..
        /// </summary>
        internal static string CacheControlScopeType_Description {
            get {
                return ResourceManager.GetString("CacheControlScopeType_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value to cache is specific to a single user..
        /// </summary>
        internal static string CacheControlScopeType_Private {
            get {
                return ResourceManager.GetString("CacheControlScopeType_Private", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value to cache is not tied to a single user..
        /// </summary>
        internal static string CacheControlScopeType_Public {
            get {
                return ResourceManager.GetString("CacheControlScopeType_Public", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not specify `inheritMaxAge: true` and a value for `maxAge` for the @cacheControl directive on the field {0}..
        /// </summary>
        internal static string ErrorHelper_BothInheritMaxAgeAndMaxAgeSpecified {
            get {
                return ResourceManager.GetString("ErrorHelper_BothInheritMaxAgeAndMaxAgeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not specify `inheritMaxAge: true` for the @cacheControl directive on the type {0}..
        /// </summary>
        internal static string ErrorHelper_InheritMaxAgeCanNotBeOnType {
            get {
                return ResourceManager.GetString("ErrorHelper_InheritMaxAgeCanNotBeOnType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The `maxAge` value for the @cacheControl directive on the field {0} can not be negative..
        /// </summary>
        internal static string ErrorHelper_MaxAgeValueCanNotBeNegative {
            get {
                return ResourceManager.GetString("ErrorHelper_MaxAgeValueCanNotBeNegative", resourceCulture);
            }
        }
    }
}
