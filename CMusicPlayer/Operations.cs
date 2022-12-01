namespace CMusicPlayer
{
    internal class Operations
    {

        public static void Run()
        {
            Console.WriteLine("Welcome to 4im CMusic Player");
            Console.WriteLine("Kindly Select the operation you want to run. \n 1: VIew All Songs  \n 2: Add Song  \n 3: Create PlayList  \n 4: View list of PlayList");
            int selection = 0;
            Song song = new Song();

            CheckForDigits:
            if (int.TryParse(Console.ReadLine(), out selection))
            {

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("You have selected View All Songs");
                        song.ListAllSongs();
                        break;
                    case 2:
                         
                        Console.WriteLine("You have selected Add Song");
                        song.AddSong(AddSong());
                        Console.WriteLine("Song have been added successfully");
                        song.ListAllSongs();
                        break;
                    case 3: // View List of Songs in playlist
                        Console.WriteLine("You have selected 3");
                        break;
                    case 4:
                        //Edit Songs
                        Console.WriteLine("You have selected 4");
                        break;

                    default:
                        break;
                }

            }
            else
            {
                Console.WriteLine("The selected inpput is not a digit. Enter a suitable numer from the menu");
                goto CheckForDigits;
            }

        }



        public static Song AddSong()
        {
            Console.WriteLine("Enter the Name of the Song");
            string name = Console.ReadLine();
            if (!(name is not null))
            {
                Console.WriteLine("The input is not valid. Enter a Valid name of Song");
            }

            return new Song() { Name = name, Id = 6 };
        }



    }
}
