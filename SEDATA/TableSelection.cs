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
    ///The TableSelection recording.
    /// </summary>
    [TestModule("dadeabdf-f3ff-4447-ac06-87eb0099c148", ModuleType.Recording, 1)]
    public partial class TableSelection : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SEDATARepository repository.
        /// </summary>
        public static SEDATARepository repo = SEDATARepository.Instance;

        static TableSelection instance = new TableSelection();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TableSelection()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TableSelection Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Country.
        /// </summary>
        [TestVariable("c43f990b-289a-4284-af41-4c2cacc0364e")]
        public string Country
        {
            get { return repo.Country; }
            set { repo.Country = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GridSampleForm.CellDoe' at 20;15.", repo.GridSampleForm.CellDoeInfo, new RecordItemIndex(0));
            repo.GridSampleForm.CellDoe.Click("20;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Doe') on item 'GridSampleForm.CellDoe'.", repo.GridSampleForm.CellDoeInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.GridSampleForm.CellDoeInfo, "Text", "Doe");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.GridSampleForm.CellDoe, false, new RecordItemIndex(2));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GridSampleForm.SomeCheckBox' at 8;8.", repo.GridSampleForm.SomeCheckBoxInfo, new RecordItemIndex(3));
            //repo.GridSampleForm.SomeCheckBox.Click("8;8");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GridSampleForm.SomeCheckBox' at 7;6.", repo.GridSampleForm.SomeCheckBoxInfo, new RecordItemIndex(4));
            repo.GridSampleForm.SomeCheckBox.Click("7;6");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'true' on item 'GridSampleForm.SomeCheckBox'.", repo.GridSampleForm.SomeCheckBoxInfo, new RecordItemIndex(5));
            //repo.GridSampleForm.SomeCheckBox.Element.SetAttributeValue("Checked", "true");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
