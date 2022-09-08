using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Browser_HomeWork
{
    public partial class Favorites : Form
    {
        public string s { get { return listBoxFavorites.SelectedItem.ToString(); } }

        public Favorites()
        {
            InitializeComponent();
        }

        //public Favorites()
        //{
        //    InitializeComponent();


        //}
        public DialogResult ShowDialog(string s)
        {
            listBoxFavorites.Items.Add(s);
            return ShowDialog();
        }

        private void buttonCloseFavorites_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteFavorites_Click(object sender, EventArgs e)
        {
            if(listBoxFavorites.SelectedIndex > -1 && listBoxFavorites.SelectedItem!= null)
            {
                listBoxFavorites.Items.Remove(listBoxFavorites.SelectedItem);
            }
            else { MessageBox.Show("List favorites is empty"); }
        }

        private void buttonGoFavorites_Click(object sender, EventArgs e)
        {
            if (listBoxFavorites.SelectedItem != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("No selected favorit URL");
        }
    }
}
