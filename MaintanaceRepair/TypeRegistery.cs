using StructureMap;

namespace MaintanaceRepair
{
    public class TypeRegistery : Registry
    {

        public TypeRegistery()
        {
            //For<ICustomReport>().Use<CustomReport>().Ctor<TruckersEntities>("db").Is(new TruckersEntities());

        }
    }
}