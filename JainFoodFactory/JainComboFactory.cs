using AbstractFactory.DesignPattern.AbstractFactoryInterfaces;

namespace AbstractFactory.DesignPattern.JainFood
{
    internal class JainComboFactory : IFoodComboFactory
    {
        public async Task<IFry> CreateFryAsync() => await Task.FromResult(new Paneer65Fry());
        public async Task<IGravy> CreateGravyAsync() => await Task.FromResult(new AlooGobiMasalaGravy());
        public async Task<IRice> CreateRiceAsync() => await Task.FromResult(new PulaoRice());
    }
}
