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
        private string mBirdName;
        private string mGender;
        private string mLocation;
        private string mBehaviorObserved;
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
            mBirdName = birdname;
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


        public string BirdName
        {
            get
            {
                return mBirdName;
            }
            set
            {
                mBirdName = value;
            }
        }


        public string Gender
        {
            get
            {
                return mGender;
            }
            set
            {
                mGender = value;
            }
        }


        public string Location
        {
            get
            {
                return mLocation;
            }
            set
            {
                mLocation = value;
            }
        }


        public string BehaviorObserved
        {
            get
            {
                return mBehaviorObserved;
            }
            set
            {
                mBehaviorObserved = value;
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
