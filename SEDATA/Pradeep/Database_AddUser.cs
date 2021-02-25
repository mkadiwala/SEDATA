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

namespace SEDATA.Pradeep
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Database_AddUser recording.
    /// </summary>
    [TestModule("339ea777-8700-4650-8f5d-806e0fbcea31", ModuleType.Recording, 1)]
    public partial class Database_AddUser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::SEDATA.SEDATARepository repository.
        /// </summary>
        public static global::SEDATA.SEDATARepository repo = global::SEDATA.SEDATARepository.Instance;

        static Database_AddUser instance = new Database_AddUser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Database_AddUser()
        {
            FirstName = "Mubin";
            LastName = "Kad";
            Age = "35";
            Gender = "Male";
            Category = "Testing";
            NewAge = "-1";
            locWelcome = "-1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Database_AddUser Instance
        {
            get { return instance; }
        }

#region Variables

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("90ad4052-85fc-4d7b-806e-8ad09df93758")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("df5e134a-5d05-473f-99c9-fb664edec9bc")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        string _NewAge;

        /// <summary>
        /// Gets or sets the value of variable NewAge.
        /// </summary>
        [TestVariable("1ad819c4-1bdf-4c0a-a32e-7080283555a3")]
        public string NewAge
        {
            get { return _NewAge; }
            set { _NewAge = value; }
        }

        string _locWelcome;

        /// <summary>
        /// Gets or sets the value of variable locWelcome.
        /// </summary>
        [TestVariable("d5366653-3bb0-43f7-8e4c-e5ad420ecef8")]
        public string locWelcome
        {
            get { return _locWelcome; }
            set { _locWelcome = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Category.
        /// </summary>
        [TestVariable("691ef636-78b0-40f6-966b-62c2d117107f")]
        public string Category
        {
            get { return repo.Category; }
            set { repo.Category = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Gender.
        /// </summary>
        [TestVariable("1d21cccd-9e7f-4de7-aab4-af557d46b22f")]
        public string Gender
        {
            get { return repo.Gender; }
            set { repo.Gender = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Age.
        /// </summary>
        [TestVariable("03dcb3a4-c1f9-4159-8128-62beecbc76df")]
        public string Age
        {
            get { return repo.age; }
            set { repo.age = value; }
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'Mubin' on item 'RxMainFrame.RxTabStandard.Textbox.FirstName'.", repo.RxMainFrame.RxTabStandard.Textbox.FirstNameInfo, new RecordItemIndex(0));
            repo.RxMainFrame.RxTabStandard.Textbox.FirstName.Element.SetAttributeValue("Text", "Mubin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'Kadiwala' on item 'RxMainFrame.RxTabStandard.Textbox.LastName'.", repo.RxMainFrame.RxTabStandard.Textbox.LastNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.RxTabStandard.Textbox.LastName.Element.SetAttributeValue("Text", "Kadiwala");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'RxMainFrame.RxTabStandard.Open'.", repo.RxMainFrame.RxTabStandard.OpenInfo, new RecordItemIndex(2));
            repo.RxMainFrame.RxTabStandard.Open.Press();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'List1000.Testing'.", repo.List1000.TestingInfo, new RecordItemIndex(3));
            repo.List1000.Testing.Select();
            Delay.Milliseconds(0);
            
            MySetValue(repo.RxMainFrame.RxTabStandard.Textbox.AgeInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'RxMainFrame.RxTabStandard.RdbMale'.", repo.RxMainFrame.RxTabStandard.RdbMaleInfo, new RecordItemIndex(5));
            repo.RxMainFrame.RxTabStandard.RdbMale.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Invoke_action_BtnAddPerson(repo.RxMainFrame.BtnAddPersonInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}