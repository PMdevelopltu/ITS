using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirdWatcher
{
    [Serializable]
    public class BirdData
    {

#region Member Variables

        private Guid mId;
        private string mAuthor;
        private string mName;
        private string mYear;
        private string mCategory;
        private string mWorld;
        private string mLit;
        private string mLink;
        private string mComment;
        private DateTime mDateViewed;
        private DateTime mTimeViewed;
        private byte[] mPicture;
      //  private string mPictureName;

#endregion



#region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BirdData()
        {
            mId = Guid.NewGuid();
        }


        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="birdname"></param>
       

#endregion



#region Properties

        


        public string Autorius
        {
            get
            {
                return mAuthor;
            }
            set
            {
                mAuthor = value;
            }
        }

        public string Pavadinimas
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string Metai
        {
            get
            {
                return mYear;
            }
            set
            {
                mYear = value;
            }
        }
        public string Lietuvos_Istorija
        {
            get
            {
                return mLit;
            }
            set
            {
                mLit = value;
            }
        }
        
        public string Comment
        {
            get { return mComment; }
            set { mComment = value; }
        }
        public string Kategorija
        {
            get
            {
                return mCategory;
            }
            set
            {
                mCategory = value;
            }
        }


        public string Pasaulio_Istorija
        {
            get
            {
                return mWorld;
            }
            set
            {
                mWorld = value;
            }
        }

        public string Nuoroda
        {
            get
            {
                return mLink;
            }
            set 
            {
                mLink = value; 
            }
        }

       


        public DateTime DateViewed
        {
            get
            {
                return mDateViewed;
            }
            set
            {
                mDateViewed = value;
            }
        }


        public DateTime TimeViewed
        {
            get
            {
                return mTimeViewed;
            }
            set
            {
                mTimeViewed = value;
            }
        }


        public byte[] Picture
        {
            get
            {
                return mPicture;
            }
            set
            {
                mPicture = value;
            }
        }

        

#endregion


    }
}
