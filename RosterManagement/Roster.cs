using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }
        
        /// <summary>
        /// Should be able to Add Student to a Particular Wave
        /// </summary>
        /// <param name="cadet">Refers to the name of the Cadet</param>
        /// <param name="wave">Refers to the Wave number</param>
        public void Add(string cadet, int wave)
        {
            if (_roster.ContainsKey(wave))
            {
                _roster[wave].Add(cadet);
            }
            else {
                List<string> x = new List<string>();
                x.Add(cadet);
                _roster.Add(wave, x);
                
            }
        }

        /// <summary>
        /// Returns all the Cadets in a given wave
        /// </summary>
        /// <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Grade(int wave)
        {
            var list = new List<string>();
            if (_roster.ContainsKey(wave))
            {
                list = _roster[wave];
                list.Sort();
            }
            return list;
        }

        /// <summary>
        /// Return all the cadets in the CodeSchool
        /// </summary>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Roster()
        {
            var cadets = new List<string>();
            //foreach (var a in _roster.Values) {
            //    foreach (string name in a) {
            //        cadets.Add(name);
            //    }
            //}
            //var list = from s in _roster
            //           orderby _roster.Keys ascending
            //           select s;
            //foreach(KeyValuePair<int,List<string>> kvp in list)
            //{
            //    var val = kvp.Value;
            //    val.Sort();
            //    foreach (string str in val)
            //    {
            //        cadets.Add(str);
            //    }

            //}
            var number = new List<int>();
            foreach (var a in _roster.Keys)
            {
                number.Add(a);
            }
            number.Sort();
            foreach (var sortednumber in number) {
                foreach (string name in Grade(sortednumber)) {
                    cadets.Add(name);
                }
            }
                return cadets;
            
        }
    }
}
