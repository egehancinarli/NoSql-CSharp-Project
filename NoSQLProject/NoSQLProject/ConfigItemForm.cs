using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Model;
using Service;

namespace NoSQLProject
{
    public partial class ConfigItemForm : Form
    {
        readonly ConfigurationItem_Service configItemService = new ConfigurationItem_Service();
        private ConfigurationItem ci;

        public ConfigItemForm()
        {
            InitializeComponent();
        }

        public ConfigItemForm(ConfigurationItem ci)
        {
            InitializeComponent();
            this.ci = ci;
        }

        private void buttonAddConfigItem_Click(object sender, EventArgs e)
        {
            if (textBoxCIName.Text.Equals("") || textBoxCIDescription.Text.Equals("") ||
                comboBoxOwner.SelectedItem == null || textBoxLocation.Text.Equals("") ||
                comboBoxImportance.SelectedItem == null) //Check if all fields are filled
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            if (ci == null) // if null then new CI
            {
                ci = new ConfigurationItem(textBoxCIName.Text, textBoxCIDescription.Text,
                   Int32.Parse(comboBoxOwner.SelectedValue.ToString()),
                    textBoxLocation.Text,
                    (TicketPriorityType)comboBoxImportance.SelectedIndex);
            }
            else // Else editing
            {
                ci.Name = textBoxCIName.Text;
                ci.Description = textBoxCIDescription.Text;
                ci.Owner = Int32.Parse(comboBoxOwner.SelectedValue.ToString());
                ci.Location = textBoxLocation.Text;
                ci.Importance = (TicketPriorityType)comboBoxImportance.SelectedIndex;
            }


            if (buttonAddConfigItem.Text.Equals("Update"))
            {
                configItemService.UpdateConfigItem(ci);
            }
            else
            {
                configItemService.AddConfigItem(ci);
            }

            MessageBox.Show($"Configuration Item Added\n{ci.ToString()}"); // Successfully added

            ConfigItemUi ciForm = (ConfigItemUi)Application.OpenForms["ConfigItemUI"];// Update the List in Original Form
            ciForm.UpdateList();
            this.Close();
        }

        private void ConfigItemForm_Load(object sender, EventArgs e)
        {
            User_Service userService = new User_Service();
            List<User> userList = userService.getAllUsers();

            DataTable comboDataTable = new DataTable("users");
            comboDataTable.Columns.Add("id");
            comboDataTable.Columns.Add("Name");

            foreach (User user in userList)
            {
                string name = $"{user.firstName} {user.lastName}";
                DataRow dr = comboDataTable.NewRow();
                dr["id"] = user.id;
                dr["name"] = name;
                comboDataTable.Rows.Add(dr);
            }

            //Only Show Name but linked to ID
            comboBoxOwner.DataSource = comboDataTable;
            comboBoxOwner.DisplayMember = "Name";
            comboBoxOwner.ValueMember = "id"; //
            comboBoxOwner.SelectedValue = 0;

            comboBoxImportance.Items.Add(TicketPriorityType.Low);
            comboBoxImportance.Items.Add(TicketPriorityType.Normal);
            comboBoxImportance.Items.Add(TicketPriorityType.High);
            comboBoxImportance.SelectedIndex = 0;

            if (ci != null)
            {
                buttonAddConfigItem.Text = "Update";
                this.Text = "Edit Configuration Item";
                textBoxCIDescription.Text = ci.Description;
                textBoxCIName.Text = ci.Name;
                textBoxLocation.Text = ci.Location;
                comboBoxImportance.SelectedIndex = (int)ci.Importance;
                comboBoxOwner.SelectedValue = ci.Owner;
            }
            else
            {
                buttonAddConfigItem.Text = "Add";
                this.Text = "Ädd New Configuration Item";
            }
        }

        private void comboBoxOwner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}