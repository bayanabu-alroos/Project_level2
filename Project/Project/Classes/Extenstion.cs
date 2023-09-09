using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Extenstion
    {
        private static Random random = new Random();

        public static string CreateRandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] stringChar = new char[length];

            for (int i = 0; i < stringChar.Length; i++)
            {
                stringChar[i] = chars[random.Next(chars.Length)];
            }
            return new string(stringChar);
        }


        public static T[] CreateRandomArray<T>(int size) where T : IConvertible
        {
            T[] array = new T[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = (T)Convert.ChangeType(random.NextDouble(), typeof(T));
            }

            return array;
        }
        public static int GetRandomInt(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}
