using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRedButtonQuiz
{
    internal class QuizParser
    {
        public string FilePath { get; private set; }

        public QuizParser(string sourceFile)
        {
            FilePath = sourceFile;
        }

        public List<QuestionAnswer> Parse()
        {
            List<QuestionAnswer> questionsAnswers = new List<QuestionAnswer>();
            using (StreamReader sr = new StreamReader(FilePath))
            {
                QuestionAnswer current = new QuestionAnswer();
                int counter = 0;
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    if (line.StartsWith("?"))
                    {
                        if (counter > 0)
                        {
                            questionsAnswers.Add(current);
                            current = new QuestionAnswer();
                            counter = 0;
                        }
                        current.Question = line.Substring(1).ToString();
                        
                    }
                    else if (line.StartsWith("!"))
                    {
                        current.Answers.Add(line.Substring(1).ToString());   
                    }
                    else if (line.StartsWith("&"))
                    {
                        current.Answers.Add(line.Substring(1).ToString());
                        current.CorrectAnswerIndex = counter - 1;
                    }
                    //end of the file
                    else if(line.StartsWith("#"))
                    {
                        questionsAnswers.Add(current);
                    }

                    counter++;
                }
                sr.Close();
            }

            return questionsAnswers;
        }
    }
}
