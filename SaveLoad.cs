using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization
{
    /// <summary>
    /// Generic class that can be inherited by any other class that requires 
    /// information to be serialized and deseralized and needs to inherit from 
    /// Form class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SaveLoad<T>
    {
        public SaveLoad() { }

        /// <summary>
        /// Creates a file that we can populate with all the 
        /// serializable data inside of the Object we pass in for the 
        /// argument of type T
        /// 
        /// I used a generic type here so that we can pass in any data type
        /// we need.
        /// 
        /// This function will create a file regardless if there is a file with 
        /// the same name located at the directory. It will just replae the old file
        /// with the new.
        /// </summary>
        /// <param name="s">Name of the file</param>
        /// <param name="t">Data we are passing in to be serialized</param>
        public void Serialize(string s, T t)
        {
            using (FileStream fs = File.Create(@"..\..\SavedFiles\" + s + ".bin")) //Creates a FileStream using information from the file we created
            {
                BinaryFormatter serializer = new BinaryFormatter(); //Creates a new BinaryFormatter to give us access to the Serialize function
                //We call the Serialize method and pass in the FileStream we created and the data inside of the object we passed into the function
                //When the data is being serialized it is being wrote into the created file in the form of bits and bytes there for if you open up the
                //file it is not human readable with the exception of the variables we declared.
                //To have the file in a human readable form we would use the SoapFormatter method
                serializer.Serialize(fs, t);
                fs.Close(); //Allways close your files when you are done using them
            }
        }

        /// <summary>
        /// This function is very similar to the serialize function we created above but the difference is 
        /// instead of writting to the file we will be reading the information into our application
        /// 
        /// We use a return type of T for this function so we can use this to assign the data we read in and
        /// assign it to any other data type as long as the data is compatiable.
        /// </summary>
        /// <param name="s">Name of the file we are looking for</param>
        /// <returns></returns>
        public T Deserialize(string s)
        {
            T t; //We will use this as the return value
            using (FileStream fs = File.OpenRead(@"..\..\SavedFiles\" + s + ".bin")) //Same process as Serialize but instead of create we use OpenRead
            {
                BinaryFormatter deserializer = new BinaryFormatter(); //Creates a new binaryFormatter that will give us access to the Deseralize function
                //We then call the Deserialize method and give it the arguments of the FileStream we created that contains all the data inside of the file
                //we opened and are reading from.
                //We take all this information and cast it as the return type and then set the variable we created at the head of the function equal to the
                //value of the Deseaialize method
                t = (T)deserializer.Deserialize(fs);
                fs.Close(); //Allways close your files when you are done using them
            }
            return t; //We then return t
        }
    }

    public class Serializer
    {
        public void Serialize()
        {
            
        }
    }
}
