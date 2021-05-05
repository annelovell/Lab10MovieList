using System;
using System.Collections.Generic;

namespace Lab10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
                // Category
            Movie TheLionKing = new Movie("Animated", "The Lion King");
            Movie ABugsLife = new Movie("Animated", "A Bugs Life");
            Movie FindingNemo = new Movie("Animated", "Finding Nemo");
            Movie ToyStory = new Movie("Animated", "Toy Story");
            Movie Aladdin = new Movie("Animated", "Aladdin");
            
            Movie GoneWithTheWind = new Movie("Drama", "Gone With The Wind");
            Movie SavingPrivateRyan = new Movie("Drama", "Saving Private Ryan");
            Movie TheGreatGatsby = new Movie("Drama", "The Great Gatsby");
            Movie ARiverRunsThroughIt = new Movie("Drama", "A River Runs Through It");
            Movie TheColorPurple = new Movie("Drama", "The Color Purple");
                        
            Movie Halloween = new Movie("Horror", "Halloween");
            Movie ANightmareOnElmStreet = new Movie("Horror", "A Nightmare On Elm Street");
            Movie Fridaythe13th = new Movie("Horror", "Friday The 13th");
            Movie Hellraiser = new Movie("Horror", "Hellraiser");
            Movie IknowWhatYouDidLastSummer = new Movie("Horror", "I Know What You Did Last Summer");
             
            Movie StarWarsEpisode1PhantomMenace = new Movie("Scifi",  "Star Wars: Episode 1: The Phantom Menace");
            Movie Alien = new Movie("Scifi", "Alien");
            Movie Tremors = new Movie("Scifi", "Tremors");
            Movie Predator = new Movie("Scifi", "Predator");
            Movie ASpaceOdyssey = new Movie("Scifi", "A Space Odyssey");
             

            Console.WriteLine("Please enter a category:");
            string input = Console.ReadLine();

            List<Movie> Animated = new List<Movie>
            {
                TheLionKing, ABugsLife, FindingNemo, ToyStory, Aladdin
            };

            List<Movie> Drama = new List<Movie>
            {
                GoneWithTheWind, SavingPrivateRyan, TheGreatGatsby, ARiverRunsThroughIt, TheColorPurple
            };

            List<Movie> Horror = new List<Movie>
            {
               Halloween, ANightmareOnElmStreet, Fridaythe13th, Hellraiser, IknowWhatYouDidLastSummer
            };
            List<Movie> Scifi = new List<Movie>
            {
               StarWarsEpisode1PhantomMenace, Alien, Tremors, Predator, ASpaceOdyssey
            };


            foreach (Movie category in Animated)
            {
                category.PrintInfo();
            }

        }
    }
}
