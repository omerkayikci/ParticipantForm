using System.Collections.Generic;
using ParticipantForm.Business.Abstraction;
using ParticipantForm.DataAccess.Abstraction;
using ParticipantForm.Entities.Model;

namespace ParticipantForm.Business
{
    public class ParticipantFormService : IParticipantFormService
    {
        private IParticipantFormRepository participantFormRepository;

        public ParticipantFormService(IParticipantFormRepository participantFormRepository)
        {
            this.participantFormRepository = participantFormRepository;
        }

        public List<Participant> GetParticipants()
        {
            return this.participantFormRepository.GetParticipants();
        }

        public int CreateParticipant(Participant participant)
        {
            return this.participantFormRepository.CreateParticipant(participant);
        }
    }
}