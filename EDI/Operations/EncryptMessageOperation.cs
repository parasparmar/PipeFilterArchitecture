using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI.Messages;

namespace EDI.Operations
{
    /// <summary>  
    /// Encrypts the message  
    /// </summary>
    public class EncryptMessageOperation : IOperation<IMessage>
    {
        /// <summary>  
        /// Executes the operation on the message  
        /// </summary>  
        /// <param name="input">The Input Message</param>  
        /// <returns>Type of IMessage</returns>  
        public IMessage Execute(IMessage input)
        {
            return Encrypt(input);
        }

        /// <summary>  
        /// Encrypts the message  
        /// </summary>  
        /// <param name="input">The Input Message</param>  
        /// <returns>Type of IMessage</returns>  
        private IMessage Encrypt(IMessage input)
        {
            input.IsEncrypted = true;
            //Encryption code  
            // Here I will use 256 bit encryption
            return input;
        }
    }
}
