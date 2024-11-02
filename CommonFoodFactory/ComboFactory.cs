using AbstractFactory.DesignPattern.AbstractFactoryInterfaces;
using AbstractFactory.DesignPattern.CarnivoreFood;
using AbstractFactory.DesignPattern.JainFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesignPattern.CommonComboFood
{
    internal class ComboFactory : IComboFactory
    {
        public IFoodComboFactory Create(FoodComboType foodComboType)
         => foodComboType switch
            {

                FoodComboType.Carnivore => new CarnivoreComboFactory(),
                FoodComboType.Jain => new JainComboFactory(),
                _ => throw new NotImplementedException()

            };
    }
}