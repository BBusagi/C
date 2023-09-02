using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project011_string
{
    class StringDS
    {
        private char[] data;
        public StringDS(char[] array)
        {
            data = new char[array.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = array[i];
            }
        }
        public StringDS(string str)
        {
            data = new char[str.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = str[i];
            }
        }
        public char this[int index]
        {
            get { return data[index]; }
        }

        public int GetLength()
        {
            return data.Length;
        }

        //对比两个字符串，若相同返回0，若小于s，返回-1，若大于s，返回1
        public int Compare(StringDS s)
        {
            int len = this.GetLength() < s.GetLength() ? this.GetLength() : s.GetLength() ;
            int index = -1;
            for (int i = 0; i < len; i++)
            {
                if (this[i] != s[i])
                {
                    index = i;
                    break;                
                }
            }

            if (index != -1)
            {
                if(this[index] > s[index]) 
                { return 1; }
                else { return -1; }
            }
            else 
            {
                if (this.GetLength() == s.GetLength())
                {
                    return 0;
                }
                else 
                {
                    if (this.GetLength() > s.GetLength())
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public StringDS SubString(int index, int length)
        {
            char[] newData = new char[length];
            for (int i = index; i < index + length; i++)
            {
                newData[i - index] = data[i];
            }
            return new StringDS(newData);
        }

        public static StringDS Concat(StringDS s1, StringDS s2)
        {
            char[] newData = new char[s1.GetLength() + s2.GetLength()];
            for (int i = 0; i < s1.GetLength(); i++)
            {
                newData[i] = s1[i];
            }
            for (int i = s1.GetLength(); i < newData.Length; i++)
            {
                newData[i] = s2[i - s1.GetLength()];
            }

            return new StringDS(newData);
        }

        public int IndexOf(StringDS s)
        {
            for (int i = 0; i <= this.GetLength() - s.GetLength(); i++)
            {
                bool isEqual = true;
                for (int j = i; j < i + s.GetLength(); j++)
                {
                    if (this[j] != s[j - i])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual)
                {
                    return i;
                }
                else 
                {
                    continue;
                }
            }
            return -1;
        }

        public string ToString()
        {
            return new string(data);
        }

        public StringDS Copy()
        {
            char[] newStr = new char[this.GetLength()];
            for (int i = 0; i < this.GetLength(); i++)
            {
                newStr[i] = this[i];
            }
            return new StringDS(newStr);

        }

        public StringDS Replace(StringDS t, StringDS r)
        {
            char[] newStr = new char[this.GetLength()];
            int index2 = this.IndexOf(t);
            for (int i = 0; i < index2; i++)
            {
                newStr[i] = this[i];
            }

            for (int i = index2; i < this.GetLength()+1; i++)
            {
                newStr[i] = t[i - index2];
            }
            return new StringDS(newStr);
        }
    }
}
