using System.Collections.Generic;
using ParticipantForm.Entities.Model;

namespace ParticipantForm.Business.Abstraction
{
    public interface IParticipantFormService
    {
        List<Participant> GetParticipants();
        Participant CreateParticipant(Participant participant);
    }
}