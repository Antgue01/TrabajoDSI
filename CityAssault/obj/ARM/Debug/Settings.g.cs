﻿#pragma checksum "C:\Users\madar\Desktop\Uni\2º V\trabajos dsi\repositorio\TrabajoDSI\CityAssault\Settings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C670B2C1F5A4B8025F3B9721CD4C34F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CityAssault
{
    partial class Settings : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Settings.xaml line 29
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.goBack;
                }
                break;
            case 3: // Settings.xaml line 93
                {
                    this.Mute_Music = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.Mute_Music).Checked += this.Mute_Music_Checked;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.Mute_Music).Unchecked += this.Mute_Music_Unchecked;
                }
                break;
            case 4: // Settings.xaml line 117
                {
                    this.Mute_Effects = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.Mute_Effects).Unchecked += this.Mute_Effects_Unchecked;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.Mute_Effects).Checked += this.Mute_Effects_Checked;
                }
                break;
            case 5: // Settings.xaml line 173
                {
                    this.Joystick = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.Joystick).Checked += this.Joystick_Checked;
                }
                break;
            case 6: // Settings.xaml line 162
                {
                    this.Girscopio = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.Girscopio).Checked += this.Girscopio_Checked;
                }
                break;
            case 7: // Settings.xaml line 144
                {
                    this.Estereo = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.Estereo).Checked += this.Estereo_Checked;
                }
                break;
            case 8: // Settings.xaml line 135
                {
                    this.Mono = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.Mono).Checked += this.Mono_Checked;
                }
                break;
            case 9: // Settings.xaml line 114
                {
                    this.Effects_Slider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Effects_Slider).ValueChanged += this.Effects_Slider_ValueChanged;
                }
                break;
            case 10: // Settings.xaml line 90
                {
                    this.Music_Slider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.Music_Slider).ValueChanged += this.Music_Slider_ValueChanged;
                }
                break;
            case 11: // Settings.xaml line 46
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element11 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element11).SelectionChanged += this.ComboBox_SelectionChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

