using Questionnaire.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire.View
{
    public partial class PersonForm : Form
    {
        public Person Person { get; set; }

        public PersonForm(Person person)
        {
            InitializeComponent();
            this.Person = person;
            textBoxFirstName.Text = Person.FirstName;
            textBoxSecondName.Text = Person.SecondName;
            listBoxPhones.Items.AddRange(person.Phones.ToArray());
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Person.FirstName = textBoxFirstName.Text;
            this.Person.SecondName = textBoxSecondName.Text;

            this.Person.Phones.Clear();
            foreach (var s in listBoxPhones.Items)
            {
                this.Person.Phones.Add(s.ToString());
            }

            this.Hide();
        
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSavePhone_Click(object sender, EventArgs e)
        {
            listBoxPhones.Items.Add(textBoxPhone.Text);
        }

        private void buttonDeletePhone_Click(object sender, EventArgs e)
        {
            if (listBoxPhones.SelectedItem != null)
            {
                listBoxPhones.Items.Remove(listBoxPhones.SelectedItem);
            }
        }
    }
}
