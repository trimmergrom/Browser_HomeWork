using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Browser_HomeWork
{
    public partial class FormSetting : Form
    {
        public SearchEngin searchEngin { get; set; }
        public string engineURL
        {
            get { return comboBoxSearch.SelectedItem.ToString(); }
        }
        public string homeURL
        {
            get { return textBoxHomeURL.Text; }
        }
        //public FormSetting()
        //{
        //    InitializeComponent();
        //}
        public FormSetting()
        {
            InitializeComponent();

            if (File.Exists("search.txt"))
            {
                Load();
            }
            else MessageBox.Show("No File");
            textBoxHomeURL.Text = searchEngin.homeURL;
            comboBoxSearch.Text = searchEngin.searchURL;
            

        }

        //public DialogResult ShowDialog(string s)
        //{
        //    textBoxHomeURL.Text = s;            
        //    return ShowDialog();
        //}
        //public DialogResult ShowDialog1(string c)
        //{            
        //    comboBoxSearch.SelectedItem = c;
        //    return ShowDialog();
        //}
        public new SearchEngin ShowDialog()
        {
            base.ShowDialog();
            return searchEngin;
        }
        void Save()
        {
            string str = searchEngin.ToString();
            File.WriteAllText("search.txt", str);
        }
        public SearchEngin Load()
        {
            searchEngin = new SearchEngin();
            var str = File.ReadAllText("search.txt");
            string[] search = str.Split(' ');
            searchEngin.homeURL = search[0];
            searchEngin.searchURL = search[1];
            return searchEngin;
        }

        private void buttonSAVE_Click(object sender, EventArgs e)
        {
            searchEngin = new SearchEngin();
            DialogResult = DialogResult.OK;
            searchEngin.homeURL = textBoxHomeURL.Text;
            switch(comboBoxSearch.SelectedItem.ToString())
            {
                case "Google":                
                    searchEngin.searchURL = "https://google.com/";
                    break;
                case "Yandex":                
                    searchEngin.searchURL = "https://yandex.ru/";
                    break;
                case "Mail":                
                    searchEngin.searchURL = "https://mail.ru/";
                    break;
            }
            Save();
            this.Close();
;       }

        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        
    }
}
