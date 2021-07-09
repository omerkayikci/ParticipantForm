using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParticipantForm.Business.Abstraction;
using ParticipantForm.Entities.Model;

namespace ParticipantForm.Api.Controllers
{
    [ApiController]
    [Route("participantForm")]
    public class ParticipantFormController : ControllerBase
    {
        private IParticipantFormService participantFormService;

        public ParticipantFormController(IParticipantFormService participantFormService)
        {
            this.participantFormService = participantFormService;
        }

        [Route("participants")]
        [HttpGet]
        public IEnumerable<Participant> GetParticipantForm()
        {
            return this.participantFormService.GetParticipants();
        }

        [Route("addParticipant")]
        [HttpPost]
        public Participant CreateParticipantForm([FromBody] Participant participant)
        {
            return this.participantFormService.CreateParticipant(participant);
        }
    }
}