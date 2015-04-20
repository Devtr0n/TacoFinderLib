using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacoFinderServiceLib
{
    class TacoEnumUtil
    {
    }

    public enum TacoType : byte
    {
        Seafood = 1, AlPastor, AlCarbon, Gringo, Dessert, Fusion, Other
    }

    public enum TacoFillingType : byte
    {
        Meat = 1, Eggs, Veggie, Fish, Shrimp, Bean, Other
    }

    public enum TortillaType : byte
    {
        FlourHomemade = 1, FlourNonHomemade, YellowCorn, WhiteCorn, Hybrid, Other
    }

    public enum TortillaShellType : byte
    {
        Crispy = 1, Soft, Hard, Puffy, Other
    }

    public enum SalsaType : byte
    {
        Fresh = 1, PicoDeGallo, Verde, Tomatillo, Roja, Avocado, TacoSauce, Jarred, Other
    }

    public enum TacoToppingsType : byte
    {
        Cilantro = 1, WhiteOnion, Tomato, SourCream, Lettuce, RefriedBeans, ShreddedCheese, Jalapenos, Bacon, Chorizo, Sausage, Guacamole, Avocado, Olive, Mushroom, Corn, GreenOnion, Rice, Cabbage, GrilledOnions, Other
    }

    public enum TacoAvailablilityType : byte
    {
        Breakfast = 1, Lunch, Dinner, TwentyFourHour, Dessert, Other
    }

    public enum TacoLocationType : byte
    {
        Trailer = 1, Restaurant, Stand, Other
    }

    public enum UserType : byte
    {
        Regular = 1, Business, Admin, Other
    }

    public enum Rating : byte
    {
        Unacceptable = 1, JustAlright, Average, Good, VeryGood, Outstanding, Incredible
    }	
	
}
