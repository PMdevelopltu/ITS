using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace BirdWatcher
{

    /// <summary>
    /// Serializes and Deserializes bird data lists
    /// to persist the data, and to recover and redisplay
    /// the data stored in a BRD type file
    /// </summary>
    class FileSerializer
    {

        /// <summary>
        /// Use a binary formatter to save the bird data
        /// to a custom file
        /// </summary>
        /// <param name="strPath"></param>
        /// <param name="myFile"></param>
        public static void Serialize(string strPath, List<BirdData> myFile)
        {
            FileStream fs = new FileStream(strPath, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, myFile);
                fs.Close();
            }
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Deserialize an existing file back into a
        /// list of type BirdData
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public static List<BirdData> Deserialize(string strPath)
        {
            FileStream fs = new FileStream(strPath, FileMode.Open);
            List<BirdData> myFile = new List<BirdData>();

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                myFile = ((List<BirdData>)(formatter.Deserialize(fs)));
                fs.Close();
                return myFile;
            }
            catch (SerializationException ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return myFile;
            }
        }


    }
}