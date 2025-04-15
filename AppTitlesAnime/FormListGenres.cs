using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTitlesAnime
{
    public partial class FormListGenres : Form
    {
        public FormListGenres()
        {
            InitializeComponent();
        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new FormAddGenre();
            formAddGenre.ShowDialog();
        }
    }
}
