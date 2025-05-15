﻿using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using RevitAddIn1.Views;

namespace RevitAddIn1.Commands
{
    /// <summary>
    ///     External command entry point
    /// </summary>
    [UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class StartupCommand : ExternalCommand
    {
        public override void Execute()
        {
            var view = Host.GetService<RevitAddIn1View>();
            view.Show(UiApplication.MainWindowHandle);
        }
    }
}