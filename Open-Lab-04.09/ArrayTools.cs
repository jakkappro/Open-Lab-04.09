using System;
using System.Collections.Generic;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            List<string> ret = new List<string>();
            foreach (string item in strings)
            {
                if (!ret.Contains(item))
                {
                    ret.Add(item);
                }    
            }

            return ret.ToArray();

        }
    }
}
