using RestWithAspnetUdemy.Hypermedia;
using RestWithAspnetUdemy.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspnetUdemy.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
