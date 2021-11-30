using AAServer.Application.Translation.FactoryTranslation;

namespace AAServer.Application.Translation
{
    public class AplicTranslation : IAplicTranslation
    {
        private readonly IFactoryObjectTranslation _factoryObjectTranslation;
        public AplicTranslation(IFactoryObjectTranslation factoryObjectTranslation)
        {
            _factoryObjectTranslation = factoryObjectTranslation;
        }
    }
}
