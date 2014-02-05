using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    public class VoteInfo
    {
        public int SiteID { get; set; }
        public string Count { get; set; } // oy veren sayısı
        public string Vote { get; set; }  // oy ortalaması veren sayısı
        public string Vote1 { get; set; }  // 1 oy sayısını veren sayısı
        public string Vote2 { get; set; }  // 2 oy sayısını veren sayısı
        public string Vote3 { get; set; }  // 3 oy sayısını veren sayısı
        public string Vote4 { get; set; }  // 4 oy sayısını veren sayısı
        public string Vote5 { get; set; }  // 5 oy sayısını veren sayısı
    }
}
