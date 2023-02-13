﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI
{
    /// <summary>  
    /// Operation Interface  
    /// All operations must implement the interface  
    /// </summary>  
    /// <typeparam name="T">Data type supported in the operation</typeparam>  
    public interface IOperation<T>
    {
        /// <summary>  
        /// Executes the operation  
        /// </summary>  
        /// <param name="input">The Input Parameter</param>  
        /// <returns>Type defined for the operation</returns>  
        T Execute(T input);
    }
}
