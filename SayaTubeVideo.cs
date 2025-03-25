using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300145
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (title == null || title.Length > 200)
            {
                throw new ArgumentException("Judul video tidak boleh null dan maksimal 200 karakter.");
            }
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 25000000 || count < 0)
            {
                throw new ArgumentException("Penambahan play count maksimal 25.000.000 per panggilan dan tidak boleh negatif");
            }
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }

            catch (OverflowException)
            {
                Console.WriteLine("Error: Overflow terjadi pada penambahan play count.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }

        public int getPlayCount()
        {
            return playCount;
        }

        public string getTitle()
        {
            return title;
        }
    }
}
