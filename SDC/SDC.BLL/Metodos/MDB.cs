﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SDC.BLL.Metodos
{
    public class MDB
    {
        public DAL.Interfaces.IEstudiante estu;

        public MDB()
        {
            estu = new DAL.Metodos.MEstudiante();
        }

    }
}