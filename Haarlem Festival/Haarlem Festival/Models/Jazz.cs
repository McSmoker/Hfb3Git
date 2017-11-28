﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Haarlem_Festival.Models
{
    [Table("Jazz")]
    public class Jazz : Event
    {
        public string Artist { get; set; }
        public string Hall { get; set; }

        public Jazz(int eventId, DateTime eventStart, DateTime eventEnd, string location, int seats, int ticketsSold, string artist, string hall)
            : base(eventId, eventStart, eventEnd, location, seats, ticketsSold)
        {
            this.Artist = artist;
            this.Hall = Hall;
        }
    }
}