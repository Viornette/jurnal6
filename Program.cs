using modul6_103022300145;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Elvina");
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film The Substance oleh Elvina Nilysti Huang");
        video1.IncreasePlayCount(1000000);
        video1.PrintVideoDetails();
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Pinokio oleh Elvina Nilysti Huang");
        video2.IncreasePlayCount(1000000);
        video2.PrintVideoDetails();
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film The Suicide Squad oleh Elvina Nilysti Huang");
        video3.IncreasePlayCount(1000000);
        video3.PrintVideoDetails();
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Di Ambang Kematian oleh Elvina Nilysti Huang");
        video4.IncreasePlayCount(1000000);
        video4.PrintVideoDetails();
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Pengantin Iblis oleh Elvina Nilysti Huang");
        video5.IncreasePlayCount(1000000);
        video5.PrintVideoDetails();
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Pengantin Setan oleh Elvina Nilysti Huang");
        video6.IncreasePlayCount(1000000);
        video6.PrintVideoDetails();
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Winnie The Poo oleh Elvina Nilysti Huang");
        video7.IncreasePlayCount(1000000);
        video7.PrintVideoDetails();
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Alice in Wonderlands oleh Elvina Nilysti Huang");
        video8.IncreasePlayCount(1000000);
        video8.PrintVideoDetails();
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Rapunzel oleh Elvina Nilysti Huang");
        video9.IncreasePlayCount(1000000);
        video9.PrintVideoDetails();
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Maleficent oleh Elvina Nilysti Huang");
        video10.IncreasePlayCount(1000000);
        video10.PrintVideoDetails();

        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        Console.WriteLine("\nTotal Tayang: " + user.GetTotalVideoPlayCount() + " kali ditonton\n");
        Console.WriteLine("============================PROFIL PENGGUNA============================");
        user.PrintAllVideoPlaycount();
        Console.WriteLine("=======================================================================");
    }
}