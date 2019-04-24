using System;
using System.Collections.Generic;

namespace Anagram
{
    public class Anagram
    {
        private string _word; 
        private List<string> _testList;
        public Anagram (string word, List<string> testList)
        {
            _word = word;
            _testList = testList;
        }

        public string GetWord()
        {
            return _word;
        }
        public List<string> GetTestList()
        {
            return _testList;
        }

        public bool CheckIfAnagram(string stringToCheck)
        {
            if (_word.Length != stringToCheck.Length)
            {
                return false;
            }
            else if (_word == stringToCheck)
            {
                return true;
            } 
            else
            {
                // Make _word & stringToCheck into arrays
                // Sort the arrays and compare them
                char[] splitWord = ConvertWordToArray(_word);
                char[] splitStringToTest = ConvertWordToArray(stringToCheck);
                splitWord = SortArray(splitWord);
                splitStringToTest = SortArray(splitStringToTest);
                string splitWordJoined = String.Join("", splitWord);
                string splitStringToTestJoined = String.Join("", splitStringToTest);
                if ( splitWordJoined == splitStringToTestJoined)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public char[] ConvertWordToArray(string stringToConvert)
        {
            // char[] convertedString = stringToConvert.ToCharArray();
            return stringToConvert.ToCharArray();
        }
        public char[] SortArray(char[] splitWord)
        {
            Array.Sort(splitWord);
            return splitWord;
        }
    }
}