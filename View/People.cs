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
    public partial class People : Form
    {
        DbContext _db;
        public People()
        {
            InitializeComponent();
            _db = DbContext.getInstance();
            _db.onError += (msg) =>
            {
                MessageBox.Show(msg);
            };
        }
        string fileName;
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            f.Filter = "db Files (*.xml) |*.xml";
            f.FileName = fileName;
            if (f.ShowDialog() == DialogResult.OK)
            {
                fileName = f.FileName;
                _db.Load(fileName);
                LoadPeopleToListBox();
            }

        }

        
            private void LoadPeopleToListBox()
            {
                listPeople.Items.Clear(); // Очистить элементы
                listPeople.Items.AddRange(_db.People.ToArray()); // Наполнить
            }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            var f = new SaveFileDialog();
            f.Filter = "db Files |*.xml";
            f.FileName = fileName;
            if (f.ShowDialog() == DialogResult.OK)
            {
                fileName = f.FileName;
                _db.Save(fileName);
            }

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Person p = new Person { Id = Guid.NewGuid() };
            var f = new PersonForm(p);

            if (f.ShowDialog() == DialogResult.OK)
            {
                _db.People.Add(p);
                LoadPeopleToListBox();
            }
        }

        private void listPeople_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите имя и фамилию пользователя");
            var f = new FormSaerchUser();
            f.Show();
            DbContext db = DbContext.getInstance();
            //db.Load();
        }
    }
}
