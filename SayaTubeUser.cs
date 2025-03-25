using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300145
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            if (username == null || username.Length > 100)
            {
                throw new ArgumentException("Username akun tidak boleh null dan maksimal 100 karakter.");
            }
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.username = username;
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int hasil = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                hasil += uploadedVideos[i].getPlayCount();
            }
            return hasil;
        }

        public void AddVideo(SayaTubeVideo data)
        {
            if (data == null)
            {
                throw new ArgumentException("Video yang ditambahkan tidak boleh null.");
            }
            try
            {
                checked
                {
                    data.getPlayCount();
                }
            }

            catch (OverflowException)
            {
                Console.WriteLine("Error: Overflow terjadi pada jumlah PlayCount.");
            }
            uploadedVideos.Add(data);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + username);
            Console.WriteLine("===Menampilkan 8 judul video teratas===");
            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
            }
        }
    }
}
