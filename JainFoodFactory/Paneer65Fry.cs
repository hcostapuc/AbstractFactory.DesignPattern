using AbstractFactory.DesignPattern.AbstractFactoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesignPattern.JainFood
{
    internal class Paneer65Fry : IFry
    {
        public async Task<string> GetFryAsync() => await Task.FromResult("Here's your Paneer 65 fry");
    }
}
