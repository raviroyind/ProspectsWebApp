using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProspectsWebApp
{
    static class StateArray
    {

        static readonly List<UsState> states;

        static StateArray()
        {
            states = new List<UsState>(50);
            states.Add(new UsState("AL", "Alabama"));
            states.Add(new UsState("AK", "Alaska"));
            states.Add(new UsState("AZ", "Arizona"));
            states.Add(new UsState("AR", "Arkansas"));
            states.Add(new UsState("CA", "California"));
            states.Add(new UsState("CO", "Colorado"));
            states.Add(new UsState("CT", "Connecticut"));
            states.Add(new UsState("DE", "Delaware"));
            states.Add(new UsState("DC", "District Of Columbia"));
            states.Add(new UsState("FL", "Florida"));
            states.Add(new UsState("GA", "Georgia"));
            states.Add(new UsState("HI", "Hawaii"));
            states.Add(new UsState("ID", "Idaho"));
            states.Add(new UsState("IL", "Illinois"));
            states.Add(new UsState("IN", "Indiana"));
            states.Add(new UsState("IA", "Iowa"));
            states.Add(new UsState("KS", "Kansas"));
            states.Add(new UsState("KY", "Kentucky"));
            states.Add(new UsState("LA", "Louisiana"));
            states.Add(new UsState("ME", "Maine"));
            states.Add(new UsState("MD", "Maryland"));
            states.Add(new UsState("MA", "Massachusetts"));
            states.Add(new UsState("MI", "Michigan"));
            states.Add(new UsState("MN", "Minnesota"));
            states.Add(new UsState("MS", "Mississippi"));
            states.Add(new UsState("MO", "Missouri"));
            states.Add(new UsState("MT", "Montana"));
            states.Add(new UsState("NE", "Nebraska"));
            states.Add(new UsState("NV", "Nevada"));
            states.Add(new UsState("NH", "New Hampshire"));
            states.Add(new UsState("NJ", "New Jersey"));
            states.Add(new UsState("NM", "New Mexico"));
            states.Add(new UsState("NY", "New York"));
            states.Add(new UsState("NC", "North Carolina"));
            states.Add(new UsState("ND", "North Dakota"));
            states.Add(new UsState("OH", "Ohio"));
            states.Add(new UsState("OK", "Oklahoma"));
            states.Add(new UsState("OR", "Oregon"));
            states.Add(new UsState("PA", "Pennsylvania"));
            states.Add(new UsState("RI", "Rhode Island"));
            states.Add(new UsState("SC", "South Carolina"));
            states.Add(new UsState("SD", "South Dakota"));
            states.Add(new UsState("TN", "Tennessee"));
            states.Add(new UsState("TX", "Texas"));
            states.Add(new UsState("UT", "Utah"));
            states.Add(new UsState("VT", "Vermont"));
            states.Add(new UsState("VA", "Virginia"));
            states.Add(new UsState("WA", "Washington"));
            states.Add(new UsState("WV", "West Virginia"));
            states.Add(new UsState("WI", "Wisconsin"));
            states.Add(new UsState("WY", "Wyoming"));
        }

        public static string[] Abbreviations()
        {
            var abbrevList = new List<string>(states.Count);
            abbrevList.AddRange(states.Select(state => state.Abbreviations));
            return abbrevList.ToArray();
        }

        public static string[] Names()
        {
            var nameList = new List<string>(states.Count);
            nameList.AddRange(states.Select(state => state.Name));
            return nameList.ToArray();
        }

        public static UsState[] States()
        {
            return states.ToArray();
        }

    }

    class UsState
    {

        public UsState()
        {
            Name = null;
            Abbreviations = null;
        }

        public UsState(string ab, string name)
        {
            Name = name;
            Abbreviations = ab;
        }

        public string Name { get; set; }

        public string Abbreviations { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Abbreviations, Name);
        }

    }
}