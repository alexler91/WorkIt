﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkIt.Controller.Commands;
using WorkIt.Model;
using WorkIt.View;

namespace WorkIt.Controller
{
    public interface IController
    {
        void SetModel(IModel model);
        void SetView(IView view);
        Dictionary<string, ICommand> GetCommands();

        void table(DataSet ds, string s);

        void Output(string s);
    }
}
