﻿#pragma checksum "C:\Users\adria\Desktop\TrabajoDSI\CityAssault\Garage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7C489F264FD5076C0F50A18F6CE76E96"
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
    partial class Garage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Value = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Garage_obj13_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGarage_Bindings
        {
            private global::CityAssault.VMTank dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj13;
            private global::Windows.UI.Xaml.Controls.Image obj14;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj14SourceDisabled = false;

            public Garage_obj13_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 131 && columnNumber == 36)
                {
                    isobj14SourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 13: // Garage.xaml line 130
                        this.obj13 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 14: // Garage.xaml line 131
                        this.obj14 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj13.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::CityAssault.VMTank) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IGarage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::CityAssault.VMTank)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::CityAssault.VMTank obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Imagen(obj.Imagen, phase);
                    }
                }
            }
            private void Update_Imagen(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Garage.xaml line 131
                    if (!isobj14SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj14, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Garage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGarage_Bindings
        {
            private global::CityAssault.Garage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ProgressBar obj4;
            private global::Windows.UI.Xaml.Controls.ProgressBar obj5;
            private global::Windows.UI.Xaml.Controls.ProgressBar obj6;
            private global::Windows.UI.Xaml.Controls.ProgressBar obj7;
            private global::Windows.UI.Xaml.Controls.ProgressBar obj8;
            private global::Windows.UI.Xaml.Controls.ListView obj11;
            private global::Windows.UI.Xaml.Controls.Image obj16;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4ValueDisabled = false;
            private static bool isobj5ValueDisabled = false;
            private static bool isobj6ValueDisabled = false;
            private static bool isobj7ValueDisabled = false;
            private static bool isobj8ValueDisabled = false;
            private static bool isobj11ItemsSourceDisabled = false;
            private static bool isobj16SourceDisabled = false;

            public Garage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 244 && columnNumber == 94)
                {
                    isobj4ValueDisabled = true;
                }
                else if (lineNumber == 245 && columnNumber == 94)
                {
                    isobj5ValueDisabled = true;
                }
                else if (lineNumber == 246 && columnNumber == 94)
                {
                    isobj6ValueDisabled = true;
                }
                else if (lineNumber == 247 && columnNumber == 94)
                {
                    isobj7ValueDisabled = true;
                }
                else if (lineNumber == 248 && columnNumber == 73)
                {
                    isobj8ValueDisabled = true;
                }
                else if (lineNumber == 120 && columnNumber == 75)
                {
                    isobj11ItemsSourceDisabled = true;
                }
                else if (lineNumber == 81 && columnNumber == 46)
                {
                    isobj16SourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Garage.xaml line 244
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
                        break;
                    case 5: // Garage.xaml line 245
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
                        break;
                    case 6: // Garage.xaml line 246
                        this.obj6 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
                        break;
                    case 7: // Garage.xaml line 247
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
                        break;
                    case 8: // Garage.xaml line 248
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
                        break;
                    case 11: // Garage.xaml line 120
                        this.obj11 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 16: // Garage.xaml line 81
                        this.obj16 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IGarage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::CityAssault.Garage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::CityAssault.Garage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_vit(obj.vit, phase);
                        this.Update_atk(obj.atk, phase);
                        this.Update_def(obj.def, phase);
                        this.Update_vel(obj.vel, phase);
                        this.Update_mov(obj.mov, phase);
                        this.Update_ListaTanques(obj.ListaTanques, phase);
                        this.Update_selectedTank(obj.selectedTank, phase);
                    }
                }
            }
            private void Update_vit(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Garage.xaml line 244
                    if (!isobj4ValueDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj4, obj);
                    }
                }
            }
            private void Update_atk(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Garage.xaml line 245
                    if (!isobj5ValueDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj5, obj);
                    }
                }
            }
            private void Update_def(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Garage.xaml line 246
                    if (!isobj6ValueDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj6, obj);
                    }
                }
            }
            private void Update_vel(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Garage.xaml line 247
                    if (!isobj7ValueDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj7, obj);
                    }
                }
            }
            private void Update_mov(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Garage.xaml line 248
                    if (!isobj8ValueDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj8, obj);
                    }
                }
            }
            private void Update_ListaTanques(global::System.Collections.ObjectModel.ObservableCollection<global::CityAssault.VMTank> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Garage.xaml line 120
                    if (!isobj11ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj11, obj, null);
                    }
                }
            }
            private void Update_selectedTank(global::CityAssault.VMTank obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_selectedTank_Imagen(obj.Imagen, phase);
                    }
                }
            }
            private void Update_selectedTank_Imagen(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Garage.xaml line 81
                    if (!isobj16SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj16, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Garage.xaml line 28
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.goBack;
                }
                break;
            case 3: // Garage.xaml line 179
                {
                    this.SaveButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SaveButton).Click += this.SaveButton_Click;
                }
                break;
            case 4: // Garage.xaml line 244
                {
                    this.VitBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 5: // Garage.xaml line 245
                {
                    this.AtkBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 6: // Garage.xaml line 246
                {
                    this.DefBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 7: // Garage.xaml line 247
                {
                    this.VelBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 8: // Garage.xaml line 248
                {
                    this.MovBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 9: // Garage.xaml line 92
                {
                    this.ArrowLeft = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ArrowLeft).Click += this.ArrowLeft_Click;
                }
                break;
            case 10: // Garage.xaml line 101
                {
                    this.ArrowRight = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ArrowRight).Click += this.ArrowRight_Click;
                }
                break;
            case 11: // Garage.xaml line 120
                {
                    this.SavedList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.SavedList).ItemClick += this.SavedList_ItemClick;
                }
                break;
            case 15: // Garage.xaml line 79
                {
                    this.Habilidad = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Garage.xaml line 81
                {
                    this.TanqueImagen = (global::Windows.UI.Xaml.Controls.Image)(target);
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
            switch(connectionId)
            {
            case 1: // Garage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Garage_obj1_Bindings bindings = new Garage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 13: // Garage.xaml line 130
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element13 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Garage_obj13_Bindings bindings = new Garage_obj13_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element13.DataContext);
                    element13.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element13, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element13, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

