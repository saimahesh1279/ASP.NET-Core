using EntityFrameWorkCore.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkCore.Domain
{
    public class Match: BaseDomainObject
    {
        public int HomeTeamId { get; set; }
        public virtual Team HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public virtual Team AwayTeam { get; set; }

        [Precision(18, 2)]
        public decimal TicketPrice { get; set; }

        public DateTime Date { get; set; }
    }
}
