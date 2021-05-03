using System;
using System.Collections.Generic;

namespace DogFactsSamples
{
    public class ChrisFactData
    {
        public ChrisFactData()
        {
        }
        public static IEnumerable<ChrisFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        static ChrisFactData()
        {
            List<ChrisFactData> all = new List<ChrisFactData>();
            all.Add(new ChrisFactData() { TheFact = "I was born in Burlington Wi", ShortFact = "Born" });
            all.Add(new ChrisFactData() { TheFact = "I don't know how to swim.", ShortFact = "How I will die" });
            all.Add(new ChrisFactData() { TheFact = "I have been to Hawaii two times. ", ShortFact = "Travel bug" });
            all.Add(new ChrisFactData() { TheFact = "I live in West Allis, WI.  ", ShortFact = "Milwaukee" });
            all.Add(new ChrisFactData() { TheFact = "My girlfriend and I have been togther for over eight years. ", ShortFact = "Girlfriend" });
            All = all;

        }
    }
}