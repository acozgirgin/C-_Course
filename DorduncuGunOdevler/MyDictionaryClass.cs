using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorduncuGunOdevler
{
    public class MyDictionaryClass<T, K>
    {
        private T[] Keys { get; set; } // Array holds keys

        private K[] Values { get; set; } // Array holds values

        public MyDictionaryClass() { Keys = new T[0]; Values = new K[0]; }  // constructor initiliazes Key and Value pair arrays


        // Add new Key-Value pair
        public void Add( T newKey,  K newValue)
        {

            T[] tempKeys = this.Keys;
            K[] tempVals = this.Values;

            Keys = new T[Keys.Length + 1]; // Extend Keys array + 1
            Values = new K[Values.Length + 1]; // Extend Values array+1


            // Fill Keys and Vallues arrays with their old values 
            for (int i = 0; i < Keys.Length - 1; i++)
            {
                Keys[i] = tempKeys[i];
                Values[i] = tempVals[i];
            }

            Keys[Keys.Length-1] = newKey; // Add new key to array
            Values[Values.Length-1] = newValue; // Add new value to array



        }

        // Get Value for the input key
        public K GetValue(T itemKey)
        {
            // Searches for itemKey in Keys array 
            for (int i=0; i <Keys.Length; i++)
            {
                if ( itemKey.Equals(Keys[i])) return Values[i];  // if it's in the list return the Value of the key
            }

            Console.WriteLine("Key was not found ! ");
            return default(K); // returns default values of the K type

        }

        // Removes corresponding value to given key as a input parameter
        public void Remove (T keyToRemove)
        {

            // Copy the old key and value pair arrays
            T[] tempKeys = this.Keys; 
            K[] tempVals = this.Values;

            int removedElementIndex=0;

            // Find the given key value's index 
            for (int i=0; i < Keys.Length; i++)
            {
                if ( keyToRemove.Equals(Keys[i]))
                {
                    removedElementIndex = i; // index of the a element that will be deleted
                }
            }

            // Create new key and values array : len = len - 1
            Keys = new T[Keys.Length - 1];
            Values = new K[Values.Length - 1];


            if ( removedElementIndex != 0 )
            {
                Console.WriteLine("Key : {0} value is deleted from the dictionary \n",keyToRemove);
                for (int j=0; j< Keys.Length ; j++)
                {

                    // Add the elements before the index of removed element from old array
                    if(j < removedElementIndex)
                    {
                        Keys[j] = tempKeys[j];
                        Values[j] = tempVals[j];
                    }

                    // Add the rest of the elements after the removed element from old array
                    else
                    {
                        Keys[j] = tempKeys[j + 1];
                        Values[j] = tempVals[j + 1];
                    }
                }   
            }

            else
            {
                Console.WriteLine("Key was not found ! ");
            }


        }

        // Method to list all the key - value pairs in the Dictionary 
        public void ListAllPairs()
        {

            Console.WriteLine("List of all key - value pairs in the dictionary: ");
            for (int i = 0; i < Keys.Length; i++)
            {

                Console.WriteLine("Key : {0} , Value: {1} ", Keys[i], Values[i]);

            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------------\n");

        }


        // Clear the key and value pairs
        public void Clear()
        {
            Keys = new T[0];
            Values = new K[0];

        }


    }
}
