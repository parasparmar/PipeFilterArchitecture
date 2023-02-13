using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EDI;
namespace KaleMessageBroker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            IMessage message = new Message(messageId: "1",
                body: "This is the message body",
                header: "Header Information",
                subject: "Please set priority and encrypt the message");

            //sending code to the pipeline and the message is encrypted and published into the queue  
            SendPipeline sendPipeline = new SendPipeline(true, true);
            var publishedMessage = sendPipeline.PerformOperation(message);
            Message = $"I am client1 and my messages should be prioritized and encrypted!!!\n My message Priority Set? {publishedMessage.IsMessagePrioritySet()}\n My message Encrypted? { publishedMessage.IsMessageEncrypted()}";
            //_logger.LogInformation("I am client1 and my messages should be prioritized and encrypted!!!");
            //_logger.LogInformation("My message Priority Set? {0}", publishedMessage.IsMessagePrioritySet());
            //_logger.LogInformation("My message Encrypted? {0}", publishedMessage.IsMessageEncrypted());

        }
    }
}