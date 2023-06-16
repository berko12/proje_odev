using Proje1.Enums;
using Proje1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Helpers
{
    class Helper
    {
        public static List<Movie> createMovies()
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Avatar",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 49 Dakika",
                    price = 50,
                    picturePath = basePath + "\\images.jpeg"
                },
                   new Movie()
                {
                    movieName = "Deadpool",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 10 Dakika",
                    price = 60,
                    picturePath = basePath + "\\143599.jpg"
                },
                new Movie()
                {
                    movieName = "Titanik",
                    category = Category.gerilim,
                    minute = "2 Saat 55 Dakika",
                    price = 20,
                    picturePath = basePath + "\\Titanik_film.jpg"
                },
                new Movie()
                {
                    movieName = "Baba",
                    category = Category.gerilim,
                    minute = "3 Saat 1 Dakika",
                    price = 30,
                    picturePath = basePath + "\\20155809.jpg-c_310_420_x-f_jpg-q_x-xxyxx.jpg"
                },
                new Movie()
                {
                    movieName = "X-Men",
                    category = Category.komedi,
                    minute = "2 Saat 40 Dakika",
                    price = 50,
                    picturePath = basePath + "\\p25028_p_v10_aa.jpg"
                },

             new Movie()
                {
                    movieName = "Karayip Korsanları",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 30 Dakika",
                    price = 200,
                    picturePath = basePath + "\\19771364.jpg"
                },


            };
        }
    }
}
