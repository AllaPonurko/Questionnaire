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
    public partial class FormSaerchUser : Form
    {
        public FormSaerchUser()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            var f = new OpenFileDialog();
            f.Filter = "db Files (*.xml) |*.xml";
            try
            {
                {
                    DbContext db = DbContext.getInstance();
                    db.People = db.Load(f.FileName);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    fileName = f.FileName;
            //    _db.Load(fileName);
            //    LoadPeopleToListBox();
            //}
            
        }
    }
}
