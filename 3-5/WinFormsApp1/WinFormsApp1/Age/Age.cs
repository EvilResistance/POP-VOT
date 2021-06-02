using System;

namespace WinFormsApp1.Age
{
    [Serializable]
    public class Age
    {
        public int CurrentAge { get; set; }

        public Age()
        { }
        public Age(int age)
        {
            CurrentAge = age;
        }
    }
}
