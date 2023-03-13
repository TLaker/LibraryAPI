using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Numerics;

namespace BibliothekAPI
{
    public class HerfordData
    {
        public Book m1 = new(100, "Tales from Raccoon City", "Dmitry Lukhanenko", 319, "Various stories that happened in Raccoon City", "Horror", 29.99);
        public Movie m2 = new(101, "Resident Evil", "Paul W. S. Anderson", 100, "Movie based on the game 'Resident Evil'", "Horror", 19.99);
        public Book m3 = new(102, "Rick and Morty", "Justin Roiland", 159, "An old mad scientist and his nephew have several adventures with a portal gun", "Action", 24.99);
        public Movie m4 = new(103, "Silent Hill", "Christophe Gans", 127, "A woman loses her daughter in an abandoned town and tries to survive while searching for her", "Horror", 19.99);

    }

    public class CologneData
    {
        public Book m1 = new(100, "Metro 2033", "Dmitry Glukhovsky", 784, "Citizens of Moskow took shelter in the Metro during the beginning of an apocalypse. One of the survivors, Artjom, gets on a trip through the Metro to save his home station", "Action", 14.99);
        public Movie m2 = new(101, "2012", "Roland Emmerich", 154, "The world is about to end. Many natural catastrophes occurr and a group of people looks for shelter", "Action", 19.99);
        public Book m3 = new(102, "Universum", "Phillip P. Peterson", 448, "A group of people on board a spaceship gets in trouble after the ship went into hyperspace to travel faster than light", "Action", 16.99);
        public Movie m4 = new(103, "Leon, the Professional", "Luc Besson", 110, "Leon is a professional killer and meets a young girl who lost her family recently. An adventure awaits them together", "Adventure", 11.99);
    }


}
