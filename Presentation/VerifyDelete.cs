using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingRover.Presentation
{
    public partial class VerifyDelete : Form
    {
        EditMovieForm parentForm;
        public VerifyDelete(EditMovieForm parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void ConfirmDeleteButton_Click(object sender, EventArgs e)
        {
            parentForm.Delete();
            this.Close();
        }

        private void CancelDeleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
