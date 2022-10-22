using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternTask.Services
{
    public class InstagramDecorator : Decorator2,IService
    {

        public InstagramDecorator(IService service) : base(service)
        {
        }

        public void GetOneMedia(List<Media>medias)
        {
            medias.Add(new Media
            {
                ImagePath = "Images/instagram.png",
                MediaName = "Instagram Service"
            });
        }

       
    }
}
