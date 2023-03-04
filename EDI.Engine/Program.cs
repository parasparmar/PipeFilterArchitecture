using EDI;
using EDI.Messages;

//INPUT
IMessage message = new Message(messageId: "1",
                body: "This is the message body",
                header: "Header Information",
                subject: "Please set priority and encrypt the message");

//sending code to the pipeline and the message is encrypted and published into the queue  
SendPipeline sendPipeline = new SendPipeline(true, true);

var publishedMessage = sendPipeline.PerformOperation(message);


string Message = $"I am client1 and my messages should be prioritized and encrypted!!!\n My message Priority Set? {publishedMessage.IsMessagePrioritySet()}\n My message Encrypted? {publishedMessage.IsMessageEncrypted()}";

Console.WriteLine(Message);


Console.Read();
