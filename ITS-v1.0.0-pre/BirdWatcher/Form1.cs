using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ITS;

namespace BirdWatcher
{

    /// <summary>
    /// A simple project used to maintain data about a 
    /// collection of birds (could be anything), and to
    /// display that data to the user, persist the data,
    /// and allow the user to recover and modify the
    /// data without using a database.
    /// </summary>
    public partial class Form1 : Form
    {


#region Variable Declarations

        private List<BirdData> birds;   // a container for the bird collection
        BirdData currentBird;           // the current bird (displayed)
        string currentFilePath;         // the path to the bird data file
        int currentPosition;            // the position within the bird list
        bool dirtyForm;                 // mark the form dirty when changed

#endregion



#region Constructor


        /// <summary>
        /// constructor initializes bird list and
        /// defaults values
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // create new bird data list
            // ready to write data
            birds = new List<BirdData>();
            currentBird = new BirdData();

            // set the date time pickers to now
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;

            // init current position to zero
            currentPosition = 0;

            // mark form as not dirty
            dirtyForm = false;
        }


#endregion



#region Housekeeping


        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void tsbExit_Click(object sender, EventArgs e)
        {
            // call the menu function
            exitToolStripMenuItem_Click(this, new EventArgs());
        }


        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dirtyForm == true)
            {
                if (MessageBox.Show(this, "You have not saved the current bird data; " +
                                 "would you like to save before exiting?", "Save Current Data", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
       
        
        /// <summary>
        /// Clear all form fields
        /// </summary>
        public void ClearForm()
        {
            dirtyForm = true;

            txtAuthor.Text = string.Empty;
            cboWorld.Text = string.Empty;
            cboLit.Text = string.Empty;
            txtName.Text = string.Empty;
            txtYear.Text= string.Empty;
            linkBox.Text = string.Empty;
            cboGender.SelectedIndex = -1;

            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;

            picBird.Image = null;
        }
   
        
        /// <summary>
        /// Load the image into the picture box
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void btnSetImage_Click(object sender, EventArgs e)
        {
            dirtyForm = true;

            string imageFilePath = string.Empty;

            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Title = "Open Image File";
            OpenFileDialog1.Filter = "JPEG Documents (*.jpg)|*.jpg|Gif Files|*.gif";

            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            imageFilePath = OpenFileDialog1.FileName;
            if (String.IsNullOrEmpty(imageFilePath))
            {
                return;
            }

            if (System.IO.File.Exists(imageFilePath) == false)
            {
                return;
            }

            byte[] bArrImage = new byte[0];
            try
            {
                // convert Image to byte array and save in
                System.IO.FileStream fsImage = null;
                fsImage = System.IO.File.Open(imageFilePath, FileMode.Open, FileAccess.Read);
                bArrImage = new byte[fsImage.Length];
                fsImage.Read(bArrImage, 0, (int)fsImage.Length);
                fsImage.Close();

                currentBird.Picture = bArrImage;
                currentBird.PictureName = imageFilePath;

                MemoryStream ms = new MemoryStream(bArrImage);
                picBird.Image = Image.FromStream(ms);
                ms.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Storing Image");
            }
        }


        /// <summary>
        /// Create a new bird data file
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dirtyForm == true)
            {
                if (MessageBox.Show(this, "You have not saved the current bird data; " +
                                 "would you like to save before starting a new " +
                                 "bird database?", "Save Current Data", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {
                    // discard and start new document
                    birds = new List<BirdData>();
                    ClearForm();
                }
            }
            else
            {
                // start new document
                birds = new List<BirdData>();
                ClearForm();
            }
        }


        /// <summary>
        /// Open an existing bird data file
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void openStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dirtyForm == true)
            {
                if (MessageBox.Show(this, "You have not saved the current bird data; " +
                                 "would you like to save before opening a different " +
                                 "bird database?", "Save Current Data", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {
                    Open();
                }
            }
            else
            {
                Open();
            } 
        }


        /// <summary>
        /// Open an existing bird data file
        /// </summary>
        public void Open()
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Title = "Open BRD Document";
            OpenFileDialog1.Filter = "BRD Documents (*.brd)|*.brd";
            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            currentFilePath = OpenFileDialog1.FileName;
            if (String.IsNullOrEmpty(currentFilePath))
            {
                return;
            }

            if (System.IO.File.Exists(currentFilePath) == false)
            {
                return;
            }

            birds = FileSerializer.Deserialize(currentFilePath);

            // Load bird at position zero
            if (birds != null)
            {
                currentBird = birds.ElementAt<BirdWatcher.BirdData>(0);
                LoadCurrentBird();
                dirtyForm = false;
            }
        }


        /// <summary>
        /// Save the existing bird data file
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();

            if (String.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

                try
                {
                    SaveFileDialog1.Title = "Save BRD Document";
                    SaveFileDialog1.Filter = "BRD Documents (*.brd)|*.brd";

                    if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return;
                    }
                }
                catch
                {
                    return;
                }

                currentFilePath = SaveFileDialog1.FileName;
                if (String.IsNullOrEmpty(currentFilePath))
                {
                    return;
                }
            }

            FileSerializer.Serialize(currentFilePath, birds);

            MessageBox.Show("File " + currentFilePath + " saved.", "File Saved.");
            
            dirtyForm = false;
        }


        /// <summary>
        /// Save the existing bird data file with 
        /// a new file Pavadinimas
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

            try
            {
                SaveFileDialog1.Title = "Save BRD Document";
                SaveFileDialog1.Filter = "BRD Documents (*.brd)|*.brd";

                if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }
            catch
            {
                return;
            }

            currentFilePath = SaveFileDialog1.FileName;

            if (String.IsNullOrEmpty(currentFilePath))
            {
                return;
            }

            FileSerializer.Serialize(currentFilePath, birds);

            MessageBox.Show("File " + currentFilePath + " saved.", "File Saved.");

            dirtyForm = false;
        }


        /// <summary>
        /// Save the existing bird data file
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void tsbSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(this, new EventArgs());
        }


        /// <summary>
        /// Set the current bird values to the form content;
        /// if the user navigates off the current bird, it will
        /// save the content
        /// </summary>
        private void SaveCurrentBird()
        {
            if(!String.IsNullOrEmpty(txtAuthor.Text))
            {
                try
                {
                    currentBird.Autorius = txtAuthor.Text;
                    currentBird.Pasaulio_Istorija = cboWorld.Text;
                    currentBird.Lietuvos_Istorija = cboLit.Text;
                    currentBird.Pavadinimas = txtName.Text;
                    currentBird.Metai=txtYear.Text; 
                    currentBird.Kategorija = cboGender.Text;
                    currentBird.Link = linkBox.Text;
                    currentBird.DateViewed = dtpDate.Value;
                    currentBird.TimeViewed = dtpTime.Value;

                    // bird image byte array is set for current 
                    // bird when image is set
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }


#endregion



#region Bird Data Management


        /// <summary>
        /// Add a new bird to the bird data list
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();
            currentBird = new BirdData();
            ClearForm();
            birds.Add(currentBird);
            dirtyForm = true;
        }


        /// <summary>
        /// Remove the current bird from the bird
        /// data list
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void tsbRemoveBird_Click(object sender, EventArgs e)
        {
            birds.RemoveAt(currentPosition);

            if (currentPosition == 0)
                currentPosition++;
            else
                currentPosition--;

            currentBird = birds[currentPosition];
            LoadCurrentBird();
            dirtyForm = true;
        }


        /// <summary>
        /// Find a specific bird
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void tsbFindBird_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(birds);
            f.BirdNameUpdated += new Form3.BirdNameUpdateHandler(FindBird);
            f.Show();
        }


        /// <summary>
        /// The bird finder code
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void FindBird(object sender, BirdNameUpdateEventArgs e)
        {
            for (int i = 0; i < birds.Count; i++)
            {
                if (birds[i].Autorius == e.BirdName)
                {
                    currentBird = birds[i];
                    LoadCurrentBird();
                    currentPosition = i;
                }
            }
        }


        /// <summary>
        /// List all of the birds in the bird 
        /// data file
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void listAllBirdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(birds);
            f.Show();
        }


        /// <summary>
        /// Load the current bird into the form
        /// </summary>
        private void LoadCurrentBird()
        {
            try
            {
                txtAuthor.Text = currentBird.Autorius;
            }
            catch { }
            try
            {
                txtName.Text = currentBird.Pavadinimas;
                txtYear.Text = currentBird.Metai;  
            }
            catch { }
            try
            {
                cboGender.Text = currentBird.Kategorija;
            }
            catch { }
            try
            {
                cboWorld.Text = currentBird.Pasaulio_Istorija;
            }
            catch { }


            try
            {
                cboLit.Text = currentBird.Lietuvos_Istorija;
            }
            catch { }
            try
            {
                linkBox.Text = currentBird.Link;
            }
            catch { }
            try
            {
                dtpDate.Value = currentBird.DateViewed;
            }
            catch { }

            try
            {
                dtpTime.Value = currentBird.TimeViewed;
            }
            catch { }

            try
            {

                if (currentBird.Picture != null)
                {
                    MemoryStream ms = new MemoryStream(currentBird.Picture);
                    picBird.Image = Image.FromStream(ms);
                    ms.Dispose();
                }
                else
                {
                    MemoryStream ms = new MemoryStream(currentBird.Picture);
                    picBird.Image = Image.FromStream(ms);
                    ms.Dispose();
                }
            }
            catch
            {
                picBird.Image = null;
            }
        }


