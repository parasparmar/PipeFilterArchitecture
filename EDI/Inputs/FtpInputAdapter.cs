using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDI.Messages;

namespace EDI.Inputs
{
    public class FtpInputAdapter : IInputAdapter
    {
        public string FilePath { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

        public List<IMessage> GetInputFiles(string FilePath)
        {
            var files = new List<string>();
            // Find all files at the above path and then convert them to C# object of Interface IMessage
            var outputfiles = new List<IMessage>();
            // Add the C# Objects to the files list.
            return outputfiles;
        }


    }
}
