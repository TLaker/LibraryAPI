﻿namespace BibliothekAPI
{
    public class Movie : Medium
    {
        public string Regisseur { get; set; }
        public int PlayLengthMinutes { get; set; }

        public Movie(int id, string title, string regisseur, int playLengthMinutes, string description, string type, double cost) : base(id, title, description, type, cost)
        {
            Regisseur = regisseur;
            PlayLengthMinutes = playLengthMinutes;
        }
    }
}
