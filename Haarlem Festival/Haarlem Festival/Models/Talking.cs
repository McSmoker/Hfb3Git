using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Haarlem_Festival.Models
{
    [Table("Talking")]
    public class Talking : Event
    {
        public string SpeakerOneName { get; set; }
        public string SpeakerTwoName { get; set; }

        public Talking(int eventId, DateTime eventStart, DateTime eventEnd, string location, int seats, int ticketsSold, string speakerOneName, string speakerTwoName)
            : base(eventId, eventStart, eventEnd, location, seats, ticketsSold)
        {
            this.SpeakerOneName = speakerOneName;
            this.SpeakerTwoName = speakerTwoName;
        }
    }
}