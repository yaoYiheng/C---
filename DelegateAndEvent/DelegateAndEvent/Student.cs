using System;
namespace DelegateAndEvent
{
    public class Student
    {
        public int Age;
        public int Score;

        public Student(int age, int score)
        {
            this.Age = age;
            this.Score = score;
        }
        public void show()
        {
            Console.WriteLine("年龄: " + Age + "分数: "+Score);
        }

        public static int CompareAge(Student s1, Student s2)
        {
            return s1.Age - s2.Age;
        }

        public static int CompareScore(Student s1, Student s2)
        {
            return s1.Score - s2.Score;
        }
    }
}
