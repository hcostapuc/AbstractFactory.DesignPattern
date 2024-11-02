using AbstractFactory.DesignPattern.AbstractFactoryInterfaces;
using AbstractFactory.DesignPattern.AbstractServiceFactoryInterfaces;
using AbstractFactory.DesignPattern.CommonComboFood;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DesignPattern.FoodComboService
{
    internal class FoodComboService(IComboFactory comboFactory,
                                    ILogger logger) : IFoodComboService
    {
        private readonly IComboFactory _comboFactory = comboFactory ?? throw new ArgumentNullException(nameof(comboFactory));
        private readonly ILogger _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        public async Task Serve(FoodComboType foodComboType)
        {
            var foodCombo = _comboFactory.Create(foodComboType);

            var rice = await foodCombo.CreateRiceAsync();
            var gravy = await foodCombo.CreateGravyAsync();
            var fry = await foodCombo.CreateFryAsync();

            _logger.Information("Rice: {Rice}", await rice.GetRiceAsync());
            _logger.Information("Gravy: {Gravy}", await gravy.GetGravyAsync());
            _logger.Information("Fry: {Fry}", await fry.GetFryAsync());
        }
    }
}
