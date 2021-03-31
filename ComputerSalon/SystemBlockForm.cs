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
        private IList<ListBox> boxes;

        public event Action ViewLoaded;
        public event Action QuitButtonClicked;
        public event Action CheckButtonClicked;

        public SystemBlockForm()
        {
            InitializeComponent();

            boxes = new List<ListBox>();

            presenter = new SystemBlockPresenter(this);

            ViewLoaded.Invoke();
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
            CheckButtonClicked.Invoke();
        }

        private void Quit(object sender, EventArgs e)
        {
            QuitButtonClicked.Invoke();
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
            this.Close();
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
