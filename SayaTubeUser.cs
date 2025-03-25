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
            uploadedVideos.Add(data);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
            }
        }
    }
}
