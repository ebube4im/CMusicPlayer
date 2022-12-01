namespace CMusicPlayer
{
    internal class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Duration { get; set; }
        public string Artist { get; set; }

        public static List<Song> Songs { get; set; } = new List<Song>()
            {
                new Song(){ Id = 1, Name = "You Covered me", Artist="Tye Tribbett", Description = "You covered me", Duration = 2.20m},
                 new Song(){ Id = 2, Name = "Heaven at last", Artist="Donnie MCklurkins", Description = "You covered me", Duration = 4.20m},
                  new Song(){ Id = 3, Name = "You have done enough", Artist="Mercy Chinwo", Description = "You covered me", Duration = 3.20m},
                   new Song(){ Id = 4, Name = "Omemma", Artist="JudiKay", Description = "You covered me", Duration = 1.20m},
                    new Song(){ Id = 5, Name = "What did I do", Artist="GUC", Description = "You covered me", Duration = 2.20m}
            };


        public void Play(Song song)
        {
            Console.WriteLine($"Playing {song.Name}");
            song.Play(song);

        }




        public void ListAllSongs()
        {
            foreach (Song song in Songs)
            {
                Console.WriteLine($" ID: {song.Id} | Name: {song.Name}");
            }
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
        }


    }
}
