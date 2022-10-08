
namespace Gestion_Bibliothèque
{
    partial class GestionEmprunt
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
            this.search = new MetroSet_UI.Controls.MetroSetTextBox();
            this.clearbtn = new MetroSet_UI.Controls.MetroSetButton();
            this.empruntList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.deletebtn = new MetroSet_UI.Controls.MetroSetButton();
            this.retourbtn = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.AutoCompleteCustomSource = null;
            this.search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.search.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.search.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.search.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.search.Image = null;
            this.search.IsDerivedStyle = true;
            this.search.Lines = null;
            this.search.Location = new System.Drawing.Point(449, 94);
            this.search.MaxLength = 32767;
            this.search.Multiline = false;
            this.search.Name = "search";
            this.search.ReadOnly = false;
            this.search.Size = new System.Drawing.Size(210, 38);
            this.search.Style = MetroSet_UI.Enums.Style.Light;
            this.search.StyleManager = null;
            this.search.TabIndex = 46;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search.ThemeAuthor = "Narwin";
            this.search.ThemeName = "MetroLite";
            this.search.UseSystemPasswordChar = false;
            this.search.WatermarkText = "Chercher un emprunt";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // clearbtn
            // 
            this.clearbtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.clearbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.clearbtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearbtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.clearbtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.clearbtn.HoverTextColor = System.Drawing.Color.White;
            this.clearbtn.IsDerivedStyle = true;
            this.clearbtn.Location = new System.Drawing.Point(836, 633);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.clearbtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.clearbtn.NormalTextColor = System.Drawing.Color.White;
            this.clearbtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.clearbtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.clearbtn.PressTextColor = System.Drawing.Color.White;
            this.clearbtn.Size = new System.Drawing.Size(167, 49);
            this.clearbtn.Style = MetroSet_UI.Enums.Style.Light;
            this.clearbtn.StyleManager = null;
            this.clearbtn.TabIndex = 41;
            this.clearbtn.Text = "Vider";
            this.clearbtn.ThemeAuthor = "Narwin";
            this.clearbtn.ThemeName = "MetroLite";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // empruntList
            // 
            this.empruntList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader5});
            this.empruntList.FullRowSelect = true;
            this.empruntList.HideSelection = false;
            this.empruntList.Location = new System.Drawing.Point(43, 178);
            this.empruntList.MultiSelect = false;
            this.empruntList.Name = "empruntList";
            this.empruntList.Size = new System.Drawing.Size(1106, 401);
            this.empruntList.TabIndex = 40;
            this.empruntList.UseCompatibleStateImageBehavior = false;
            this.empruntList.View = System.Windows.Forms.View.Details;
            this.empruntList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.empruntList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adherant";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ouvrage";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Début";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date Fin";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Retourné?";
            this.columnHeader5.Width = 150;
            // 
            // deletebtn
            // 
            this.deletebtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deletebtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deletebtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.deletebtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.deletebtn.HoverTextColor = System.Drawing.Color.White;
            this.deletebtn.IsDerivedStyle = true;
            this.deletebtn.Location = new System.Drawing.Point(504, 633);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deletebtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.deletebtn.NormalTextColor = System.Drawing.Color.White;
            this.deletebtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.deletebtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.deletebtn.PressTextColor = System.Drawing.Color.White;
            this.deletebtn.Size = new System.Drawing.Size(167, 49);
            this.deletebtn.Style = MetroSet_UI.Enums.Style.Light;
            this.deletebtn.StyleManager = null;
            this.deletebtn.TabIndex = 39;
            this.deletebtn.Text = "Supprimer";
            this.deletebtn.ThemeAuthor = "Narwin";
            this.deletebtn.ThemeName = "MetroLite";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // retourbtn
            // 
            this.retourbtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.retourbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.retourbtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.retourbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.retourbtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.retourbtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.retourbtn.HoverTextColor = System.Drawing.Color.White;
            this.retourbtn.IsDerivedStyle = true;
            this.retourbtn.Location = new System.Drawing.Point(196, 633);
            this.retourbtn.Name = "retourbtn";
            this.retourbtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.retourbtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.retourbtn.NormalTextColor = System.Drawing.Color.White;
            this.retourbtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.retourbtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.retourbtn.PressTextColor = System.Drawing.Color.White;
            this.retourbtn.Size = new System.Drawing.Size(167, 49);
            this.retourbtn.Style = MetroSet_UI.Enums.Style.Light;
            this.retourbtn.StyleManager = null;
            this.retourbtn.TabIndex = 37;
            this.retourbtn.Text = "Retourner";
            this.retourbtn.ThemeAuthor = "Narwin";
            this.retourbtn.ThemeName = "MetroLite";
            this.retourbtn.Click += new System.EventHandler(this.retourbtn_Click);
            // 
            // GestionEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1187, 758);
            this.Controls.Add(this.search);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.empruntList);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.retourbtn);
            this.Name = "GestionEmprunt";
            this.Text = "GestionEmprunt";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTextBox search;
        private MetroSet_UI.Controls.MetroSetButton clearbtn;
        private System.Windows.Forms.ListView empruntList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroSet_UI.Controls.MetroSetButton deletebtn;
        private MetroSet_UI.Controls.MetroSetButton retourbtn;
    }
}