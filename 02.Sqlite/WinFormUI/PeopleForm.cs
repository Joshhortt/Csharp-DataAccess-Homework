using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();

        public PeopleForm()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            // TODO - Get real data here
            people = SqliteDataAccess.LoadPeople();

            //people.Add(new PersonModel { FirstName = "Josh", LastName = "Hortt" });
            //people.Add(new PersonModel { FirstName = "Ana", LastName = "Rebelo" });
            //people.Add(new PersonModel { FirstName = "Alex", LastName = "Calvario" });

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            listPeopleListBox.DataSource = null;
            listPeopleListBox.DataSource = people;
            listPeopleListBox.DisplayMember = "FullName";
        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();

            p.FirstName = firstNameText.Text;
            p.LastName = lastNameText.Text;

            // TODO - do something with this item

            SqliteDataAccess.SavePerson(p);
            //people.Add(p);
            //WireUpPeopleList();

            firstNameText.Text = "";
            lastNameText.Text = "";
        }

		private void addPersonHeader_Click(object sender, EventArgs e)
		{

		}
	}
}
