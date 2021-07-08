using System.Collections.Generic;
using ParticipantForm.Entities.Model;

namespace ParticipantForm.Business.Abstraction
{
    public interface IParticipantFormService
    {
        List<Participant> GetParticipants();
        int CreateParticipant(Participant participant);
    }
}