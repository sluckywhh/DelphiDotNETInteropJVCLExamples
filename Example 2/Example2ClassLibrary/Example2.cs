﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Example2ClassLibrary
{
    [ComVisible(true)]
    public class Example2
    {
        
        public int AddFunction(int aXValue, int aYValue)
        {

            return aXValue + aYValue;
        }


        
    }
}
