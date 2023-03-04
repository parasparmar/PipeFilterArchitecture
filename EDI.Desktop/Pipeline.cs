using System.Windows.Forms;
using EDI.Messages;

namespace EDI.Desktop
{
    public partial class Pipeline : Form
    {
        public Pipeline()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void ProcessPipelinebtn_Click(object sender, EventArgs e)
        {
            tbLogs.Clear();
            string Message = string.Empty;
            //INPUT
            IMessage message = new Messages.Message(
                messageId: "1",
                body: "This is the message body",
                header: "Header Information",
                subject: "Please set priority and encrypt the message");

            //sending code to the pipeline and the message is encrypted and published into the queue  
            SendPipeline sendPipeline = new SendPipeline(true, true);
            var publishedMessage = sendPipeline.PerformOperation(message);
            Message = $"Message Priority : {publishedMessage.IsMessagePrioritySet()} Message Encryption : {publishedMessage.IsMessageEncrypted()}";
            tbLogs.Text = Message;


        }
    }
}