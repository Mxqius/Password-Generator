namespace PasswordGenerator
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.bf_form = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.btn_generate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.seperator = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.lineVeryWeek = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.lineWeek = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.lineStrong = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_descTrackbar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_valueLength = new System.Windows.Forms.Label();
            this.txt_password = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btn_copyPassword = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btn_exit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tb_length = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.lowercaseCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.uppercaseCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.numbersCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.symbolsCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.excludeDuplicateCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.includeSpacesCheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.pnl_container = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.pnl_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // bf_form
            // 
            this.bf_form.BorderRadius = 10;
            this.bf_form.ContainerControl = this;
            this.bf_form.DockForm = false;
            this.bf_form.DockIndicatorTransparencyValue = 0.6D;
            this.bf_form.HasFormShadow = false;
            this.bf_form.ResizeForm = false;
            this.bf_form.TransparentWhileDrag = true;
            // 
            // btn_generate
            // 
            this.btn_generate.Animated = true;
            this.btn_generate.BackColor = System.Drawing.Color.Transparent;
            this.btn_generate.BorderRadius = 5;
            this.btn_generate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_generate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_generate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_generate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_generate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(189)))));
            this.btn_generate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.ForeColor = System.Drawing.Color.White;
            this.btn_generate.Location = new System.Drawing.Point(28, 397);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(384, 45);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "GENERATE PASSWORD";
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.Color.Transparent;
            this.seperator.FillThickness = 2;
            this.seperator.Location = new System.Drawing.Point(0, 55);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(441, 13);
            this.seperator.TabIndex = 1;
            // 
            // lineVeryWeek
            // 
            this.lineVeryWeek.BackColor = System.Drawing.Color.Transparent;
            this.lineVeryWeek.FillThickness = 5;
            this.lineVeryWeek.Location = new System.Drawing.Point(23, 130);
            this.lineVeryWeek.Name = "lineVeryWeek";
            this.lineVeryWeek.Size = new System.Drawing.Size(114, 13);
            this.lineVeryWeek.TabIndex = 1;
            // 
            // lineWeek
            // 
            this.lineWeek.BackColor = System.Drawing.Color.Transparent;
            this.lineWeek.FillThickness = 5;
            this.lineWeek.Location = new System.Drawing.Point(143, 130);
            this.lineWeek.Name = "lineWeek";
            this.lineWeek.Size = new System.Drawing.Size(114, 13);
            this.lineWeek.TabIndex = 1;
            // 
            // lineStrong
            // 
            this.lineStrong.BackColor = System.Drawing.Color.Transparent;
            this.lineStrong.FillThickness = 5;
            this.lineStrong.Location = new System.Drawing.Point(263, 130);
            this.lineStrong.Name = "lineStrong";
            this.lineStrong.Size = new System.Drawing.Size(114, 13);
            this.lineStrong.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(25, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(202, 28);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Password Generator";
            // 
            // lbl_descTrackbar
            // 
            this.lbl_descTrackbar.AutoSize = true;
            this.lbl_descTrackbar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descTrackbar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descTrackbar.Location = new System.Drawing.Point(19, 167);
            this.lbl_descTrackbar.Name = "lbl_descTrackbar";
            this.lbl_descTrackbar.Size = new System.Drawing.Size(140, 23);
            this.lbl_descTrackbar.TabIndex = 2;
            this.lbl_descTrackbar.Text = "Password Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password Settings";
            // 
            // lbl_valueLength
            // 
            this.lbl_valueLength.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valueLength.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valueLength.Location = new System.Drawing.Point(383, 171);
            this.lbl_valueLength.Name = "lbl_valueLength";
            this.lbl_valueLength.Size = new System.Drawing.Size(33, 23);
            this.lbl_valueLength.TabIndex = 2;
            this.lbl_valueLength.Text = "12";
            this.lbl_valueLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_password
            // 
            this.txt_password.Animated = true;
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txt_password.BorderRadius = 5;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(189)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Location = new System.Drawing.Point(24, 83);
            this.txt_password.MaxLength = 30;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderText = "";
            this.txt_password.ReadOnly = true;
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(353, 41);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // btn_copyPassword
            // 
            this.btn_copyPassword.Animated = true;
            this.btn_copyPassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_copyPassword.BorderRadius = 5;
            this.btn_copyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copyPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_copyPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_copyPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_copyPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_copyPassword.FillColor = System.Drawing.Color.Transparent;
            this.btn_copyPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_copyPassword.ForeColor = System.Drawing.Color.White;
            this.btn_copyPassword.Image = ((System.Drawing.Image)(resources.GetObject("btn_copyPassword.Image")));
            this.btn_copyPassword.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_copyPassword.Location = new System.Drawing.Point(387, 88);
            this.btn_copyPassword.Name = "btn_copyPassword";
            this.btn_copyPassword.Size = new System.Drawing.Size(29, 36);
            this.btn_copyPassword.TabIndex = 4;
            this.btn_copyPassword.Click += new System.EventHandler(this.btn_copyPassword_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Animated = true;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BorderRadius = 5;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = global::PasswordGenerator.Properties.Resources.exit;
            this.btn_exit.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exit.Location = new System.Drawing.Point(394, 14);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 35);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tb_length
            // 
            this.tb_length.BackColor = System.Drawing.Color.Transparent;
            this.tb_length.Location = new System.Drawing.Point(24, 197);
            this.tb_length.Maximum = 30;
            this.tb_length.Name = "tb_length";
            this.tb_length.Size = new System.Drawing.Size(392, 23);
            this.tb_length.TabIndex = 5;
            this.tb_length.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(189)))));
            this.tb_length.Value = 12;
            this.tb_length.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tb_length_Scroll);
            // 
            // lowercaseCheckBox
            // 
            this.lowercaseCheckBox.Animated = true;
            this.lowercaseCheckBox.AutoSize = true;
            this.lowercaseCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.lowercaseCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lowercaseCheckBox.CheckedState.BorderRadius = 0;
            this.lowercaseCheckBox.CheckedState.BorderThickness = 0;
            this.lowercaseCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lowercaseCheckBox.Enabled = false;
            this.lowercaseCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowercaseCheckBox.Location = new System.Drawing.Point(23, 275);
            this.lowercaseCheckBox.Name = "lowercaseCheckBox";
            this.lowercaseCheckBox.Size = new System.Drawing.Size(135, 24);
            this.lowercaseCheckBox.TabIndex = 6;
            this.lowercaseCheckBox.Text = "Lowercase (a-z)";
            this.lowercaseCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lowercaseCheckBox.UncheckedState.BorderRadius = 0;
            this.lowercaseCheckBox.UncheckedState.BorderThickness = 0;
            this.lowercaseCheckBox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.lowercaseCheckBox.UseVisualStyleBackColor = false;
            // 
            // uppercaseCheckBox
            // 
            this.uppercaseCheckBox.Animated = true;
            this.uppercaseCheckBox.AutoSize = true;
            this.uppercaseCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.uppercaseCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uppercaseCheckBox.CheckedState.BorderRadius = 0;
            this.uppercaseCheckBox.CheckedState.BorderThickness = 0;
            this.uppercaseCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uppercaseCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppercaseCheckBox.Location = new System.Drawing.Point(273, 275);
            this.uppercaseCheckBox.Name = "uppercaseCheckBox";
            this.uppercaseCheckBox.Size = new System.Drawing.Size(140, 24);
            this.uppercaseCheckBox.TabIndex = 6;
            this.uppercaseCheckBox.Text = "Uppercase (A-Z)";
            this.uppercaseCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.uppercaseCheckBox.UncheckedState.BorderRadius = 0;
            this.uppercaseCheckBox.UncheckedState.BorderThickness = 0;
            this.uppercaseCheckBox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.uppercaseCheckBox.UseVisualStyleBackColor = false;
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.Animated = true;
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.numbersCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numbersCheckBox.CheckedState.BorderRadius = 0;
            this.numbersCheckBox.CheckedState.BorderThickness = 0;
            this.numbersCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numbersCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersCheckBox.Location = new System.Drawing.Point(23, 313);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(127, 24);
            this.numbersCheckBox.TabIndex = 6;
            this.numbersCheckBox.Text = "Numbers (0-9)";
            this.numbersCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numbersCheckBox.UncheckedState.BorderRadius = 0;
            this.numbersCheckBox.UncheckedState.BorderThickness = 0;
            this.numbersCheckBox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.numbersCheckBox.UseVisualStyleBackColor = false;
            // 
            // symbolsCheckBox
            // 
            this.symbolsCheckBox.Animated = true;
            this.symbolsCheckBox.AutoSize = true;
            this.symbolsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.symbolsCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.symbolsCheckBox.CheckedState.BorderRadius = 0;
            this.symbolsCheckBox.CheckedState.BorderThickness = 0;
            this.symbolsCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.symbolsCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolsCheckBox.Location = new System.Drawing.Point(273, 313);
            this.symbolsCheckBox.Name = "symbolsCheckBox";
            this.symbolsCheckBox.Size = new System.Drawing.Size(139, 24);
            this.symbolsCheckBox.TabIndex = 6;
            this.symbolsCheckBox.Text = "Symbols (!-$^+)";
            this.symbolsCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.symbolsCheckBox.UncheckedState.BorderRadius = 0;
            this.symbolsCheckBox.UncheckedState.BorderThickness = 0;
            this.symbolsCheckBox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.symbolsCheckBox.UseVisualStyleBackColor = false;
            // 
            // excludeDuplicateCheckBox
            // 
            this.excludeDuplicateCheckBox.Animated = true;
            this.excludeDuplicateCheckBox.AutoSize = true;
            this.excludeDuplicateCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.excludeDuplicateCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.excludeDuplicateCheckBox.CheckedState.BorderRadius = 0;
            this.excludeDuplicateCheckBox.CheckedState.BorderThickness = 0;
            this.excludeDuplicateCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.excludeDuplicateCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excludeDuplicateCheckBox.Location = new System.Drawing.Point(24, 351);
            this.excludeDuplicateCheckBox.Name = "excludeDuplicateCheckBox";
            this.excludeDuplicateCheckBox.Size = new System.Drawing.Size(150, 24);
            this.excludeDuplicateCheckBox.TabIndex = 6;
            this.excludeDuplicateCheckBox.Text = "Exclude Duplicate";
            this.excludeDuplicateCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.excludeDuplicateCheckBox.UncheckedState.BorderRadius = 0;
            this.excludeDuplicateCheckBox.UncheckedState.BorderThickness = 0;
            this.excludeDuplicateCheckBox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.excludeDuplicateCheckBox.UseVisualStyleBackColor = false;
            // 
            // includeSpacesCheckBox
            // 
            this.includeSpacesCheckBox.Animated = true;
            this.includeSpacesCheckBox.AutoSize = true;
            this.includeSpacesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.includeSpacesCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.includeSpacesCheckBox.CheckedState.BorderRadius = 0;
            this.includeSpacesCheckBox.CheckedState.BorderThickness = 0;
            this.includeSpacesCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.includeSpacesCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.includeSpacesCheckBox.Location = new System.Drawing.Point(274, 351);
            this.includeSpacesCheckBox.Name = "includeSpacesCheckBox";
            this.includeSpacesCheckBox.Size = new System.Drawing.Size(129, 24);
            this.includeSpacesCheckBox.TabIndex = 6;
            this.includeSpacesCheckBox.Text = "Include Spaces";
            this.includeSpacesCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.includeSpacesCheckBox.UncheckedState.BorderRadius = 0;
            this.includeSpacesCheckBox.UncheckedState.BorderThickness = 0;
            this.includeSpacesCheckBox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.includeSpacesCheckBox.UseVisualStyleBackColor = false;
            // 
            // pnl_container
            // 
            this.pnl_container.BorderRadius = 10;
            this.pnl_container.Controls.Add(this.includeSpacesCheckBox);
            this.pnl_container.Controls.Add(this.excludeDuplicateCheckBox);
            this.pnl_container.Controls.Add(this.symbolsCheckBox);
            this.pnl_container.Controls.Add(this.numbersCheckBox);
            this.pnl_container.Controls.Add(this.uppercaseCheckBox);
            this.pnl_container.Controls.Add(this.lowercaseCheckBox);
            this.pnl_container.Controls.Add(this.tb_length);
            this.pnl_container.Controls.Add(this.btn_exit);
            this.pnl_container.Controls.Add(this.btn_copyPassword);
            this.pnl_container.Controls.Add(this.txt_password);
            this.pnl_container.Controls.Add(this.lbl_valueLength);
            this.pnl_container.Controls.Add(this.label1);
            this.pnl_container.Controls.Add(this.lbl_descTrackbar);
            this.pnl_container.Controls.Add(this.lbl_title);
            this.pnl_container.Controls.Add(this.lineStrong);
            this.pnl_container.Controls.Add(this.lineWeek);
            this.pnl_container.Controls.Add(this.lineVeryWeek);
            this.pnl_container.Controls.Add(this.seperator);
            this.pnl_container.Controls.Add(this.btn_generate);
            this.pnl_container.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.pnl_container.Location = new System.Drawing.Point(25, 33);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(441, 465);
            this.pnl_container.TabIndex = 0;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(110)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(491, 529);
            this.Controls.Add(this.pnl_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pnl_container.ResumeLayout(false);
            this.pnl_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm bf_form;
        private Siticone.Desktop.UI.WinForms.SiticonePanel pnl_container;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox includeSpacesCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox excludeDuplicateCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox symbolsCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox numbersCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox uppercaseCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox lowercaseCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar tb_length;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_exit;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_copyPassword;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txt_password;
        private System.Windows.Forms.Label lbl_valueLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_descTrackbar;
        private System.Windows.Forms.Label lbl_title;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator lineStrong;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator lineWeek;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator lineVeryWeek;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator seperator;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btn_generate;
    }
}

