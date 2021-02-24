using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NoSQLProject
{
    public partial class ConfigItemUi : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private User user;

        public ConfigItemUi(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void NewConfigItem_Click(object sender, EventArgs e)
        {
            new ConfigItemForm().Show();
        }

        private void textBoxFilterCI_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFilterCI_Click(object sender, EventArgs e)
        {
            if (textBoxFilterCI.Text.Equals("Filter Items...")) textBoxFilterCI.Text = "";
        }

        private void ConfigItemUI_Load(object sender, EventArgs e)
        {
            UpdateList();
            textBoxFilterCI.Visible = false;
        }


        private void buttonEditConfigItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewConfigItem.SelectedRows.Count > 0)
            {
                //MessageBox.Show(dataGridViewConfigItem.SelectedRows[0].DataBoundItem.ToString());
                new ConfigItemForm((ConfigurationItem) dataGridViewConfigItem.SelectedRows[0].DataBoundItem).Show();
            }
            else
            {
                MessageBox.Show("You must select a configuration item to edit");
            }
        }

        public void UpdateList()
        {
            bindingSource.Clear();
            var ciService = new ConfigurationItem_Service();
            foreach (var configItem in ciService.GetAllConfigItems())
            {
                bindingSource.Add(configItem);
            }
            dataGridViewConfigItem.DataSource = bindingSource;
        }

        private void dataGridViewConfigItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigItemUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard(user).Show();
        }
    }
}