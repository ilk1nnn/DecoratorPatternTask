using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternTask.Services
{
    public class TwitterDecorator : Decorator2,IService
    {

        public TwitterDecorator(IService service) : base(service)
        {
        }
        public void GetOneMedia(List<Media> medias)
        {
            medias.Add(new Media
            {
                ImagePath = "Images/twitter.png",
                MediaName = "Twitter Service"
            });
        }


    }
}
