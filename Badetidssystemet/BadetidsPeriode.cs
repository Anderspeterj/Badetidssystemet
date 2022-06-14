using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Badetidssystemet
{
    class BadetidsPeriode
    {
        public string _type;
        public DayOfWeek _ugeDag;
        public DateTime _startTidspunkt;
        public DateTime _slutTidspunkt;
        public Dictionary<string, Kreds> kredserne;


        public BadetidsPeriode(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            _type = type;
            _ugeDag = ugeDag;
            _startTidspunkt = startTidspunkt;
            _slutTidspunkt = slutTidspunkt;
            kredserne = new Dictionary<string, Kreds>();
            var count = 0;
            try
            {
                
                foreach (var character in Type)
                {
                    if (char.IsDigit(character)) count++;
                    if (count < 5)
                    {
                        throw new ArgumentException();
                    }
                }
            }catch
            {
                Console.WriteLine("Type skal min. indeholde 4 karakterer");
            }
           
           try
            {     
                if (StartTidspunkt > SlutTidspunkt || SlutTidspunkt == StartTidspunkt)  // <- implementering af UserStory
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                Console.WriteLine("Fejl!! StartTidspunkt skal være før sluttidspunkt / kan ikke være det samme tidspunkt");
            }
            

        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public DayOfWeek UgeDag
        {
            get { return _ugeDag; }
            set { _ugeDag = value; }
        }
        public DateTime StartTidspunkt
        {
            get { return _startTidspunkt; }
            set { _slutTidspunkt = value; }
        }

        public DateTime SlutTidspunkt
        {
            get { return _slutTidspunkt; }
            set { _slutTidspunkt = value; }
        }


        

         public override string ToString()
        {


            foreach (KeyValuePair<string, Kreds> person in kredserne)
            {
                Console.WriteLine($"{person.Key}, {person.Value}");

            }

            return $"Type: {Type}, UgeDag: {UgeDag}, StartTidspunkt {StartTidspunkt}, SlutTidspunkt: {SlutTidspunkt}";
        }

        public void AddKreds(Kreds kreds)
        {
            kredserne.Add(kreds.Id, kreds);
            

        }

        


        public void DeleteKreds(string id)
        {


            kredserne.Remove(id);


        }



    }
}
