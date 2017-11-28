﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Haarlem_Festival.Models
{
    public abstract class Event
    {
        [Key]
        public int EventId { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string Location { get; set; }
        public int Seats { get; set; }
        public int TicketsSold { get; set; }
        public string Content { get; set; }

        public Event(int eventId, DateTime eventStart, DateTime eventEnd, string location, int seats, int ticketsSold)
        {
            this.EventId = eventId;
            this.EventEnd = eventStart;
            this.EventEnd = eventEnd;
            this.Location = location;
            this.Seats = seats;
            this.TicketsSold = ticketsSold;
        }
    }
}