using System.Collections.Generic;
using Clueless.stuff.Acessory;
using Clueless.stuff.Clothes;

namespace Clueless.stuff.Outfits
{
    public interface IOutfit
    {
        ICollection<IClothes> GetClothes();
        ICollection<IAccessory> getAccessories();
        ICollection<int> getColors();
        void addClothes(IClothes clothes);
        void addAccessory(IAccessory accessory);
        void removeClothes(IClothes clothes);
        void removeAccesory(IAccessory accessory);
    }
}