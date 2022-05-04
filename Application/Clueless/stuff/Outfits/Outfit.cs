using System;
using System.Collections.Generic;
using Clueless.stuff.Acessory;
using Clueless.stuff.Clothes;

namespace Clueless.stuff.Outfits
{
    public class Outfit : IOutfit
    {
        private List<IClothes> _clothes;
        private List<IAccessory> _accessories;
        private Style _style;

        public ICollection<IClothes> GetClothes()
        {
            return _clothes;
        }
        public ICollection<IAccessory> getAccessories()
        {
            return _accessories;
        }

        public ICollection<int> getColors()
        {
            throw new NotImplementedException();
        }

        public void addClothes(IClothes clothes)
        {
            if (_clothes.Contains(clothes)) { throw new System.Exception("clothes already in outfit"); } //TODO update exception
            _clothes.Add(clothes);
        }
        public void addAccessory(IAccessory accessory)
        {
            _accessories.Add(accessory);
        }
        public void removeClothes(IClothes clothes)
        {
            if (!_clothes.Contains(clothes)) { throw new System.Exception("clothes aren't in outfit"); } //TODO update exception
            _clothes.Remove(clothes);
        }
        public void removeAccesory(IAccessory accessory)
        {
            if (!_accessories.Contains(accessory)) { throw new System.Exception("clothes aren't in outfit"); } //TODO update exception
            _accessories.Remove(accessory);
        }
    }
}