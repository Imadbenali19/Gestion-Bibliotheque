
namespace Gestion_Bibliothèque
{
    partial class GestionAdherant
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
            this.tel = new MetroSet_UI.Controls.MetroSetTextBox();
            this.clearbtn = new MetroSet_UI.Controls.MetroSetButton();
            this.adherantList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.deletebtn = new MetroSet_UI.Controls.MetroSetButton();
            this.editbtn = new MetroSet_UI.Controls.MetroSetButton();
            this.addbtn = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cin = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.fullname = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.email = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
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
            this.search.Location = new System.Drawing.Point(77, 248);
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
            this.search.WatermarkText = "Chercher un adherant";
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // tel
            // 
            this.tel.AutoCompleteCustomSource = null;
            this.tel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.tel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tel.Image = null;
            this.tel.IsDerivedStyle = true;
            this.tel.Lines = null;
            this.tel.Location = new System.Drawing.Point(916, 91);
            this.tel.MaxLength = 32767;
            this.tel.Multiline = false;
            this.tel.Name = "tel";
            this.tel.ReadOnly = false;
            this.tel.Size = new System.Drawing.Size(195, 38);
            this.tel.Style = MetroSet_UI.Enums.Style.Light;
            this.tel.StyleManager = null;
            this.tel.TabIndex = 42;
            this.tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tel.ThemeAuthor = "Narwin";
            this.tel.ThemeName = "MetroLite";
            this.tel.UseSystemPasswordChar = false;
            this.tel.WatermarkText = "N°Tel de l\'adherant";
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
            this.clearbtn.Location = new System.Drawing.Point(819, 610);
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
            // adherantList
            // 
            this.adherantList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8});
            this.adherantList.FullRowSelect = true;
            this.adherantList.HideSelection = false;
            this.adherantList.Location = new System.Drawing.Point(77, 292);
            this.adherantList.MultiSelect = false;
            this.adherantList.Name = "adherantList";
            this.adherantList.Size = new System.Drawing.Size(705, 367);
            this.adherantList.TabIndex = 40;
            this.adherantList.UseCompatibleStateImageBehavior = false;
            this.adherantList.View = System.Windows.Forms.View.Details;
            this.adherantList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.adherantList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FullName";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CIN";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "N°Tel";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email";
            this.columnHeader8.Width = 150;
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
            this.deletebtn.Location = new System.Drawing.Point(819, 443);
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
            this.editbtn.Location = new System.Drawing.Point(819, 365);
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
            this.editbtn.TabIndex = 38;
            this.editbtn.Text = "Modifier";
            this.editbtn.ThemeAuthor = "Narwin";
            this.editbtn.ThemeName = "MetroLite";
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
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
            this.addbtn.Location = new System.Drawing.Point(819, 292);
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
            this.addbtn.TabIndex = 37;
            this.addbtn.Text = "Ajouter";
            this.addbtn.ThemeAuthor = "Narwin";
            this.addbtn.ThemeName = "MetroLite";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(785, 100);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(125, 29);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 36;
            this.metroSetLabel3.Text = "Telephone";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // cin
            // 
            this.cin.AutoCompleteCustomSource = null;
            this.cin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cin.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cin.Image = null;
            this.cin.IsDerivedStyle = true;
            this.cin.Lines = null;
            this.cin.Location = new System.Drawing.Point(520, 91);
            this.cin.MaxLength = 32767;
            this.cin.Multiline = false;
            this.cin.Name = "cin";
            this.cin.ReadOnly = false;
            this.cin.Size = new System.Drawing.Size(169, 38);
            this.cin.Style = MetroSet_UI.Enums.Style.Light;
            this.cin.StyleManager = null;
            this.cin.TabIndex = 35;
            this.cin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cin.ThemeAuthor = "Narwin";
            this.cin.ThemeName = "MetroLite";
            this.cin.UseSystemPasswordChar = false;
            this.cin.WatermarkText = "CIN de l\'adherant";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(440, 100);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(74, 29);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 34;
            this.metroSetLabel2.Text = "CIN";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // fullname
            // 
            this.fullname.AutoCompleteCustomSource = null;
            this.fullname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.fullname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.fullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.fullname.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fullname.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.fullname.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullname.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.fullname.Image = null;
            this.fullname.IsDerivedStyle = true;
            this.fullname.Lines = null;
            this.fullname.Location = new System.Drawing.Point(156, 91);
            this.fullname.MaxLength = 32767;
            this.fullname.Multiline = false;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = false;
            this.fullname.Size = new System.Drawing.Size(227, 38);
            this.fullname.Style = MetroSet_UI.Enums.Style.Light;
            this.fullname.StyleManager = null;
            this.fullname.TabIndex = 33;
            this.fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fullname.ThemeAuthor = "Narwin";
            this.fullname.ThemeName = "MetroLite";
            this.fullname.UseSystemPasswordChar = false;
            this.fullname.WatermarkText = "Nom Complet de l\'adherant";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(25, 100);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(125, 29);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 32;
            this.metroSetLabel1.Text = "Nom Complet";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // email
            // 
            this.email.AutoCompleteCustomSource = null;
            this.email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.email.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.email.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.email.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.email.Image = null;
            this.email.IsDerivedStyle = true;
            this.email.Lines = null;
            this.email.Location = new System.Drawing.Point(520, 153);
            this.email.MaxLength = 32767;
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.ReadOnly = false;
            this.email.Size = new System.Drawing.Size(169, 38);
            this.email.Style = MetroSet_UI.Enums.Style.Light;
            this.email.StyleManager = null;
            this.email.TabIndex = 48;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.ThemeAuthor = "Narwin";
            this.email.ThemeName = "MetroLite";
            this.email.UseSystemPasswordChar = false;
            this.email.WatermarkText = "Email de l\'adherant";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(440, 162);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(74, 29);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 47;
            this.metroSetLabel4.Text = "Email";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // GestionAdherant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1122, 690);
            this.Controls.Add(this.email);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.search);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.adherantList);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.metroSetLabel1);
            this.Name = "GestionAdherant";
            this.Text = "GestionAdherant";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTextBox search;
        private MetroSet_UI.Controls.MetroSetTextBox tel;
        private MetroSet_UI.Controls.MetroSetButton clearbtn;
        private System.Windows.Forms.ListView adherantList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MetroSet_UI.Controls.MetroSetButton deletebtn;
        private MetroSet_UI.Controls.MetroSetButton editbtn;
        private MetroSet_UI.Controls.MetroSetButton addbtn;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox cin;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox fullname;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox email;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
    }
}