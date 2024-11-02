using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesignPattern.AbstractFactoryInterfaces
{
    internal interface IFoodComboFactory
    {
        Task<IRice> CreateRiceAsync();
        Task<IGravy> CreateGravyAsync();
        Task<IFry> CreateFryAsync();
    }
}
