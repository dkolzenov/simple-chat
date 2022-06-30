namespace SimpleChat.Api.Controllers
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;

    using SimpleChat.Services.Interfaces;
    using SimpleChat.Models.Message;

    [ApiController]
    [Route("api/messages")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MessageModel>>> GetAllMessages()
        {
            var messages = await _messageService.GetAllMessages();

            return messages;
        }
    }
}
