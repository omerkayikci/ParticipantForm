using System.Collections.Generic;
using System.Linq;
using ParticipantForm.DataAccess.Abstraction;
using ParticipantForm.Entities.Model;

namespace ParticipantForm.DataAccess
{
    public class ParticipantFormRepository : IParticipantFormRepository
    {
        public List<Participant> GetParticipants()
        {
            using (var participantDbContext = new ParticipantDbContext())
            {
                return participantDbContext.Participant.ToList();
            }
        }

        public int CreateParticipant(Participant participant)
        {
            using (var participantDbContext = new ParticipantDbContext())
            {
                participantDbContext.Participant.Add(participant);
                participantDbContext.SaveChanges();
                return participant.Id;
            }
        }
    }
}