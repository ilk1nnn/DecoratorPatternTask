using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DecoratorPatternTask.Services
{

    public interface IService
    {
        void  GetOneMedia(List<Media>medias);
    }

    public class Service : IService
    {
        public void GetOneMedia(List<Media>medias)
        {
            medias.Add(new Media());
        }

        public void GetOneMedia()
        {
            throw new NotImplementedException();
        }
    }
}
