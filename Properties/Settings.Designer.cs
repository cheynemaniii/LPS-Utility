﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LPS_Utility.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.kitco.com/")]
        public string SilverWebsite {
            get {
                return ((string)(this["SilverWebsite"]));
            }
            set {
                this["SilverWebsite"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//*[@id=\"__next\"]/main/div/div[1]/div[3]/div/div[2]/div[1]/div/span[1]")]
        public string SilverPriceNode {
            get {
                return ((string)(this["SilverPriceNode"]));
            }
            set {
                this["SilverPriceNode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.kitco.com/")]
        public string GoldWebsite {
            get {
                return ((string)(this["GoldWebsite"]));
            }
            set {
                this["GoldWebsite"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//*[@id=\"__next\"]/main/div/div[1]/div[2]/div/div[2]/div[2]/div[1]/div/span[1]")]
        public string GoldPriceNode {
            get {
                return ((string)(this["GoldPriceNode"]));
            }
            set {
                this["GoldPriceNode"] = value;
            }
        }
    }
}
