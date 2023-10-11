namespace Questionnaire
{
    partial class Form1
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
            email_load_textbox = new RichTextBox();
            load_btn = new Button();
            panel1 = new Panel();
            email_txt_box = new TextBox();
            Email_lbl = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            Gender_lbl = new Label();
            Birthday_lbl = new Label();
            dateTimePicker1 = new DateTimePicker();
            phone_txt_box = new TextBox();
            city_txt_box = new TextBox();
            country_txt_box = new TextBox();
            father_txt_box = new TextBox();
            surname_text_box = new TextBox();
            phone_lbl = new Label();
            City_lbl = new Label();
            Country_lbl = new Label();
            father_lbl = new Label();
            surname_lbl = new Label();
            name_txt_box = new TextBox();
            name_lbl = new Label();
            questionnarie_label = new Label();
            save_btn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // email_load_textbox
            // 
            email_load_textbox.Location = new Point(12, 12);
            email_load_textbox.Name = "email_load_textbox";
            email_load_textbox.Size = new Size(252, 26);
            email_load_textbox.TabIndex = 0;
            email_load_textbox.Text = "";
            // 
            // load_btn
            // 
            load_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            load_btn.Location = new Point(285, 12);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(75, 26);
            load_btn.TabIndex = 1;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(email_txt_box);
            panel1.Controls.Add(Email_lbl);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(Gender_lbl);
            panel1.Controls.Add(Birthday_lbl);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(phone_txt_box);
            panel1.Controls.Add(city_txt_box);
            panel1.Controls.Add(country_txt_box);
            panel1.Controls.Add(father_txt_box);
            panel1.Controls.Add(surname_text_box);
            panel1.Controls.Add(phone_lbl);
            panel1.Controls.Add(City_lbl);
            panel1.Controls.Add(Country_lbl);
            panel1.Controls.Add(father_lbl);
            panel1.Controls.Add(surname_lbl);
            panel1.Controls.Add(name_txt_box);
            panel1.Controls.Add(name_lbl);
            panel1.Controls.Add(questionnarie_label);
            panel1.Location = new Point(12, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 408);
            panel1.TabIndex = 2;
            // 
            // email_txt_box
            // 
            email_txt_box.Location = new Point(145, 325);
            email_txt_box.Name = "email_txt_box";
            email_txt_box.Size = new Size(188, 23);
            email_txt_box.TabIndex = 19;
            // 
            // Email_lbl
            // 
            Email_lbl.AutoSize = true;
            Email_lbl.BackColor = Color.SlateGray;
            Email_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Email_lbl.ForeColor = SystemColors.ActiveCaptionText;
            Email_lbl.Location = new Point(19, 327);
            Email_lbl.Name = "Email_lbl";
            Email_lbl.Size = new Size(48, 21);
            Email_lbl.TabIndex = 18;
            Email_lbl.Text = "Email";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(231, 362);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 25);
            radioButton2.TabIndex = 17;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(163, 362);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 25);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Gender_lbl
            // 
            Gender_lbl.AutoSize = true;
            Gender_lbl.BackColor = Color.SlateGray;
            Gender_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Gender_lbl.ForeColor = SystemColors.ActiveCaptionText;
            Gender_lbl.Location = new Point(19, 366);
            Gender_lbl.Name = "Gender_lbl";
            Gender_lbl.Size = new Size(61, 21);
            Gender_lbl.TabIndex = 15;
            Gender_lbl.Text = "Gender";
            // 
            // Birthday_lbl
            // 
            Birthday_lbl.AutoSize = true;
            Birthday_lbl.BackColor = Color.SlateGray;
            Birthday_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Birthday_lbl.ForeColor = SystemColors.ActiveCaptionText;
            Birthday_lbl.Location = new Point(19, 281);
            Birthday_lbl.Name = "Birthday_lbl";
            Birthday_lbl.Size = new Size(70, 21);
            Birthday_lbl.TabIndex = 14;
            Birthday_lbl.Text = "BirthDay";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(145, 281);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // phone_txt_box
            // 
            phone_txt_box.Location = new Point(145, 241);
            phone_txt_box.Name = "phone_txt_box";
            phone_txt_box.Size = new Size(188, 23);
            phone_txt_box.TabIndex = 12;
            // 
            // city_txt_box
            // 
            city_txt_box.Location = new Point(145, 204);
            city_txt_box.Name = "city_txt_box";
            city_txt_box.Size = new Size(188, 23);
            city_txt_box.TabIndex = 11;
            // 
            // country_txt_box
            // 
            country_txt_box.Location = new Point(145, 166);
            country_txt_box.Name = "country_txt_box";
            country_txt_box.Size = new Size(188, 23);
            country_txt_box.TabIndex = 10;
            // 
            // father_txt_box
            // 
            father_txt_box.Location = new Point(145, 126);
            father_txt_box.Name = "father_txt_box";
            father_txt_box.Size = new Size(188, 23);
            father_txt_box.TabIndex = 9;
            // 
            // surname_text_box
            // 
            surname_text_box.Location = new Point(145, 90);
            surname_text_box.Name = "surname_text_box";
            surname_text_box.Size = new Size(188, 23);
            surname_text_box.TabIndex = 8;
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.BackColor = Color.SlateGray;
            phone_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phone_lbl.ForeColor = SystemColors.ActiveCaptionText;
            phone_lbl.Location = new Point(19, 239);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(54, 21);
            phone_lbl.TabIndex = 7;
            phone_lbl.Text = "Phone";
            // 
            // City_lbl
            // 
            City_lbl.AutoSize = true;
            City_lbl.BackColor = Color.SlateGray;
            City_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            City_lbl.ForeColor = SystemColors.ActiveCaptionText;
            City_lbl.Location = new Point(19, 202);
            City_lbl.Name = "City_lbl";
            City_lbl.Size = new Size(37, 21);
            City_lbl.TabIndex = 6;
            City_lbl.Text = "City";
            // 
            // Country_lbl
            // 
            Country_lbl.AutoSize = true;
            Country_lbl.BackColor = Color.SlateGray;
            Country_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Country_lbl.ForeColor = SystemColors.ActiveCaptionText;
            Country_lbl.Location = new Point(19, 168);
            Country_lbl.Name = "Country_lbl";
            Country_lbl.Size = new Size(66, 21);
            Country_lbl.TabIndex = 5;
            Country_lbl.Text = "Country";
            // 
            // father_lbl
            // 
            father_lbl.AutoSize = true;
            father_lbl.BackColor = Color.SlateGray;
            father_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            father_lbl.ForeColor = SystemColors.ActiveCaptionText;
            father_lbl.Location = new Point(19, 124);
            father_lbl.Name = "father_lbl";
            father_lbl.Size = new Size(110, 21);
            father_lbl.TabIndex = 4;
            father_lbl.Text = "Father's Name";
            // 
            // surname_lbl
            // 
            surname_lbl.AutoSize = true;
            surname_lbl.BackColor = Color.SlateGray;
            surname_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            surname_lbl.ForeColor = SystemColors.ActiveCaptionText;
            surname_lbl.Location = new Point(19, 92);
            surname_lbl.Name = "surname_lbl";
            surname_lbl.Size = new Size(73, 21);
            surname_lbl.TabIndex = 3;
            surname_lbl.Text = "Surname";
            // 
            // name_txt_box
            // 
            name_txt_box.Location = new Point(145, 50);
            name_txt_box.Name = "name_txt_box";
            name_txt_box.Size = new Size(188, 23);
            name_txt_box.TabIndex = 2;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.BackColor = Color.SlateGray;
            name_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name_lbl.ForeColor = Color.Black;
            name_lbl.Location = new Point(19, 52);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(52, 21);
            name_lbl.TabIndex = 1;
            name_lbl.Text = "Name";
            // 
            // questionnarie_label
            // 
            questionnarie_label.AutoSize = true;
            questionnarie_label.BackColor = Color.SlateGray;
            questionnarie_label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            questionnarie_label.ForeColor = Color.Black;
            questionnarie_label.Location = new Point(100, 0);
            questionnarie_label.Name = "questionnarie_label";
            questionnarie_label.Size = new Size(131, 25);
            questionnarie_label.TabIndex = 0;
            questionnarie_label.Text = "Questionnaire";
            // 
            // save_btn
            // 
            save_btn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Location = new Point(77, 481);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(204, 31);
            save_btn.TabIndex = 3;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 56, 78);
            ClientSize = new Size(372, 524);
            Controls.Add(save_btn);
            Controls.Add(panel1);
            Controls.Add(load_btn);
            Controls.Add(email_load_textbox);
            Name = "Form1";
            Text = "Questionnarie";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox email_load_textbox;
        private Button load_btn;
        private Panel panel1;
        private TextBox name_txt_box;
        private Label name_lbl;
        private Label questionnarie_label;
        private Label father_lbl;
        private Label surname_lbl;
        private TextBox phone_txt_box;
        private TextBox city_txt_box;
        private TextBox country_txt_box;
        private TextBox father_txt_box;
        private TextBox surname_text_box;
        private Label phone_lbl;
        private Label City_lbl;
        private Label Country_lbl;
        private Label Birthday_lbl;
        private DateTimePicker dateTimePicker1;
        private Label Gender_lbl;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox email_txt_box;
        private Label Email_lbl;
        private Button save_btn;
    }
}