using OHI_Library_System.Logic.Services;
using OHI_Library_System.Models;
using OHI_Library_System.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHI_Library_System.Logic.Presenter
{
    class ToolsPresenter
    {
        ITools itools;
        ToolsModel toolsModel = new ToolsModel();


        public ToolsPresenter(ITools view)
        {
            this.itools = view;
        }


        // Connect between model books and interface books.
        private void connectBetweenModelInterface()
        {
            toolsModel.Tool_ID = itools.Tool_ID;
            toolsModel.Tool_Name = itools.Tool_Name;
            toolsModel.Tool_Description = itools.Tool_Description;
        }


        public bool ToolsInsert()
        {
            connectBetweenModelInterface();
            return ToolsService.toolInsert(toolsModel.Tool_ID, toolsModel.Tool_Name, toolsModel.Tool_Description);
        }


        public bool ToolsUpdate()
        {
            connectBetweenModelInterface();
            return ToolsService.toolUpdate(toolsModel.Tool_ID, toolsModel.Tool_Name, toolsModel.Tool_Description);
        }


        public bool ToolsDelete()
        {
            connectBetweenModelInterface();
            return ToolsService.toolDelete(toolsModel.Tool_ID);
        }


        public bool ToolsDeleteAll()
        {
            connectBetweenModelInterface();
            return ToolsService.toolDeleteAll();
        }


        public void ClearFields()
        {
            connectBetweenModelInterface();

            itools.Tool_ID = Convert.ToInt32("");
            itools.Tool_Name = "";
            itools.Tool_Description = "";
        }
    }
}
