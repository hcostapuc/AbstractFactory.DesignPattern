using AbstractFactory.DesignPattern.AbstractFactoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesignPattern.CarnivoreCombo
{
    internal class Gobi65Fry : IFry
    {
        public async Task<string> GetFryAsync() => await Task.FromResult("Here's your Gobi 65 fry");
    }
}
