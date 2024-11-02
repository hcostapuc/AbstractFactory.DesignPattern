using AbstractFactory.DesignPattern.AbstractFactoryInterfaces;
using AbstractFactory.DesignPattern.CarnivoreCombo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesignPattern.CarnivoreFood
{
    internal class CarnivoreComboFactory : IFoodComboFactory
    {
        public async Task<IFry> CreateFryAsync() => await Task.FromResult(new Gobi65Fry());
        public async Task<IGravy> CreateGravyAsync() => await Task.FromResult(new PaneerButterMasalaGravy());
        public async Task<IRice> CreateRiceAsync() => await Task.FromResult(new CarnivoreBiryaniRice());
    }
}
