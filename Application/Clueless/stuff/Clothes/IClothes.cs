using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Clueless.stuff.Clothes
{
    public interface IClothes
    {
        ICollection<int> getMainColors(); //TODO update to color
        ICollection<int> getAccentColors(); //TODO update to color 
        Brand getBrand();
        Fit getFit();
    }
}