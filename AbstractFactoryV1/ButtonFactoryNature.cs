﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV1
{
    internal class ButtonFactoryNature : IButtonFactory
    {
        public IButton Create()
        {
            throw new NotImplementedException();
        }
    }
}