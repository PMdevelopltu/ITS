using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BirdWatcher
{

    /// <summary>
    /// This form class displays a list of existing
    /// bird names for the user to pick from; once
    /// selected, an event will be raised with
    /// the selected bird name passed as an
    /// argument.  The main form will listen
    /// for an process this event to update
    /// the display of the current bird to match
    /// the search bird.
    /// </summary>
    public partial class Form3 : Form
    {

        // add a delegate 
        public delegate void BirdNameUpdateHandler(object sender, 
            BirdNameUpdateEventArgs e);
        public delegate void CategoryUpdateHandler(object sender,
           BirdNameUpdateEventArgs e);
        public delegate void PasaulioIstorijaUpdateHandler(object sender,
           BirdNameUpdateEventArgs e);
        public delegate void LietuvosUpdateHandler(object sender,
           BirdNameUpdateEventArgs e);

        // and associated event to notify
        // listeners when a bird name is
        // picked from this form's bird
        // name list
        public event BirdNameUpdateHandler BirdNameUpdated;
        public event CategoryUpdateHandler CategoryUpdated;
        public event PasaulioIstorijaUpdateHandler PasaulioIstorijaUpdated;
        public event LietuvosUpdateHandler LietuvosUpdated;


        /// <summary>
        /// Pass current bird data list to the 
        /// constructor so that the form can
        /// generate a list of bird names for 
        /// the user to choose from
        /// </summary>
        /// <param name="bd"></param>
        public Form3(List<BirdData> bd)
        {
            InitializeComponent();

            // iterate the bird data to add
            // each bird name to the bird
            // name list box control
            foreach (BirdData bird in bd)
                listBox1.Items.Add(bird.Pavadinimas);
           
        }


        /// <summary>
        /// When the user clicks on the find button,
        /// raise an event so the main form will display
        /// the appropriate bird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            // populate the argument list with the bird name
            BirdNameUpdateEventArgs args = 
                new BirdNameUpdateEventArgs(listBox1.SelectedItem.ToString());
            BirdNameUpdated(this, args);

            // raise the event to pass the bird name back to the
            // main form for processing
         


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }   // end class


    /// <summary>
    /// Container for the bird name update event arguments;
    /// in this case there is only one argument, that being
    /// the selected name of a bird from the bird list
    /// </summary>
    public class BirdNameUpdateEventArgs : System.EventArgs
    {
        // add local member variable to hold text
        private string mPavadinimas;
        

        // class constructor
        public BirdNameUpdateEventArgs(string sBirdName)
        {
            this.mPavadinimas = sBirdName;
        }

        // Properties - Accessible by the listener
        public string Pavadinimas
        {
            get
            {
                return mPavadinimas;
            }
        }
        
    }   // end class
    public class CategoryUpdateEventArgs:System.EventArgs
    {
        private string mKat;
        public CategoryUpdateEventArgs(string sKat)
        {
            this.mKat = sKat;
        }
        public string Kat
        {
            get
            {
                return mKat;
            }
        }
    }


}
