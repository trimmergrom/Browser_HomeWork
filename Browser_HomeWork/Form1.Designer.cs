
namespace Browser_HomeWork
{
    partial class Browser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.webControl2 = new EO.WinForm.WebControl();
            this.webControl1 = new EO.WinForm.WebControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearchWEB = new System.Windows.Forms.TextBox();
            this.buttonForvard = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonHomeURL = new System.Windows.Forms.Button();
            this.buttonFavoritsAdd = new System.Windows.Forms.Button();
            this.buttonFavoritsList = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonParam = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelet = new System.Windows.Forms.Button();
            this.splitContainerView = new System.Windows.Forms.SplitContainer();
            this.tabControlView = new System.Windows.Forms.TabControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDeleteHistory = new System.Windows.Forms.Button();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerView)).BeginInit();
            this.splitContainerView.Panel1.SuspendLayout();
            this.splitContainerView.Panel2.SuspendLayout();
            this.splitContainerView.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // webControl2
            // 
            this.webControl2.BackColor = System.Drawing.Color.White;
            this.webControl2.Location = new System.Drawing.Point(0, 0);
            this.webControl2.Name = "webControl2";
            this.webControl2.Size = new System.Drawing.Size(250, 250);
            this.webControl2.TabIndex = 0;
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(250, 250);
            this.webControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonForvard);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.buttonHomeURL);
            this.panel1.Controls.Add(this.buttonFavoritsAdd);
            this.panel1.Controls.Add(this.buttonFavoritsList);
            this.panel1.Controls.Add(this.buttonHistory);
            this.panel1.Controls.Add(this.buttonParam);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonDelet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxSearchWEB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(104, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 54);
            this.panel2.TabIndex = 12;
            // 
            // textBoxSearchWEB
            // 
            this.textBoxSearchWEB.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchWEB.Location = new System.Drawing.Point(0, 0);
            this.textBoxSearchWEB.Name = "textBoxSearchWEB";
            this.textBoxSearchWEB.Size = new System.Drawing.Size(483, 23);
            this.textBoxSearchWEB.TabIndex = 0;
            // 
            // buttonForvard
            // 
            this.buttonForvard.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonForvard.Location = new System.Drawing.Point(78, 0);
            this.buttonForvard.Name = "buttonForvard";
            this.buttonForvard.Size = new System.Drawing.Size(26, 54);
            this.buttonForvard.TabIndex = 11;
            this.buttonForvard.Text = "▶";
            this.buttonForvard.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Location = new System.Drawing.Point(52, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(26, 54);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "◀";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSearch.Image = global::Browser_HomeWork.Properties.Resources.icons8_magnifying_glass_tilted_right_48;
            this.buttonSearch.Location = new System.Drawing.Point(587, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(59, 54);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonHomeURL
            // 
            this.buttonHomeURL.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHomeURL.Image = ((System.Drawing.Image)(resources.GetObject("buttonHomeURL.Image")));
            this.buttonHomeURL.Location = new System.Drawing.Point(646, 0);
            this.buttonHomeURL.Name = "buttonHomeURL";
            this.buttonHomeURL.Size = new System.Drawing.Size(59, 54);
            this.buttonHomeURL.TabIndex = 6;
            this.buttonHomeURL.UseVisualStyleBackColor = true;
            this.buttonHomeURL.Click += new System.EventHandler(this.buttonHomeURL_Click);
            // 
            // buttonFavoritsAdd
            // 
            this.buttonFavoritsAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFavoritsAdd.Image = global::Browser_HomeWork.Properties.Resources.icons8_glowing_star_48;
            this.buttonFavoritsAdd.Location = new System.Drawing.Point(705, 0);
            this.buttonFavoritsAdd.Name = "buttonFavoritsAdd";
            this.buttonFavoritsAdd.Size = new System.Drawing.Size(58, 54);
            this.buttonFavoritsAdd.TabIndex = 5;
            this.buttonFavoritsAdd.UseVisualStyleBackColor = true;
            this.buttonFavoritsAdd.Click += new System.EventHandler(this.buttonFavoritsAdd_Click);
            // 
            // buttonFavoritsList
            // 
            this.buttonFavoritsList.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFavoritsList.Image = ((System.Drawing.Image)(resources.GetObject("buttonFavoritsList.Image")));
            this.buttonFavoritsList.Location = new System.Drawing.Point(763, 0);
            this.buttonFavoritsList.Name = "buttonFavoritsList";
            this.buttonFavoritsList.Size = new System.Drawing.Size(58, 54);
            this.buttonFavoritsList.TabIndex = 4;
            this.buttonFavoritsList.UseVisualStyleBackColor = true;
            this.buttonFavoritsList.Click += new System.EventHandler(this.buttonFavoritsList_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHistory.Image = global::Browser_HomeWork.Properties.Resources.icons8_open_book_emoji_481;
            this.buttonHistory.Location = new System.Drawing.Point(821, 0);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(56, 54);
            this.buttonHistory.TabIndex = 3;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonParam
            // 
            this.buttonParam.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonParam.Image = ((System.Drawing.Image)(resources.GetObject("buttonParam.Image")));
            this.buttonParam.Location = new System.Drawing.Point(877, 0);
            this.buttonParam.Margin = new System.Windows.Forms.Padding(6);
            this.buttonParam.Name = "buttonParam";
            this.buttonParam.Size = new System.Drawing.Size(59, 54);
            this.buttonParam.TabIndex = 2;
            this.buttonParam.UseVisualStyleBackColor = true;
            this.buttonParam.Click += new System.EventHandler(this.buttonParam_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdd.Location = new System.Drawing.Point(26, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(26, 54);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "➕";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelet
            // 
            this.buttonDelet.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDelet.Location = new System.Drawing.Point(0, 0);
            this.buttonDelet.Name = "buttonDelet";
            this.buttonDelet.Size = new System.Drawing.Size(26, 54);
            this.buttonDelet.TabIndex = 0;
            this.buttonDelet.Text = "➖";
            this.buttonDelet.UseVisualStyleBackColor = true;
            this.buttonDelet.Click += new System.EventHandler(this.buttonDelet_Click);
            // 
            // splitContainerView
            // 
            this.splitContainerView.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerView.Location = new System.Drawing.Point(0, 54);
            this.splitContainerView.Name = "splitContainerView";
            // 
            // splitContainerView.Panel1
            // 
            this.splitContainerView.Panel1.Controls.Add(this.tabControlView);
            // 
            // splitContainerView.Panel2
            // 
            this.splitContainerView.Panel2.Controls.Add(this.panel3);
            this.splitContainerView.Panel2.Controls.Add(this.listBoxHistory);
            this.splitContainerView.Size = new System.Drawing.Size(936, 472);
            this.splitContainerView.SplitterDistance = 782;
            this.splitContainerView.TabIndex = 1;
            // 
            // tabControlView
            // 
            this.tabControlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlView.Location = new System.Drawing.Point(0, 0);
            this.tabControlView.Name = "tabControlView";
            this.tabControlView.SelectedIndex = 0;
            this.tabControlView.Size = new System.Drawing.Size(782, 472);
            this.tabControlView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonDeleteHistory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 448);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 24);
            this.panel3.TabIndex = 1;
            // 
            // buttonDeleteHistory
            // 
            this.buttonDeleteHistory.BackColor = System.Drawing.Color.Aqua;
            this.buttonDeleteHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteHistory.Location = new System.Drawing.Point(0, 0);
            this.buttonDeleteHistory.Name = "buttonDeleteHistory";
            this.buttonDeleteHistory.Size = new System.Drawing.Size(150, 24);
            this.buttonDeleteHistory.TabIndex = 0;
            this.buttonDeleteHistory.Text = "Delete";
            this.buttonDeleteHistory.UseVisualStyleBackColor = false;
            this.buttonDeleteHistory.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 15;
            this.listBoxHistory.Location = new System.Drawing.Point(0, 0);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(150, 472);
            this.listBoxHistory.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(936, 526);
            this.Controls.Add(this.splitContainerView);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Browser";
            this.Text = "WEB_Browser";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainerView.Panel1.ResumeLayout(false);
            this.splitContainerView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerView)).EndInit();
            this.splitContainerView.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private EO.WinForm.WebControl webControl2;
        private EO.WinForm.WebControl webControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelet;
        private System.Windows.Forms.SplitContainer splitContainerView;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.TabControl tabControlView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonHomeURL;
        private System.Windows.Forms.Button buttonFavoritsAdd;
        private System.Windows.Forms.Button buttonFavoritsList;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonParam;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonForvard;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearchWEB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDeleteHistory;
    }
}

