using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class GenerateData
    {

        public static void Initialize(ArticleContext context)
        {
            if (!context.Articles.Any())
            {
                context.Articles.AddRange(
                        new Article
                        {
                            Title = "718",
                            Body_text = "",
                            Title_Body_text = "",
                            Video_url = "https://porsche.ua/images/doc/f/3/f3f423e-porsche-normal--17-.jpg",
                            Img_url = "https://porsche.ua/images/doc/0/1/0132798-718.jpg",
                        },
                        new Article
                        {
                            Title = "911",
                            Body_text = "",
                            Title_Body_text = "911 Carrera 4 Cabriolet",
                            Video_url = "https://www.porsche.com/filestore/video/multimedia/none/modelseries-911carrera992-intro-loop/video-mp4/01c97d2d-e819-11e8-bec8-0019999cd470/porsche-video.mp4",
                            Img_url = "https://porsche.ua/images/doc/1/c/1c9a792-911.jpg",
                        },
                        new Article
                        {
                            Title = "Taycan",
                            Body_text = "",
                            Title_Body_text = "",
                            Video_url = "",
                            Img_url = "https://porsche.ua/images/doc/3/1/3135b3f-taycan.jpg",
                        },
                        new Article
                        {
                            Title = "Panamera",
                            Body_text = "",
                            Title_Body_text = "",
                            Video_url = "",
                            Img_url = "https://porsche.ua/images/doc/5/1/5101c0e-panamera.jpg",
                        },
                        new Article
                        {
                            Title = "Macan",
                            Body_text = "",
                            Title_Body_text = "",
                            Video_url = "",
                            Img_url = "https://porsche.ua/images/doc/6/9/695c16e-macan.jpg",
                        },
                        new Article
                        {
                            Title = "Cayenne",
                            Body_text = "",
                            Title_Body_text = "",
                            Video_url = "",
                            Img_url = "https://porsche.ua/images/doc/7/c/7c188d5-cayenne.jpg",
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}
