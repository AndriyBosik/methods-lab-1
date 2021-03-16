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
        private ISystemBlockPresenter presenter;
        private IList<ListBox> boxes;

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

        private void CheckSystemBlock(object sender, EventArgs e)
        {
            presenter.Check();
        }

        private void Quit(object sender, EventArgs e)
        {
            presenter.FinishApp();
        }

        public void ShowComponents<T>(IList<T> components) where T: SystemComponentBase
        {
            ListBox box = new ListBox();
            box.Width = 350;
            box.DataSource = components;
            box.SelectionMode = SelectionMode.MultiExtended;

            flpComponentsLayout.Controls.Add(box);

            boxes.Add(box);
        }

        public void Shutdown()
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FormLoads(object sender, EventArgs e)
        {
            boxes = new List<ListBox>();

            presenter = new SystemBlockPresenter(this);
        }

        public IList<SystemComponentBase> GetSelectedComponents()
        {
            IList<SystemComponentBase> components = new List<SystemComponentBase>();

            foreach (ListBox box in boxes)
                foreach (object component in box.SelectedItems)
                    components.Add((SystemComponentBase)component);

            return components;
        }
    }
}
