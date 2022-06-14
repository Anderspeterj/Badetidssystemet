using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadeTidsPeriodeForLoopAndList : BadetidsPeriode
    {

        public List<Kreds> KredseListe { get; set; }

        public BadeTidsPeriodeForLoopAndList(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt) : base(type, ugeDag, startTidspunkt, slutTidspunkt)

        {
            KredseListe = new List<Kreds>(); 

        }


        public override void AddKreds(Kreds kreds)
        {
            base.AddKreds(kreds);
        }

        public override void DeleteKreds(string id)
        {
            base.DeleteKreds(id);
        }

        public override string ToString()
        {
           

            foreach (Kreds kredse in KredseListe)
            {
                Console.WriteLine($"slutTidspunkt {kredse.Id}, {kredse.Navn}, {kredse.Addresse}, {kredse.AntalDeltagere}");

               
            }
            return $"Type: {Type}, UgeDag: {UgeDag}, StartTidspunkt {StartTidspunkt}, SlutTidspunkt: {SlutTidspunkt}";

        }
        

    }
}
