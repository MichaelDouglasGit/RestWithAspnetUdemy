using RestWithAspnetUdemy.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithAspnetUdemy.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
