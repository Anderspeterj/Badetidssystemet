using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class Kreds
    {
        private string _id;
        private string _navn;
        private string _addresse;
        private int _antalDeltagere;
        


        public Kreds(string id, string navn, string addresse, int antalDeltagere)
        {
            _id = id;
            _navn = navn;
            _addresse = addresse;
            _antalDeltagere = antalDeltagere;
            try
            {
                if (AntalDeltagere == 0 || AntalDeltagere > 10) // <- Implementering af UserStory
                {
                    throw new ArgumentException();
                }
            }catch (ArgumentException)
            {
                Console.WriteLine("Deltagere skal være større end 0 / maks 10 deltagere!");
            }

            
            
            
        }



        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public string Addresse
        {
            get { return _addresse; }
            set { _addresse = value; }
        }
        public int AntalDeltagere
        {
            get { return _antalDeltagere; }
            set { _antalDeltagere = value; }

        }
        

        public override string ToString()
        {
            return $"Id: {Id}, Navn: {Navn}, Addresse {Addresse}, antaldeltagere: {AntalDeltagere}";
        }

        

       
    }
}
