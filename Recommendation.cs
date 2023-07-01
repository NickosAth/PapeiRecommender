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
    public partial class Recommendation : Form
    {
        public int new_current_user_id;
        public Recommendation(int new_current_user_id)
        {
            InitializeComponent();
            this.new_current_user_id = new_current_user_id;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
            Menu menu = new Menu(new_current_user_id);
            menu.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Recommendation_Load(object sender, EventArgs e)
        {
            chosenSpeciality1.Text = "1";
            chosenSpeciality2.Text = "2";
            chosenSpeciality3.Text = "3";

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Έδώ είναι η φόρμα σύστασης των τριών καλύτερων ειδικοτήτων για τον κάθε χρήστη, σύμφωνα με το μάθημα που θεώρησε ο ίδιος πιο ενδιαφέρον και επισκέφθηκε περισσότερες φορές, αλλά και πέτυχε καλό σκορ στο τεστ αξιολόγησης.", "Βοήθεια");
        }
    }
}
