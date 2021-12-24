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
        private DateTime mDateViewed;
        private DateTime mTimeViewed;
        private byte[] mPicture;
        private string mPictureName;

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
        public BirdData(string birdname)
        {
            mId = Guid.NewGuid();
            mAuthor = birdname;
        }

#endregion



#region Properties

        public Guid ID
        {
            get
            {
                return mId;
            }
        }


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

        public string Link
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

        public string PictureName
        {
            get
            {
                return mPictureName;
            }
            set
            {
                mPictureName = value;
            }
        }

#endregion


    }
}
