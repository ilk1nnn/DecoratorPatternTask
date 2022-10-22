using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternTask.Services
{
    public class Decorator2 : IService
    {

        private IService service;

        public Decorator2(IService service)
        {
            this.service = service;
        }

        public void GetOneMedia(List<Media>medias)
        {
            service.GetOneMedia(medias);
        }
    }
}
