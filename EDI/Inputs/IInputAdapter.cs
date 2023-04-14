using EDI.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI.Inputs
{
    public interface IInputAdapter
    {
        List<IMessage> GetInputs(string FilePath);
    }
}
