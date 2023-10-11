using System;
using System.Text.Json;

namespace Questionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Person PersonReturn()
        {
            Person person = new();
            person.Name = name_txt_box.Text;
            person.Surname = surname_text_box.Text;
            person.FathersName = father_txt_box.Text;
            person.Country = country_txt_box.Text;
            person.City = city_txt_box.Text;
            person.Phone = phone_txt_box.Text;
            person.Email = email_txt_box.Text;
            person.birthday = dateTimePicker1.Value;
            if (radioButton1.Checked)
                person.Gender = "Male";
            else
                person.Gender = "Female";
            return person;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Person person = PersonReturn();
            string fileName = email_txt_box.Text + ".json";
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            if (person.Name.Length > 0 && person.Surname.Length > 0 && person.FathersName.Length > 0 && person.Country.Length > 0 && person.City.Length > 0 && person.Phone.Length > 0 && person.Email.Length > 0)
            {
                File.WriteAllText(fileName, JsonSerializer.Serialize(person, options));
                name_txt_box.Text = "";
                surname_text_box.Text = "";
                father_txt_box.Text = "";
                country_txt_box.Text = "";
                city_txt_box.Text = "";
                phone_txt_box.Text = "";
                email_txt_box.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                radioButton2.Checked = true;
            }
            else
                MessageBox.Show("All Fields Must be Filled!");
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            string fileName = email_load_textbox.Text + ".json";
            Person person = null;
            if (File.Exists(fileName))
            {
                using FileStream fs = new FileStream(fileName, FileMode.Open);
                if (fs.Length > 0)
                    person = JsonSerializer.Deserialize<Person>(fs);
                if (person != null)
                {
                    name_txt_box.Text = person.Name;
                    surname_text_box.Text = person.Surname;
                    father_txt_box.Text = person.FathersName;
                    country_txt_box.Text = person.Country;
                    city_txt_box.Text = person.City;
                    phone_txt_box.Text = person.Phone;
                    email_txt_box.Text = person.Email;
                    dateTimePicker1.Value = person.birthday;
                    if (person.Gender == "Male") radioButton1.Checked = true;
                    else radioButton2.Checked = true;
                }
            }
            else
                MessageBox.Show("Invalid Email");
        }
    }
}