
namespace Gestion_Bibliothèque
{
    partial class GestionUsers
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
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.login = new MetroSet_UI.Controls.MetroSetTextBox();
            this.password = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.admin = new MetroSet_UI.Controls.MetroSetComboBox();
            this.addbtn = new MetroSet_UI.Controls.MetroSetButton();
            this.editbtn = new MetroSet_UI.Controls.MetroSetButton();
            this.deletebtn = new MetroSet_UI.Controls.MetroSetButton();
            this.usersList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.clearbtn = new MetroSet_UI.Controls.MetroSetButton();
            this.search = new MetroSet_UI.Controls.MetroSetTextBox();
            this.SuspendLayout();
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(36, 124);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(88, 29);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Login";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // login
            // 
            this.login.AutoCompleteCustomSource = null;
            this.login.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.login.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.login.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.login.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.login.Image = null;
            this.login.IsDerivedStyle = true;
            this.login.Lines = null;
            this.login.Location = new System.Drawing.Point(130, 118);
            this.login.MaxLength = 32767;
            this.login.Multiline = false;
            this.login.Name = "login";
            this.login.ReadOnly = false;
            this.login.Size = new System.Drawing.Size(169, 38);
            this.login.Style = MetroSet_UI.Enums.Style.Light;
            this.login.StyleManager = null;
            this.login.TabIndex = 2;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.login.ThemeAuthor = "Narwin";
            this.login.ThemeName = "MetroLite";
            this.login.UseSystemPasswordChar = false;
            this.login.WatermarkText = "Login";
            // 
            // password
            // 
            this.password.AutoCompleteCustomSource = null;
            this.password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.password.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.password.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.password.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.password.Image = null;
            this.password.IsDerivedStyle = true;
            this.password.Lines = null;
            this.password.Location = new System.Drawing.Point(501, 115);
            this.password.MaxLength = 32767;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.ReadOnly = false;
            this.password.Size = new System.Drawing.Size(169, 38);
            this.password.Style = MetroSet_UI.Enums.Style.Light;
            this.password.StyleManager = null;
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.ThemeAuthor = "Narwin";
            this.password.ThemeName = "MetroLite";
            this.password.UseSystemPasswordChar = false;
            this.password.WatermarkText = "Password";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(370, 124);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(125, 29);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 3;
            this.metroSetLabel2.Text = "Mot de passe";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(740, 124);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(125, 29);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 5;
            this.metroSetLabel3.Text = "Admin";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // admin
            // 
            this.admin.AllowDrop = true;
            this.admin.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.admin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.admin.CausesValidation = false;
            this.admin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.admin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.admin.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.admin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.admin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.admin.FormattingEnabled = true;
            this.admin.IsDerivedStyle = true;
            this.admin.ItemHeight = 20;
            this.admin.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.admin.Location = new System.Drawing.Point(871, 124);
            this.admin.Name = "admin";
            this.admin.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.admin.SelectedItemForeColor = System.Drawing.Color.White;
            this.admin.Size = new System.Drawing.Size(169, 26);
            this.admin.Style = MetroSet_UI.Enums.Style.Light;
            this.admin.StyleManager = null;
            this.admin.TabIndex = 6;
            this.admin.ThemeAuthor = "Narwin";
            this.admin.ThemeName = "MetroLite";
            // 
            // addbtn
            // 
            this.addbtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addbtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addbtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addbtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addbtn.HoverTextColor = System.Drawing.Color.White;
            this.addbtn.IsDerivedStyle = true;
            this.addbtn.Location = new System.Drawing.Point(203, 213);
            this.addbtn.Name = "addbtn";
            this.addbtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addbtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addbtn.NormalTextColor = System.Drawing.Color.White;
            this.addbtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addbtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addbtn.PressTextColor = System.Drawing.Color.White;
            this.addbtn.Size = new System.Drawing.Size(167, 49);
            this.addbtn.Style = MetroSet_UI.Enums.Style.Light;
            this.addbtn.StyleManager = null;
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Ajouter";
            this.addbtn.ThemeAuthor = "Narwin";
            this.addbtn.ThemeName = "MetroLite";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editbtn.DisabledForeColor = System.Drawing.Color.Gray;
            this.editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editbtn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.editbtn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.editbtn.HoverTextColor = System.Drawing.Color.White;
            this.editbtn.IsDerivedStyle = true;
            this.editbtn.Location = new System.Drawing.Point(446, 213);
            this.editbtn.Name = "editbtn";
            this.editbtn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editbtn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.editbtn.NormalTextColor = System.Drawing.Color.White;
            this.editbtn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.editbtn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.editbtn.PressTextColor = System.Drawing.Color.White;
            this.editbtn.Size = new System.Drawing.Size(167, 49);
            this.editbtn.Style = MetroSet_UI.Enums.Style.Light;
            this.editbtn.StyleManager = null;
            this.editbtn.TabIndex = 8;
            this.editbtn.Text = "Modifier";
            this.editbtn.ThemeAuthor = "Narwin";
            this.editbtn.ThemeName = "MetroLite";
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
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
            this.deletebtn.Location = new System.Drawing.Point(685, 213);
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
            this.deletebtn.TabIndex = 9;
            this.deletebtn.Text = "Supprimer";
            this.deletebtn.ThemeAuthor = "Narwin";
            this.deletebtn.ThemeName = "MetroLite";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // usersList
            // 
            this.usersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.usersList.FullRowSelect = true;
            this.usersList.HideSelection = false;
            this.usersList.Location = new System.Drawing.Point(212, 343);
            this.usersList.MultiSelect = false;
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(605, 360);
            this.usersList.TabIndex = 11;
            this.usersList.UseCompatibleStateImageBehavior = false;
            this.usersList.View = System.Windows.Forms.View.Details;
            this.usersList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usersList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Login";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mot de passe";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Admin?";
            this.columnHeader4.Width = 150;
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
            this.clearbtn.Location = new System.Drawing.Point(436, 709);
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
            this.clearbtn.TabIndex = 12;
            this.clearbtn.Text = "Vider";
            this.clearbtn.ThemeAuthor = "Narwin";
            this.clearbtn.ThemeName = "MetroLite";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
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
            this.search.Location = new System.Drawing.Point(436, 299);
            this.search.MaxLength = 32767;
            this.search.Multiline = false;
            this.search.Name = "search";
            this.search.ReadOnly = false;
            this.search.Size = new System.Drawing.Size(188, 38);
            this.search.Style = MetroSet_UI.Enums.Style.Light;
            this.search.StyleManager = null;
            this.search.TabIndex = 13;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search.ThemeAuthor = "Narwin";
            this.search.ThemeName = "MetroLite";
            this.search.UseSystemPasswordChar = false;
            this.search.WatermarkText = "Chercher un utilisateur";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // GestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 779);
            this.Controls.Add(this.search);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.metroSetLabel1);
            this.Name = "GestionUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionsUsers";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox login;
        private MetroSet_UI.Controls.MetroSetTextBox password;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetComboBox admin;
        private MetroSet_UI.Controls.MetroSetButton addbtn;
        private MetroSet_UI.Controls.MetroSetButton editbtn;
        private MetroSet_UI.Controls.MetroSetButton deletebtn;
        private System.Windows.Forms.ListView usersList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroSet_UI.Controls.MetroSetButton clearbtn;
        private MetroSet_UI.Controls.MetroSetTextBox search;
    }
}