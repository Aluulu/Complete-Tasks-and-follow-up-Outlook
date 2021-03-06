﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Net.Mail;

namespace Complete_Tasks_and_follow_up_Outlook
{
    public partial class ThisAddIn
    {
        // Add code here to run when the add-in is loaded in 
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            
        }
        private void CheckTaskAsComplete()
        {
            


        }

        // Add code here to run when the add-in is unloaded
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}

// https://docs.microsoft.com/en-us/visualstudio/vsto/walkthrough-creating-your-first-vsto-add-in-for-outlook?view=vs-2019
// https://docs.microsoft.com/en-us/visualstudio/vsto/programming-vsto-add-ins?view=vs-2019
// https://docs.microsoft.com/en-us/visualstudio/vsto/outlook-object-model-overview?view=vs-2019
// https://docs.microsoft.com/en-us/connectors/outlooktasks/
// https://docs.microsoft.com/en-gb/office/client-developer/outlook/pia/tasks
// https://www.add-in-express.com/creating-addins-blog/2013/06/12/outlook-tasks-create-get-delete/