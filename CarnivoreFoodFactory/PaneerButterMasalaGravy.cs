using AbstractFactory.DesignPattern.AbstractFactoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesignPattern.CarnivoreCombo
{
    internal class PaneerButterMasalaGravy : IGravy
    {
        public async Task<string> GetGravyAsync() => await Task.FromResult("Here's your Paneer Butter Masala gravy");
    }
}
