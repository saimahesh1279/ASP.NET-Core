using EntityFrameWorkCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkCore.Domain
{
    public class Coach : BaseDomainObject
    {
        public string Name { get; set; }
        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
