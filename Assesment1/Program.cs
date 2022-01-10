using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assessment
{
    abstract class Institute
    {
        public virtual void coursesoffer()
        {
            Console.WriteLine("cources that are offered C,C++,.NET,JAVA");
            Console.WriteLine("\n--------------------------------");
        }
        public void discount()
        {
            Console.WriteLine("discount 0");
            Console.WriteLine("\n--------------------------------");
        }
        abstract public void Address();

    }
    interface IpaperAds
    {
        void paperdetail();

    }

    interface ISocialMediaAds
    {
        void campigndetails();

    }
    interface IvehicleAds
    {
        void Addetails();

    }
    sealed class KnightLearningSolutions : Institute, IpaperAds, ISocialMediaAds, IvehicleAds
    {
        public new void discount()
        {

            base.discount();
            Console.WriteLine("Discount offered is 10%");
            Console.WriteLine("\n--------------------------------");
        }
        public override void Address()
        {
            Console.WriteLine("Address");
            Console.WriteLine("\n--------------------------------");
        }
        public void paperdetail()
        {
            Console.WriteLine("paper ad detais");
            Console.WriteLine("\n--------------------------------");
        }
        public void campigndetails()
        {
            Console.WriteLine("Social Media  Ads Details");
            Console.WriteLine("\n--------------------------------");
        }
        public void Addetails()
        {
            Console.WriteLine("Ads Details");
            Console.WriteLine("\n--------------------------------");
        }


    }
    sealed class SOnlineTrainings : Institute, ISocialMediaAds
    {
        public override void coursesoffer()
        {
            Console.WriteLine("cources that are offered AZURE,FLUTTER,XAMARIN");
            Console.WriteLine("\n--------------------------------");
        }


        public override void Address()

        {
            Console.WriteLine("Address details");
            Console.WriteLine("\n--------------------------------");

        }

        public void campigndetails()
        {
            Console.WriteLine("Social media Campaign details");
            Console.WriteLine("\n--------------------------------");
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            KnightLearningSolutions K = new KnightLearningSolutions();
            K.coursesoffer();
            K.discount();
            K.Address();
            K.paperdetail();
            K.campigndetails();
            K.Addetails();

            SOnlineTrainings S = new SOnlineTrainings();
            S.coursesoffer();
            S.discount();
            S.Address();
            S.campigndetails();

            Institute INS = new KnightLearningSolutions();
            INS.coursesoffer();
            INS.discount();
            INS.Address();

            Institute I = new SOnlineTrainings();
            I.coursesoffer();
            I.discount();
            I.Address();

            Console.ReadLine();
        }
    }
}
