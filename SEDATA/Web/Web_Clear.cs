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

namespace SEDATA.Web
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Web_Clear recording.
    /// </summary>
    [TestModule("797c06a1-43e2-4d4b-b3ce-7a611e139a44", ModuleType.Recording, 1)]
    public partial class Web_Clear : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SEDATA.SEDATARepository repository.
        /// </summary>
        public static global::SEDATA.SEDATARepository repo = global::SEDATA.SEDATARepository.Instance;

        static Web_Clear instance = new Web_Clear();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Web_Clear()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Web_Clear Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.Clear' at Center.", repo.RanorexVIPDatabaseTestWebApplicatio.ClearInfo, new RecordItemIndex(0));
            repo.RanorexVIPDatabaseTestWebApplicatio.Clear.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}