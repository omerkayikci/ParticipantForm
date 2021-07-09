using System.Collections.Generic;
using System.Linq;
using ParticipantForm.Business.Abstraction;
using ParticipantForm.DataAccess;
using ParticipantForm.DataAccess.Abstraction;
using ParticipantForm.Entities.Model;

namespace ParticipantForm.Business
{
    public class ParticipantFormService : IParticipantFormService
    {
        
        private ParticipantDbContext participantDbContext;

        public ParticipantFormService(ParticipantDbContext participantDbContext)
        {
            this.participantDbContext = participantDbContext;
        }

        public List<Participant> GetParticipants()
        {
            return this.participantDbContext.Participant.ToList();
        }

        public Participant CreateParticipant(Participant participant)
        {
            this.participantDbContext.Participant.Add(participant);
            this.participantDbContext.SaveChanges();
            
            return participant;
        }
    }
}