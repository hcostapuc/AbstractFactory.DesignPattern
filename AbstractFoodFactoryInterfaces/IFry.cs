using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesignPattern.AbstractFactoryInterfaces
{
    internal interface IFry
    {
        Task<string> GetFryAsync();
    }
}
