using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanburyCinema
{
    public partial class Form1 : Form
    {
        List<Movie> movies = new List<Movie>();

        int movieDisplayed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            Image movieImage = Image.FromFile("Movie Images\\" + movies[movieDisplayed].Name + ".jpg");
            pictureBoxMovie.Image = movieImage;

            textBoxName.Text = movies[movieDisplayed].Name;
            textBoxCertificate.Text = movies[movieDisplayed].Certificate;
            textBoxDirector.Text = movies[movieDisplayed].Director;
            textBoxMainStar.Text = movies[movieDisplayed].MainStar;
            textBoxRunningTime.Text = movies[movieDisplayed].RunningTime.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            movies.Add(new Movie("Creed II", "12A", "Steven Caple Jr.", "Michael B. Jordan", 130));
            movies.Add(new Move("A Star is Born", "15", "Bradley Cooper", "Lady Gaga", 136));
            movies.Add(new Movie("Robin Hood", 12A, "Marc Forster", "Taron Egerton", 116));
            movies.Add(new Movie("The Grinch", "U", "Peter Candeland", "Benedict Cumberbatch" 90));
            movies.Add(new Movie("Aquaman", "12A", "James Wan", "Jason Momoa", 143);
            movies.Add(mew Movie("Bohemian Rhapsody", "12A", "Bryan Singer", "Rami Malek", 134));

            DisplayData();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            movieDisplayed++;

            if (movieDisplayed == movies.Count())
            {
                movieDisplayed = 0;
            }

            DisplayData();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            movieDisplayed--;

            if (movieDisplayed == -1)
            {
                movieDisplayed = movies.Count() - 1;
            }

            DisplayData();
        }
    }
}
