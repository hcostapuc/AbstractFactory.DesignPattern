using AbstractFactory.DesignPattern.AbstractFactoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesignPattern.CarnivoreFood
{
    internal class CarnivoreBiryaniRice : IRice
    {
        public async Task<string> GetRiceAsync() => await Task.FromResult("Here's your Carnivore Biryani rice");
    }
}
