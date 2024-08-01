using ObserverDesignPattern.Notifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();

            var emailNotifier = new EmailNotifier(videoData);
            var facebookNotifier = new FacebookNotifier(videoData);

            videoData.SetDescription("xxxxxx");
            videoData.DettachObserver(emailNotifier);
            Console.WriteLine("________________________________________");
            videoData.SetTitle("facebook");

        }
    }
}
