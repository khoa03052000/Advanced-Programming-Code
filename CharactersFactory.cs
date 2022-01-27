using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{

    public class CharactersFactory
    {
        
        private CharactersFactory()
        {

        }
        public static CharactersAbstractFactory GetFactory(Elements elements)
        {
            switch (elements) 
            {
                case Elements.Fire:
                    return new FireFactory();
                case Elements.Water:
                    return new WaterFactory();
                default:
                    Console.WriteLine("No elements");
                    return null;
            }
        }
    }
    public enum Elements
    {
        Fire,
        Water
    }


}
