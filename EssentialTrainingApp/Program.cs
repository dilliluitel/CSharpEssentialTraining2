using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("The program started.");
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProblem();
            readTextFile();
            Console.ReadLine();

        }
        private static void readTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))   //@-verbatim formatting
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the directory.");
                logger.Error("The directory was not found. " + ex.Message);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the file.");
                logger.Error(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unknown error occurred" + ex.Message);
            }
            finally
            {
                Console.WriteLine("The finally runs all the time.");
            }
        }
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i = 10; i > 0; i--)
                income /= i;
            return income;
        }
    }
}

