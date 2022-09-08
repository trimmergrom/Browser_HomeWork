
namespace Browser_HomeWork
{
    partial class Favorites
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxFavorites = new System.Windows.Forms.ListBox();
            this.buttonGoFavorites = new System.Windows.Forms.Button();
            this.buttonDeleteFavorites = new System.Windows.Forms.Button();
            this.buttonCloseFavorites = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFavorites
            // 
            this.listBoxFavorites.BackColor = System.Drawing.Color.White;
            this.listBoxFavorites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFavorites.FormattingEnabled = true;
            this.listBoxFavorites.ItemHeight = 15;
            this.listBoxFavorites.Location = new System.Drawing.Point(0, 0);
            this.listBoxFavorites.Name = "listBoxFavorites";
            this.listBoxFavorites.Size = new System.Drawing.Size(545, 554);
            this.listBoxFavorites.TabIndex = 0;
            // 
            // buttonGoFavorites
            // 
            this.buttonGoFavorites.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoFavorites.Location = new System.Drawing.Point(13, 499);
            this.buttonGoFavorites.Name = "buttonGoFavorites";
            this.buttonGoFavorites.Size = new System.Drawing.Size(88, 32);
            this.buttonGoFavorites.TabIndex = 1;
            this.buttonGoFavorites.Text = "Go";
            this.buttonGoFavorites.UseVisualStyleBackColor = true;
            this.buttonGoFavorites.Click += new System.EventHandler(this.buttonGoFavorites_Click);
            // 
            // buttonDeleteFavorites
            // 
            this.buttonDeleteFavorites.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteFavorites.Location = new System.Drawing.Point(107, 499);
            this.buttonDeleteFavorites.Name = "buttonDeleteFavorites";
            this.buttonDeleteFavorites.Size = new System.Drawing.Size(88, 32);
            this.buttonDeleteFavorites.TabIndex = 2;
            this.buttonDeleteFavorites.Text = "Delete";
            this.buttonDeleteFavorites.UseVisualStyleBackColor = true;
            this.buttonDeleteFavorites.Click += new System.EventHandler(this.buttonDeleteFavorites_Click);
            // 
            // buttonCloseFavorites
            // 
            this.buttonCloseFavorites.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCloseFavorites.Location = new System.Drawing.Point(301, 499);
            this.buttonCloseFavorites.Name = "buttonCloseFavorites";
            this.buttonCloseFavorites.Size = new System.Drawing.Size(88, 32);
            this.buttonCloseFavorites.TabIndex = 3;
            this.buttonCloseFavorites.Text = "Close";
            this.buttonCloseFavorites.UseVisualStyleBackColor = true;
            this.buttonCloseFavorites.Click += new System.EventHandler(this.buttonCloseFavorites_Click);
            // 
            // Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(545, 554);
            this.Controls.Add(this.buttonCloseFavorites);
            this.Controls.Add(this.buttonDeleteFavorites);
            this.Controls.Add(this.buttonGoFavorites);
            this.Controls.Add(this.listBoxFavorites);
            this.Name = "Favorites";
            this.Text = "Favorites";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFavorites;
        private System.Windows.Forms.Button buttonGoFavorites;
        private System.Windows.Forms.Button buttonDeleteFavorites;
        private System.Windows.Forms.Button buttonCloseFavorites;
    }
}