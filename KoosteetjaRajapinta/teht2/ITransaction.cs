﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    public interface ITransaction
    {
        // interface members 
        string ShowTransaction();
        float GetAmount();
    }
}
