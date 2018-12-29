﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    public interface IRegisterMachine
    {
        void OpenChild(RegisterJob job);

        void RegisterPresenter(Presenter presenter);
    }
}