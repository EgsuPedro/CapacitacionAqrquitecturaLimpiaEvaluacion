﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore;

    public interface IProductoRespository
    {
    IEnumerable<Producto> ObtenerTodosLosProductos();


    }

