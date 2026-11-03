using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkCore.Domain
{
    public class TeamsCoachesLeaguesView
    {
        public string Name { get; set; }
        public string LeagueName { get; set; }
        public string CoachName { get; set; }

    }
}
