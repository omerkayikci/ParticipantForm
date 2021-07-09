using System;
using System.ComponentModel.DataAnnotations;

namespace ParticipantForm.Entities.Model
{
    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}