using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

using ApplicationLogic.Interfaces;

using ComputerSalon.Abstraction;

using ComputerSalon.Presenters;
using Models;

namespace ComputerSalon
{
    public partial class SystemBlockForm: Form, ISystemBlockView
    {
        private SystemBlockPresenter presenter;
        private IDictionary<ComponentType, ListBox> boxes;

        public SystemBlockForm()
        {
            InitializeComponent();
        }

        public void ShowErrorMessage(String title, String message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccessMessage(String title, String message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateData(IComponentsHolder holder)
        {
            boxes[ComponentType.MemoryCard].DataSource = holder.MemoryCards;
            boxes[ComponentType.Motherboard].DataSource = holder.Motherboards;
            boxes[ComponentType.PowerSupply].DataSource = holder.PowerSuppliers;
            boxes[ComponentType.Processor].DataSource = holder.Processors;
            boxes[ComponentType.SystemBlockHull].DataSource = holder.SystemBlockHulls;
        }

        public int GetComponentSelectedIndex(ComponentType type)
        {
            return boxes[type].SelectedIndex;
        }

        private void CheckSystemBlock(object sender, EventArgs e)
        {
            presenter.Check();
        }

        private void FormLoads(object sender, EventArgs e)
        {
            boxes = new Dictionary<ComponentType, ListBox>();

            boxes[ComponentType.MemoryCard] = lbMemoryCards;
            boxes[ComponentType.Motherboard] = lbMotherboards;
            boxes[ComponentType.PowerSupply] = lbPowerSuppliers;
            boxes[ComponentType.Processor] = lbProcessors;
            boxes[ComponentType.SystemBlockHull] = lbSystemBlocks;

            presenter = new SystemBlockPresenter(this);
        }

        public IList<SystemComponentBase> GetSelectedComponents()
        {
            IList<SystemComponentBase> components = new List<SystemComponentBase>();

            foreach (ComponentType componentType in Enum.GetValues(typeof(ComponentType)))
                foreach (object component in boxes[componentType].SelectedItems)
                    components.Add((SystemComponentBase)component);

            return components;
        }
    }
}
