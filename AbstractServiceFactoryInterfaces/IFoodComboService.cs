using AbstractFactory.DesignPattern.CommonComboFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesignPattern.AbstractServiceFactoryInterfaces
{
    internal interface IFoodComboService
    {
        Task Serve(FoodComboType foodComboType);
    }
}