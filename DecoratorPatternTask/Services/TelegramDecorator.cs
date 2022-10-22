using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternTask.Services
{
    public class TelegramDecorator : Decorator2,IService
    {
        public TelegramDecorator(IService service) : base(service)
        {
        }

        public void GetOneMedia(List<Media> medias)
        {
            medias.Add(new Media
            {
                ImagePath = "Images/telegram.png",
                MediaName = "Telegram Service"
            });
        }


    }
}
