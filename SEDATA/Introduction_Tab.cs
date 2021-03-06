﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SEDATA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Introduction_Tab recording.
    /// </summary>
    [TestModule("855b5286-732e-4b44-adde-dcc14817a432", ModuleType.Recording, 1)]
    public partial class Introduction_Tab : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SEDATARepository repository.
        /// </summary>
        public static SEDATARepository repo = SEDATARepository.Instance;

        static Introduction_Tab instance = new Introduction_Tab();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Introduction_Tab()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Introduction_Tab Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            // Test Introdution Tab
            Report.Log(ReportLevel.Info, "Section", "Test Introdution Tab", new RecordItemIndex(0));
            
            // Write Comments
            Report.Log(ReportLevel.Info, "Mouse", "Write Comments\r\nMouse Left Click item 'RxMainFrame.Introduction' at 35;8.", repo.RxMainFrame.IntroductionInfo, new RecordItemIndex(1));
            repo.RxMainFrame.Introduction.Click("35;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'RxMainFrame.Introduction'.", repo.RxMainFrame.IntroductionInfo, new RecordItemIndex(2));
            repo.RxMainFrame.Introduction.Select();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