#endregion



#region Navigation


        /// <summary>
        /// Navigate back to the previous bird
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void tsbNavBack_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();

            if (currentPosition != 0)
            {
                currentPosition--;
                currentBird = birds[currentPosition];
                LoadCurrentBird();
            }
        }

        /// <summary>
        /// Navigate forward to the next bird
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void tsbNavForward_Click(object sender, EventArgs e)
        {
            SaveCurrentBird();

            if (currentPosition < birds.Count - 1)
            {
                currentPosition++;
                currentBird = birds[currentPosition];
                LoadCurrentBird();
            }
        }


#endregion

        

#region Dirty the Form

        /// <summary>
        /// Dirty the form if the user enters text into
        /// the bird Pavadinimas textbox
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void txtBirdName_KeyPress(object sender, KeyPressEventArgs e)
        {
           // dirtyForm = true;
        }


        /// <summary>
        /// Dirty the form if the user clicks on the gender 
        /// combobox to change the value
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void cboGender_MouseClick(object sender, MouseEventArgs e)
        {
            dirtyForm = true;
        }
        


        /// <summary>
        /// Dirty the form if the user enters text into
        /// the location textbox
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }


        /// <summary>
        /// Dirty the form if the user enters text into
        /// the bird behavior textbox
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void txtBehavior_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }


        /// <summary>
        /// Dirty the form if the user picks a date from the
        /// control
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void dtpDate_CloseUp(object sender, EventArgs e)
        {
            dirtyForm = true;
        }


        /// <summary>
        /// Dirty the form if the user picks a time from the
        /// control
        /// </summary>
        /// <param Pavadinimas="sender"></param>
        /// <param Pavadinimas="e"></param>
        private void dtpTime_CloseUp(object sender, EventArgs e)
        {
            dirtyForm = true;
        }

        private void cboWorld_MouseClick(object sender, MouseEventArgs e)
        {
            dirtyForm = true;
        }

        private void cboLit_MouseClick(object sender, MouseEventArgs e)
        {
            dirtyForm = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }
        private void linkBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            dirtyForm = true;
        }


        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ieškotiPagalAutoriųToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(birds);
            f.BirdNameUpdated += new Form3.BirdNameUpdateHandler(FindBird);
            f.Show();
        }

        private void įeitiĮKatalogąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(birds);
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void apieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 neww = new AboutBox1();
            neww.Show();
        }
    }
}
