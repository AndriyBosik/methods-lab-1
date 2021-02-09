using ComputerSalon.Models;

namespace ComputerSalon
{
    interface IDataReader
    {
        MemoryCard GetMemoryCard();

        Motherboard GetMotherboard();

        PowerSupply GetPowerSupply();

        Processor GetProcessor();

        SystemBlockHull GetSystemBlockHull();
    }
}
