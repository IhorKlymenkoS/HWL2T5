using System;

namespace Task_5
{
    class Program
    {
        static string Task1(int n1, int n2)
        {
            
            string w1 = " ";
            string w2 = " ";

            switch (n1)
            {
                case 1:
                    w1 = " ";
                    break;
                case 2:
                    w1 = "twenty";
                    break;
                case 3:
                    w1 = "trirty";
                    break;
                case 4:
                    w1 = "forty";
                    break;
                case 5:
                    w1 = "fifty";
                    break;
                case 6:
                    w1 = "sixty";
                    break;
                case 7:
                    w1 = "seventy";
                    break;
                case 8:
                    w1 = "eighty";
                    break;
                case 9:
                    w1 = "ninety";
                    break;
                default:
                    w1 = " ";
                    break;

            }
            switch (n2)
            {
                case 1:
                    w2 = "one";
                    break;
                case 2:
                    w2 = "two";
                    break;
                case 3:
                    w2 = "tree";
                    break;
                case 4:
                    w2 = "four";
                    break;
                case 5:
                    w2 = "five";
                    break;
                case 6:
                    w2 = "six";
                    break;
                case 7:
                    w2 = "seven";
                    break;
                case 8:
                    w2 = "eight";
                    break;
                case 9:
                    w2 = "nine";
                    break;
                default:
                    w2 = " ";
                    break;

            }

            if (n1 == 1)
            {
                w1 = " ";
                switch (n2)
                {
                    case 1:
                        w2 = "eleven";
                        break;
                    case 2:
                        w2 = "twelve";
                        break;
                    case 3:
                        w2 = "thirteen";
                        break;
                    case 4:
                        w2 = "fourteen";
                        break;
                    case 5:
                        w2 = "fifteen";
                        break;
                    case 6:
                        w2 = "sixteen";
                        break;
                    case 7:
                        w2 = "seventeen";
                        break;
                    case 8:
                        w2 = "eighteen";
                        break;
                    case 9:
                        w2 = "nineteen";
                        break;
                    default:
                        w2 = "ten";
                        break;
                }

            


            }

            string w3 = w1 +" "+ w2;
            return w3;
        }

        static void Main()
        {
            string resolt = Task1(2, 2);

            Console.WriteLine(resolt);

        }
    }
}

