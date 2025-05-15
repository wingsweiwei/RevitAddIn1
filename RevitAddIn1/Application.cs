﻿using Nice3point.Revit.Toolkit.External;
using RevitAddIn1.Commands;

namespace RevitAddIn1
{
    /// <summary>
    ///     Application entry point
    /// </summary>
    [UsedImplicitly]
    public class Application : ExternalApplication
    {
        public override void OnStartup()
        {
            Host.Start();
            CreateRibbon();
        }

        public override void OnShutdown()
        {
            Host.Stop();
        }

        private void CreateRibbon()
        {
            var panel = Application.CreatePanel("Commands", "RevitAddIn1");

            panel.AddPushButton<StartupCommand>("Execute")
                .SetImage("/RevitAddIn1;component/Resources/Icons/RibbonIcon16.png")
                .SetLargeImage("/RevitAddIn1;component/Resources/Icons/RibbonIcon32.png");
        }
    }
}