﻿namespace LibS3.C8
{
    public class ArmeC8 : ObjetC8
    {
       //Prop dommage 
        private int _dommage;

        public int Dommage
        {
            get { return _dommage; }
            private set { _dommage = value; }
        }

        public ArmeC8()
        {
        }

        //Cree arme utilisant le parent Objet
        public ArmeC8(string nom, int dommage) : base(nom)
        {
            _dommage = dommage;
        }

        //retourne affichage ToString string
        public override string ToString()
        {
            return $"Arme\n" +
                   $"ID        : {base.Id}\n" +
                   $"Nom       : {base.Nom}\n" +
                   $"Dommage   : {_dommage}\n";
        }
    }
}
