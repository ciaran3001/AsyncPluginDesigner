using PluginDesigner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginDesigner.Models.DefineVariables
{
    class BooleanVariable : IWorkflowAction
    { 
        public bool? Value { get; set; }


        ReturnType IWorkflowAction.ReturnType()
        {
            return ReturnType.String;
        }

        public bool Execute()
        {
            return true;
        }


    }
}
