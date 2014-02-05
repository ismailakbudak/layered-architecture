using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    public class SiteVoteCount
    {
        public int SiteID { get; set; }
        public int Count { get; set; } // oy veren sayısı
        public int Vote { get; set; }  // oy ortalaması veren sayısı

    }
}
