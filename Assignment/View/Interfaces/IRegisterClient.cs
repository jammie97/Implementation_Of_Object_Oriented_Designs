﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    public interface IRegisterClient
    {
        void OpenChild(Home home);

        void RegisterPresenter(Presenter presenter);

    }
}