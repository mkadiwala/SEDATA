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
    ///The ImageTest recording.
    /// </summary>
    [TestModule("2e028181-e7be-4e53-97a9-e4b3cef1f3d2", ModuleType.Recording, 1)]
    public partial class ImageTest : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SEDATARepository repository.
        /// </summary>
        public static SEDATARepository repo = SEDATARepository.Instance;

        static ImageTest instance = new ImageTest();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ImageTest()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ImageTest Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Paint3D.ZoomInteractor' at 167;122.", repo.Paint3D.ZoomInteractorInfo, new RecordItemIndex(0));
            repo.Paint3D.ZoomInteractor.Click(new Location(ZoomInteractor_Screenshot1, "167;122", ZoomInteractor_Screenshot1_Options));
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Paint3D.ZoomInteractor' at 7;4.", repo.Paint3D.ZoomInteractorInfo, new RecordItemIndex(1));
            //repo.Paint3D.ZoomInteractor.Click(new Location(ZoomInteractor_Screenshot1_2, "7;4", ZoomInteractor_Screenshot1_2_Options));
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=936,Height=794}) on item 'Paint3D.ZoomInteractor'.", repo.Paint3D.ZoomInteractorInfo, new RecordItemIndex(2));
            Validate.CompareImage(repo.Paint3D.ZoomInteractorInfo, ZoomInteractor_Screenshot2, ZoomInteractor_Screenshot2_Options, null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.Always, ReportSimilarity=Validate.ResultOption.Always, ReportDifferenceImages=Validate.ResultOption.Always, ReportExpectedAndActualImages=Validate.ResultOption.Always});
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage ZoomInteractor_Screenshot1
        { get { return repo.Paint3D.ZoomInteractorInfo.GetScreenshot1(new Rectangle(57, 110, 198, 142)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions ZoomInteractor_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage ZoomInteractor_Screenshot1_2
        { get { return repo.Paint3D.ZoomInteractorInfo.GetScreenshot1(new Rectangle(371, 418, 12, 8)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions ZoomInteractor_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Parse("0.97;EdgesSobel;0,0,0,0;True;10000000;0ms"); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage ZoomInteractor_Screenshot2
        { get { return repo.Paint3D.ZoomInteractorInfo.GetScreenshot2(new Rectangle(0, 0, 936, 794)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions ZoomInteractor_Screenshot2_Options
        { get { return Imaging.FindOptions.Parse("0.97;None;0,0,936,794;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}