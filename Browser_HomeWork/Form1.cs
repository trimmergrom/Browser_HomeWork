using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser_HomeWork
{

    public partial class Browser : Form
    {
        public SearchEngin searchEngin { get; set; }
        public int count { get; set; } = 0;
        public string favor
        {
            get; set; }
        public List<string> history { get; set; } = new List<string>(); 
        public Browser()
        {
            InitializeComponent();
            if (File.Exists("search.txt")) Load();
            //int count = tabControlView.TabCount;
            TabPage tabPage = new TabPage($"New Tab({++count})");
            WebBrowser web = new WebBrowser();
            web.Navigated += Web_Navigated;
            web.Url = new Uri(searchEngin.searchURL);
            web.Dock = DockStyle.Fill;
            tabPage.Controls.Add(web);
            tabControlView.TabPages.Add(tabPage);
            tabControlView.SelectedIndex = count - 1;
            
        }

        private void Web_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WebBrowser webBrowser = sender as WebBrowser;
            listBoxHistory.Items.Add(webBrowser.Url);
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Load();
            int count = tabControlView.TabCount;
            TabPage tabPage = new TabPage($"New Tab({++count})");
            WebBrowser web = new WebBrowser();
            web.Navigated += Web_Navigated;
            web.Url = new Uri(searchEngin.searchURL);
            web.Dock = DockStyle.Fill;
            tabPage.Controls.Add(web);
            tabControlView.TabPages.Add(tabPage);
            tabControlView.SelectedIndex = count -1;            
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            int count = tabControlView.TabCount;
            if(count > 1)
            {
                int indexRemove = tabControlView.SelectedIndex;
                tabControlView.Controls.RemoveAt(indexRemove);
            }
            else
            {
                var result = MessageBox.Show("You want to exit?", "Exit", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (splitContainerView.Panel2Collapsed == true) splitContainerView.Panel2Collapsed = false;
            else if (splitContainerView.Panel2Collapsed == false) splitContainerView.Panel2Collapsed = true;
        }

        private void buttonParam_Click(object sender, EventArgs e)
        {
            var formSetting = new FormSetting();            
            formSetting.ShowDialog();
        }

        private void buttonFavoritsList_Click(object sender, EventArgs e)
        {
            string str = File.ReadAllText("favorits.txt");
            string[] strlist = str.Split(' ');
            string st = null;
            var Favorites = new Favorites();
            for(int i = 0; i < strlist.Length; i++)
            {
                st += strlist[i] + "\n";
            }

                Favorites.ShowDialog(st);
            //Favorites.ShowDialog(listBoxHistory.SelectedItem.ToString());
            //Favorites.ShowDialog(str);
        }


        private void buttonFavoritsAdd_Click(object sender, EventArgs e)
        {
            string str = listBoxHistory.SelectedItem.ToString();
            if (listBoxHistory.SelectedItem != null)
            {
                favotitsSave(str);
                //var Favorites = new Favorites();                
                //Favorites.ShowDialog(listBoxHistory.SelectedItem.ToString());
            }           
        }
        private void favotitsSave(string value)
        {
            if (File.Exists("favorits.txt"))
            {
                File.AppendAllText("favorits.txt", value+" ");
            }
            else
            {
                File.Create("favorits.txt");
                File.AppendAllText("favorits.txt", value+" ");
            }
        }

        private void buttonHomeURL_Click(object sender, EventArgs e)
        {
            searchEngin = new SearchEngin();
            Load();
            int count = tabControlView.TabCount;
            TabPage tabPage = new TabPage($"New Tab({++count})");
            WebBrowser web = new WebBrowser();
            web.Navigated += Web_Navigated;
            web.Url = new Uri(searchEngin.homeURL);
            web.Dock = DockStyle.Fill;
            tabPage.Controls.Add(web);
            tabControlView.TabPages.Add(tabPage);
            tabControlView.SelectedIndex = count - 1;            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //searchEngin = new SearchEngin();
            //Load();
            var index = tabControlView.SelectedIndex;
            var page = tabControlView.Controls[index];
            var web = page.Controls[0] as WebBrowser;
            
            web.Url = new Uri($"{searchEngin.searchURL}search?text={textBoxSearchWEB.Text}");
            //web.Url = new Uri($"{searchEngin.searchURL}search?q={textBoxSearchWEB.Text}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxHistory.SelectedIndex > -1 && listBoxHistory.SelectedItem != null)
            {
                listBoxHistory.Items.Remove(listBoxHistory.SelectedItem);
            }
            else { MessageBox.Show("List history is empty"); }
        }
    }
}
