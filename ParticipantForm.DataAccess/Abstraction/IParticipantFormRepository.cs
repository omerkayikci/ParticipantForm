using System.Collections.Generic;
using ParticipantForm.Entities.Model;

namespace ParticipantForm.DataAccess.Abstraction
{
    public interface IParticipantFormRepository
    {
        List<Participant> GetParticipants();
        int CreateParticipant(Participant participant);
    }
}