using System;
using System.Collections;

namespace TDDMain
{
    class MainClass
    {

		public static string convertGrade(string americanGrade){
			var grade = -1;

			ArrayList americanGradeList = new ArrayList();
			americanGradeList.Add("A");
			americanGradeList.Add("B");
			americanGradeList.Add("C");
			americanGradeList.Add("D");
			americanGradeList.Add("E");
			americanGradeList.Add("Fx");
			americanGradeList.Add("F");

			if (americanGradeList.Contains(americanGrade) == true)
            {
				grade = americanGradeList.IndexOf(americanGrade);
            }


            ArrayList danishGradeList = new ArrayList();
            danishGradeList.Add("12");
            danishGradeList.Add("10");
            danishGradeList.Add("7");
            danishGradeList.Add("4");
            danishGradeList.Add("02");
            danishGradeList.Add("00");
            danishGradeList.Add("-3");

			Console.WriteLine(danishGradeList[grade]);
			return (string)danishGradeList[grade];
		}

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

			convertGrade("A");
        }
    }
}
