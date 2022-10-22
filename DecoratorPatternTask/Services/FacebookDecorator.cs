using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace DecoratorPatternTask.Services
{
    public class FacebookDecorator : Decorator2, IService
    {
        public FacebookDecorator(IService service) : base(service)
        {
        }

        public void GetOneMedia(List<Media>medias)
        {
            medias.Add(new Media
            {
                ImagePath = "Images/facebook.png",
                MediaName = "Facebook Service"
            });
        }

      



    }
}
