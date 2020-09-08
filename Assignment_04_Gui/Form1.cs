using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Assignment_04_Gui
{
    public partial class Form1 : Form
    {
        List<Music> musics = new List<Music>();  // all list of musics

        public static Queue<string> histories = new Queue<string>();  //Queue for histories

        Image pause = Image.FromFile("pause.PNG");  // pause icon

        Image play = Image.FromFile("play.PNG");  // play icon

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  assign a play icon
            btnPlay.Image = play;

            StartData();

            // select the first item of a music category
            cboCategory.SelectedIndex = 0;

            SplashScreen();

            gridViewMusics.Hide();
        }

        private void SplashScreen()
        {
            tmSplash.Interval = 1;
            tmSplash.Start();
        }

        private List<T> AddElementToArray<T>(List<T> array, T element)
        {
            array.Add(element);
            return array;
        }

        // read the list of musics data from text file & add it to the list
        private void StartData()
        {
            string filename = "musicList.txt";
            TextReader reader = new StreamReader(filename);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Music music = ParseMusic(line);
                AddElementToArray<Music>(musics, music);
                lstMusic.Items.Add(music.Title);

                // add a new category only when the category does not exists
                if (!cboCategory.Items.Contains(music.Category))
                {
                    cboCategory.Items.Add(music.Category);
                }
            }
        }

        // get an input from the user as a string
        private string Prompt()
        {
            string newMusic = Microsoft.VisualBasic.Interaction.InputBox("Add a new music! \nMUSIC_NAME/CATEGORY", "MyMusicPlayer", "TITLE/CATEGORY", 0, 0);
            
            // when a music is entered without category
            if (!newMusic.Contains("/"))
            {
                newMusic += "/No Category";
            }
            return newMusic;
        }

        // parse a string input to Music type
        private Music ParseMusic(string musicWithCategory)
        {
            Music music = new Music();
            string[] musicArray = musicWithCategory.Split('/');

            music.Title = musicArray[0];

            music.Category = musicArray[1];

            return music;
        }

        // add a history message to a history stack
        public void CreateHistory(string message)
        {
            histories.Enqueue(message);
        }

        private void ChangePlayBarPosition()
        {
            var cursorPoint = this.PointToClient(Cursor.Position);

            if (lstMusic.SelectedItem != null)
            {
                pnPlayBarCurrent.Width = cursorPoint.X - 12;
            }
        }

        public void ResetMusicPlayBar()
        {
            timer.Stop();

            // play bar start from 0
            pnPlayBarCurrent.Width = 0;

            btnPlay.Image = play;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // parse an input to Music type and assign a Music object
            Music music = ParseMusic(Prompt());

            if (music.Title != "" && music.Title != null)
            {
                AddElementToArray<Music>(musics, music);
                //musics.Add(music);

                // modify the textfile based on the change
                RecordMusicsFile();

                // add a title to a listbox in the form to display
                lstMusic.Items.Add(music.Title);

                // create a history with a message
                CreateHistory("Music added : '" + music.Title + "'");

                // add a new category only when it does not exist
                if (!cboCategory.Items.Contains(music.Category))
                {
                    cboCategory.Items.Add(music.Category);
                }
            }
        }

        // modify a text file based on the changed musics list
        private void RecordMusicsFile()
        {
            File.WriteAllText("modified.txt", String.Empty);
            TextWriter writer = new StreamWriter("modified.txt");
            foreach (var a in musics)
            {
                writer.WriteLine(a);
            }
            writer.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Music targetMusic = null;
            
            // works only at least one music is selected from the list
            if (lstMusic.SelectedIndex >= 0)
            {
                foreach (var music in musics)
                {
                    if (lstMusic.SelectedItem.ToString() == music.Title)
                    {
                        targetMusic = music;
                    }
                }

                // create history
                CreateHistory("Music deleted : '" + targetMusic.Title + "' ");

                // remove music element from the list
                musics.Remove(targetMusic);

                // display the changed list
                DisplayList();

                // change the txt file based on the changed list
                RecordMusicsFile();
            }
        }

        // display the changed list
        private void DisplayList()
        {
            // reset the music list
            lstMusic.Items.Clear();

            string category = cboCategory.SelectedItem.ToString();

            // add the musics from the changed list
            foreach (var music in musics)
            {
                if (music.Category == category)
                {
                    lstMusic.Items.Add(music.Title);
                }
            }
        }

        // occurs when category is changed
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateHistory($"Category changed : '{cboCategory.SelectedItem.ToString()}'");
            DisplayList();

            ResetMusicPlayBar();

            // make the button's icon play
            btnPlay.Image = play;

            pcPicture.Image = null;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            CreateHistory("List is sorted");

            // works when the music category is selected
            if (cboCategory.SelectedItem != null)
            {
                // stop playing music like when the category is chenged
                cboCategory_SelectedIndexChanged(sender, e);
            }

            lstMusic.Sorted = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // when the pause button is clicked
            if (btnPlay.Image == pause)
            {
                CreateHistory($"Music paused : '{lstMusic.SelectedItem.ToString()}' ");

                // change the icon to play
                btnPlay.Image = play;
                
                // stop the progress bar
                timer.Stop();
            }
            // when the play button is clicked
            else
            {
                // if there is no selected item
                if (lstMusic.SelectedItem == null)
                {
                    // select the first item
                    lstMusic.SelectedItem = lstMusic.Items[0];
                }

                CreateHistory($"Music played : \'{lstMusic.SelectedItem.ToString()}\'");

                // change the icon to pause
                btnPlay.Image = pause;

                // continue the progress bar
                timer.Start();
            }
            
        }

        // previous music
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            ResetMusicPlayBar();

            if (lstMusic.SelectedItem != null)
            {
                // select previous music
                if (lstMusic.SelectedIndex - 1 >= 0)
                {
                    lstMusic.SelectedItem = lstMusic.Items[lstMusic.SelectedIndex - 1];
                }

                // when the selected music is first music, move to the last music
                else
                {
                    lstMusic.SelectedItem = lstMusic.Items[lstMusic.Items.Count - 1];
                }
            }

            // if nothing is selected, select the first music
            else
            {
                lstMusic.SelectedItem = lstMusic.Items[0];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ResetMusicPlayBar();

            // when the music is selected
            if (lstMusic.SelectedItem != null)
            {
                // if the selected music is the last music, move to the first music
                if (lstMusic.SelectedIndex + 1 >= lstMusic.Items.Count)
                {
                    lstMusic.SelectedItem = lstMusic.Items[0];
                }

                // move to next music
                else
                {
                    lstMusic.SelectedItem = lstMusic.Items[lstMusic.SelectedIndex + 1];
                }
            }

            // when no music is selected, select the first music
            else
            {
                lstMusic.SelectedItem = lstMusic.Items[0];
            }
        }

        private void btnHistoryTab_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            // open form 2 tab
            form2.Show();
        }

        // timer for the progress bar
        private void timer_Tick(object sender, EventArgs e)
        {
            pnPlayBarCurrent.Width += 5;

            // When the music finishes, next music is automatically played
            if (pnPlayBarCurrent.Width >= 620)
            {
                btnNext_Click(sender, e);
                btnPlay_Click(sender, e);
            }
        }

        // when the selected music is changed
        private void lstMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetMusicPlayBar();

            btnPlay.Image = play;

            pcPicture.Image = null;

            if (lstMusic.SelectedItem != null)
            {
                int picNum = new Random().Next(0, 9);

                // choose the random image
                pcPicture.Image = Image.FromFile(picNum + ".JPG");

                CreateHistory($"Music changed :  \'{lstMusic.SelectedItem.ToString()}\'");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tmSplash_Tick(object sender, EventArgs e)
        {
            pnProgress.Width += 5;
            if (pnProgress.Width >= 949)
            {
                tmSplash.Stop();

                pnSplash.Hide();
            }
        }

        private void btnX_Click_1(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void pnPlayBar_Click(object sender, EventArgs e)
        {
            ChangePlayBarPosition();
        }

        private void pnPlayBarCurrent_Click(object sender, EventArgs e)
        {
            ChangePlayBarPosition();
        }

        private void btnMusicList_Click(object sender, EventArgs e)
        {
            gridViewMusics.DataSource = null;
            gridViewMusics.DataSource = musics;
            gridViewMusics.Show();
            
        }

        private void btnMusicTab_Click(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(36,36,36);
            gridViewMusics.Hide();
        }
    }
}
