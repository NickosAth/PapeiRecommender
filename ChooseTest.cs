using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCareerApp
{
    public partial class chooseTest : Form
    {
        public static string speciality;
        public static int new_current_user_id;

        public chooseTest(int current_user_id)
        {
            InitializeComponent();
            new_current_user_id = current_user_id;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
            Menu menu = new(new_current_user_id);
            menu.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void softwareDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Συστήματα Υποστήριξης Αποφάσεων";
            Test test = new Test(speciality, new_current_user_id);
            Close();
            test.Show();
        }
        private void dataAnalyst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Επαναληπτικό Τεστ";
            Test test = new Test(speciality, new_current_user_id);
            Close();
            test.Show();
        }
        private void computerSystemAnalyst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Συστήματα Διαχείρισης Βάσεων Δεδομένων";
            Test test = new Test(speciality, new_current_user_id);
            Close();
            test.Show();
        }
        private void videoGameDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Εικονική Πραγματικότητα";
            Test test = new Test(speciality, new_current_user_id);
            Close();
            test.Show();
        }
        private void userExperienceDesign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Λογικός Προγραμματισμός";
            Test test = new Test(speciality, new_current_user_id);
            Close();
            test.Show();
        }
        private void informationSecurity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Ηλεκτρονικό Επιχειρείν και Καινοτομία";
            Test test = new Test(speciality, new_current_user_id);
            Close();
            test.Show();
        }
        private void networkEngineer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Κρυπτογραφία";
            Test test = new Test(speciality, new_current_user_id);
            Close();
            test.Show();
        }
        private void machineLearning_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Προηγμένη Αρχιτεκτονική Υπολογιστών";
            Test test = new Test(speciality, new_current_user_id);
            Close();
            test.Show();
        }
        private void webDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Κινητές και Ασύρματες Επικοινωνίες";
            Test test = new Test(speciality, new_current_user_id);
            Close();
            test.Show();
        }
        private void webDesigner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            speciality = "Δίκτυα Υψηλών Ταχυτήτων";
            Test test = new Test(speciality, new_current_user_id);
            Close();
            test.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πατήστε κλικ πάνω στην ειδικότητα που θέλετε να κάνετε τεστ αξιόλογησης πάνω σε αυτήν. Έπειτα θα ανακατευθυνθείτε στο τεστ.", "Βοήθεια");
        }

        private void chooseTest_Load(object sender, EventArgs e)
        {

        }
    }
}
