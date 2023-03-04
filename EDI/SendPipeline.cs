using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI.Messages;
using EDI.Operations;

namespace EDI
{
    /// <summary>  
    /// Pipeline that sends message to the destination by performing operations  
    /// on the incoming message  
    /// </summary>  
    public class SendPipeline : Pipelinebase<IMessage>
    {
        /// <summary>  
        /// Constructor for the class where the operations are registered  
        /// for the messages  
        /// </summary>  
        /// <param name="setPriority">The Set Priority parameter</param>  
        /// <param name="encryptMessage">The Encrypt Message parameter</param>  
        public SendPipeline(bool setPriority, bool encryptMessage)
        {
            if (setPriority)
            {
                Register(new MessagePriorityOperation());
            }

            if (encryptMessage)
            {
                Register(new EncryptMessageOperation());
            }
        }
    }
}
