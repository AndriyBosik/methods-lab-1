using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationLogic.Interfaces;
using Data;
using DataAccess.Abstraction;

using Mappers;
using Mappers.Abstraction;
using Models;

namespace ApplicationLogic.Services
{
    public class SystemBlockService : ISystemBlockService
    {
        private IUnitOfWork unitOfWork;
        private IMapper<Data.SystemBlock, Models.SystemBlock> mapper;

        public SystemBlockService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = new SystemBlockMapper();
        }

        public async Task<IList<Models.SystemBlock>> GetSystemBlocksAsync()
        {
            IList<Data.SystemBlock> systemBlocks = await unitOfWork.SystemBlockRepository.ReadAllWithComponentsAsync();
            IList<Models.SystemBlock> answer = new List<Models.SystemBlock>();

            foreach (Data.SystemBlock systemBlock in systemBlocks)
            {
                Models.SystemBlock sb = new Models.SystemBlock
                {
                    Title = systemBlock.Title
                };
                
                foreach (SystemBlockComponent component in systemBlock.SystemBlockComponents)
                {
                    sb.Components.Add(MapToComponent(component.Component));
                }

                answer.Add(sb);
            }

            return answer;
        }

        public void Save(Models.SystemBlock systemBlock)
        {
            unitOfWork.SystemBlockRepository.CreateAsync(mapper.MapToEntity(systemBlock));
            unitOfWork.SaveAsync();
        }

        private SystemComponentBase MapToComponent(Component component)
        {
            switch ((ComponentType)component.TypeId)
            {
                case ComponentType.MemoryCard:
                    IComponentMapper<MemoryCard> memoryCardMapper = new MemoryCardMapper();
                    return memoryCardMapper.Map(component);
                case ComponentType.Motherboard:
                    IComponentMapper<Motherboard> motherboardMapper = new MotherboardMapper();
                    return motherboardMapper.Map(component);
                case ComponentType.Processor:
                    IComponentMapper<Processor> processorMapper = new ProcessorMapper();
                    return processorMapper.Map(component);
                case ComponentType.PowerSupply:
                    IComponentMapper<PowerSupply> powerSupplyMapper = new PowerSupplyMapper();
                    return powerSupplyMapper.Map(component);
                case ComponentType.SystemBlockHull:
                    IComponentMapper<SystemBlockHull> systemBlockHullMapper = new SystemBlockHullMapper();
                    return systemBlockHullMapper.Map(component);
                default:
                    return null;
            }
        }
    }
}
