
namespace Browser_HomeWork
{
    partial class FormSetting
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
            this.labelHomeURL = new System.Windows.Forms.Label();
            this.labelClearHystory = new System.Windows.Forms.Label();
            this.labelSearchEngine = new System.Windows.Forms.Label();
            this.textBoxHomeURL = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHomeURL
            // 
            this.labelHomeURL.AutoSize = true;
            this.labelHomeURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHomeURL.Location = new System.Drawing.Point(26, 23);
            this.labelHomeURL.Name = "labelHomeURL";
            this.labelHomeURL.Size = new System.Drawing.Size(85, 21);
            this.labelHomeURL.TabIndex = 0;
            this.labelHomeURL.Text = "Home URL";
            // 
            // labelClearHystory
            // 
            this.labelClearHystory.AutoSize = true;
            this.labelClearHystory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClearHystory.Location = new System.Drawing.Point(26, 111);
            this.labelClearHystory.Name = "labelClearHystory";
            this.labelClearHystory.Size = new System.Drawing.Size(100, 21);
            this.labelClearHystory.TabIndex = 1;
            this.labelClearHystory.Text = "Clear History";
            // 
            // labelSearchEngine
            // 
            this.labelSearchEngine.AutoSize = true;
            this.labelSearchEngine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearchEngine.Location = new System.Drawing.Point(26, 65);
            this.labelSearchEngine.Name = "labelSearchEngine";
            this.labelSearchEngine.Size = new System.Drawing.Size(108, 21);
            this.labelSearchEngine.TabIndex = 2;
            this.labelSearchEngine.Text = "Search Engine";
            // 
            // textBoxHomeURL
            // 
            this.textBoxHomeURL.Location = new System.Drawing.Point(142, 23);
            this.textBoxHomeURL.Name = "textBoxHomeURL";
            this.textBoxHomeURL.Size = new System.Drawing.Size(348, 23);
            this.textBoxHomeURL.TabIndex = 3;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Google",
            "Yandex",
            "Mail"});
            this.comboBoxSearch.Location = new System.Drawing.Point(142, 62);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(348, 23);
            this.comboBoxSearch.TabIndex = 4;
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearHistory.Location = new System.Drawing.Point(142, 108);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(348, 34);
            this.buttonClearHistory.TabIndex = 5;
            this.buttonClearHistory.Text = "CLEAR";
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSAVE.Location = new System.Drawing.Point(377, 159);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(112, 30);
            this.buttonSAVE.TabIndex = 6;
            this.buttonSAVE.Text = "SAVE";
            this.buttonSAVE.UseVisualStyleBackColor = true;
            this.buttonSAVE.Click += new System.EventHandler(this.buttonSAVE_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 203);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.textBoxHomeURL);
            this.Controls.Add(this.labelSearchEngine);
            this.Controls.Add(this.labelClearHystory);
            this.Controls.Add(this.labelHomeURL);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHomeURL;
        private System.Windows.Forms.Label labelClearHystory;
        private System.Windows.Forms.Label labelSearchEngine;
        private System.Windows.Forms.TextBox textBoxHomeURL;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.Button buttonSAVE;
    }
}