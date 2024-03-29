﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI.Messages;

namespace EDI.Operations
{
    /// <summary>  
    /// Sets Message priority to the incoming message  
    /// </summary>  
    public class MessagePriorityOperation : IOperation<IMessage>
    {
        /// <summary>  
        /// Executes the operations  
        /// </summary>  
        /// <param name="input">The input message</param>  
        /// <returns>Message with the priority set</returns>  
        public IMessage Execute(IMessage input)
        {
            input.Priority = 1;

            return input;
        }
    }
}
