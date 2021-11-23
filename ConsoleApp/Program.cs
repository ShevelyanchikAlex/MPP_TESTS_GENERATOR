using System;
using System.Collections.Generic;
using TestGenerator;

namespace ConsoleApp
{
    class Program
    {
        private const string SourceFilePath1 =
            "D:\\Study\\5SEM\\MPP\\MPP_LAB_4\\MPP_TEST_GENERATOR\\TestClassLib\\ClassExample1.cs";

        private const string SourceFilePath2 =
            "D:\\Study\\5SEM\\MPP\\MPP_LAB_4\\MPP_TEST_GENERATOR\\TestClassLib\\ClassExample3.cs";

        private const string OutDirPath = "D:\\Study\\5SEM\\MPP\\MPP_LAB_4\\MPP_TEST_GENERATOR\\GenClasses";

        private const int MaxParallelTasksCount = 3;


        static void Main(string[] args)
        {
            var testsGenerator = new TestsGenerator(MaxParallelTasksCount);
            testsGenerator.Generate(new List<string>() {SourceFilePath1, SourceFilePath2}, OutDirPath).Wait();
        }
    }
}