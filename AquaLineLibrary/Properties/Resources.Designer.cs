﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aqua.Library.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Aqua.Library.Properties.Resources", typeof(Resources).Assembly);
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
        
        internal static System.Drawing.Bitmap aquaImage {
            get {
                object obj = ResourceManager.GetObject("aquaImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dbo.BARCODEHIST.
        /// </summary>
        internal static string BarcodeCustomersHistoryTable {
            get {
                return ResourceManager.GetString("BarcodeCustomersHistoryTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dbo.BARCODECUST.
        /// </summary>
        internal static string BarcodeCustomersTable {
            get {
                return ResourceManager.GetString("BarcodeCustomersTable", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap BarcodeImg {
            get {
                object obj = ResourceManager.GetObject("BarcodeImg", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dbo.BARCODEOFFERS.
        /// </summary>
        internal static string BarcodeOffersTable {
            get {
                return ResourceManager.GetString("BarcodeOffersTable", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap CashImg {
            get {
                object obj = ResourceManager.GetObject("CashImg", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap ClockImg {
            get {
                object obj = ResourceManager.GetObject("ClockImg", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap CustomerImg {
            get {
                object obj = ResourceManager.GetObject("CustomerImg", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EliteUser.CUA.
        /// </summary>
        internal static string CustomersTable {
            get {
                return ResourceManager.GetString("CustomersTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EliteUser.TME.
        /// </summary>
        internal static string LicensePlatesTable {
            get {
                return ResourceManager.GetString("LicensePlatesTable", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap SaveImg {
            get {
                object obj = ResourceManager.GetObject("SaveImg", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
