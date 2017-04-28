﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingRaceMVC.Models
{
    public class Board
    {
        public int TeamId { get; set; }
        public int PitStopsCleared { get; set; }
        public int PitStopsRemaining { get; set; }
        public string Team { get; set; }
        public int TotalPitStops { get; set; }
    }
}