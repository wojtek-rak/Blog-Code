using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Text;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }

    [MemoryDiagnoser]
    public class SingleLineJoin
    {
        public const int length = 1;
        public const int length_20 = 20;
        public const int length_40 = 40;
        public const int length_60 = 60;
        public const int length_80 = 80;
        public const int length_100 = 100;
        public string string1 = "1";
        public string string2 = "2";
        public string string3 = "3";
        public string string4 = "4";
        public string string5 = "5";
        public string string6 = "6";
        public string string7 = "7";
        public string string8 = "8";
        public string string9 = "9";
        public string string10 = "10";

        [Benchmark]
        public string Interpolation_2()
        {
            return $"{string1} {string2}";
        }

        [Benchmark]
        public string Interpolation_3()
        {
            return $"{string1} {string2} {string3}";
        }

        [Benchmark]
        public string Interpolation_4()
        {
            return $"{string1} {string2} {string3} {string4}";
        }

        [Benchmark]
        public string Interpolation_5()
        {
            return $"{string1} {string2} {string3} {string4} {string5}";
        }

        [Benchmark]
        public string Interpolation_6()
        {
            return $"{string1} {string2} {string3} {string4} {string5} {string6}";
        }

        [Benchmark]
        public string Interpolation_7()
        {
            return $"{string1} {string2} {string3} {string4} {string5} {string6} {string7}";
        }

        [Benchmark]
        public string Interpolation_8()
        {
            return $"{string1} {string2} {string3} {string4} {string5} {string6} {string7} {string8}";
        }

        [Benchmark]
        public string Interpolation_9()
        {
            return $"{string1} {string2} {string3} {string4} {string5} {string6} {string7} {string8} {string9}";
        }

        [Benchmark]
        public string Interpolation_10()
        {
            return $"{string1} {string2} {string3} {string4} {string5} {string6} {string7} {string8} {string9} {string10}";
        }

        [Benchmark]
        public string InterpolationFor()
        {
            var start = "";

            for (int i = 0; i < length; i++)
            {
                start = $"{start} {string1}";
            }

            return start;
        }

        [Benchmark]
        public string PlusOperator_2()
        {
            return string1 + " " + string2;
        }

        [Benchmark]
        public string PlusOperator_3()
        {
            return string1 + " " + string2 + " " + string3;
        }

        [Benchmark]
        public string PlusOperator_4()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4;
        }

        [Benchmark]
        public string PlusOperator_5()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5;
        }

        [Benchmark]
        public string PlusOperator_6()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6;
        }

        [Benchmark]
        public string PlusOperator_7()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6 + " " + string7;
        }

        [Benchmark]
        public string PlusOperator_8()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6 + " " + string7 + " " + string8;
        }

        [Benchmark]
        public string PlusOperator_9()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6 + " " + string7 + " " + string8 + " " + string9;
        }

        [Benchmark]
        public string PlusOperator_10()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6 + " " + string7 + " " + string8 + " " + string9 + " " + string10;
        }

        [Benchmark]
        public string PlusOperatorFor()
        {
            var start = "";

            for (int i = 0; i < length; i++)
            {
                start = start + " " + string1;
            }

            return start;
        }

        [Benchmark]
        public string StringConcatenate_2()
        {
            return string.Concat(string1, " ", string2);
        }

        [Benchmark]
        public string StringConcatenate_3()
        {
            return string.Concat(string1, " ", string2, " ", string3);
        }

        [Benchmark]
        public string StringConcatenate_4()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4);
        }

        [Benchmark]
        public string StringConcatenate_5()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5);
        }

        [Benchmark]
        public string StringConcatenate_6()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6);
        }

        [Benchmark]
        public string StringConcatenate_7()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6, " ", string7);
        }

        [Benchmark]
        public string StringConcatenate_8()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6, " ", string7, " ", string8);
        }

        [Benchmark]
        public string StringConcatenate_9()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6, " ", string7, " ", string8, " ", string9);
        }

        [Benchmark]
        public string StringConcatenate_10()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6, " ", string7, " ", string8, " ", string9, " ", string10);
        }

        [Benchmark]
        public string StringConcatenateFor()
        {
            var start = "";

            for (int i = 0; i < length; i++)
            {
                start = string.Concat(start, " ", string1);
            }

            return start;
        }

        [Benchmark]
        public string StringJoin_2()
        {
            return string.Join(" ", string1, string2);
        }

        [Benchmark]
        public string StringJoin_3()
        {
            return string.Join(" ", string1, string2, string3);
        }

        [Benchmark]
        public string StringJoin_4()
        {
            return string.Join(" ", string1, string2, string3, string4);
        }

        [Benchmark]
        public string StringJoin_5()
        {
            return string.Join(" ", string1, string2, string3, string4, string5);
        }

        [Benchmark]
        public string StringJoin_6()
        {
            return string.Join(" ", string1, string2, string3, string4, string5, string6);
        }

        [Benchmark]
        public string StringJoin_7()
        {
            return string.Join(" ", string1, string2, string3, string4, string5, string6, string7);
        }

        [Benchmark]
        public string StringJoin_8()
        {
            return string.Join(" ", string1, string2, string3, string4, string5, string6, string7, string8);
        }

        [Benchmark]
        public string StringJoin_9()
        {
            return string.Join(" ", string1, string2, string3, string4, string5, string6, string7, string8, string9);
        }

        [Benchmark]
        public string StringJoin_10()
        {
            return string.Join(" ", string1, string2, string3, string4, string5, string6, string7, string8, string9, string10);
        }

        public string StringJoinFor()
        {
            var start = "";

            for (int i = 0; i < length; i++)
            {
                start = string.Join(" ", start, string1);
            }

            return start;
        }

        [Benchmark]
        public string StringFormat_2()
        {
            return string.Format("{0} {1}", string1, string2);
        }

        [Benchmark]
        public string StringFormat_3()
        {
            return string.Format("{0} {1} {2}", string1, string2, string3);
        }

        [Benchmark]
        public string StringFormat_4()
        {
            return string.Format("{0} {1} {2} {3}", string1, string2, string3, string4);
        }

        [Benchmark]
        public string StringFormat_5()
        {
            return string.Format("{0} {1} {2} {3} {4}", string1, string2, string3, string4, string5);
        }

        [Benchmark]
        public string StringFormat_6()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", string1, string2, string3, string4, string5, string6);
        }

        [Benchmark]
        public string StringFormat_7()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}", string1, string2, string3, string4, string5, string6, string7);
        }

        [Benchmark]
        public string StringFormat_8()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", string1, string2, string3, string4, string5, string6, string7, string8);
        }

        [Benchmark]
        public string StringFormat_9()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", string1, string2, string3, string4, string5, string6, string7, string8, string9);
        }

        [Benchmark]
        public string StringFormat_10()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", string1, string2, string3, string4, string5, string6, string7, string8, string9, string10);
        }

        [Benchmark]
        public string StringFormatFor()
        {
            var start = "";

            for (int i = 0; i < length; i++)
            {
                start = string.Format("{0} {1}", start, string1);
            }

            return start;
        }

        [Benchmark]
        public string StringBuilderAppend_2()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppend_3()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            builder.Append(string3);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppend_4()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            builder.Append(string3);
            builder.Append(" ");
            builder.Append(string4);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppend_5()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            builder.Append(string3);
            builder.Append(" ");
            builder.Append(string4);
            builder.Append(" ");
            builder.Append(string5);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppend_6()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            builder.Append(string3);
            builder.Append(" ");
            builder.Append(string4);
            builder.Append(" ");
            builder.Append(string5);
            builder.Append(" ");
            builder.Append(string6);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppend_7()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            builder.Append(string3);
            builder.Append(" ");
            builder.Append(string4);
            builder.Append(" ");
            builder.Append(string5);
            builder.Append(" ");
            builder.Append(string6);
            builder.Append(" ");
            builder.Append(string7);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppend_8()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            builder.Append(string3);
            builder.Append(" ");
            builder.Append(string4);
            builder.Append(" ");
            builder.Append(string5);
            builder.Append(" ");
            builder.Append(string6);
            builder.Append(" ");
            builder.Append(string7);
            builder.Append(" ");
            builder.Append(string8);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppend_9()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            builder.Append(string3);
            builder.Append(" ");
            builder.Append(string4);
            builder.Append(" ");
            builder.Append(string5);
            builder.Append(" ");
            builder.Append(string6);
            builder.Append(" ");
            builder.Append(string7);
            builder.Append(" ");
            builder.Append(string8);
            builder.Append(" ");
            builder.Append(string9);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppend_10()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            builder.Append(string3);
            builder.Append(" ");
            builder.Append(string4);
            builder.Append(" ");
            builder.Append(string5);
            builder.Append(" ");
            builder.Append(string6);
            builder.Append(" ");
            builder.Append(string7);
            builder.Append(" ");
            builder.Append(string8);
            builder.Append(" ");
            builder.Append(string9);
            builder.Append(" ");
            builder.Append(string10);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppendFor()
        {
            var start = "";
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                builder.Append(start);
                builder.Append(" ");
                builder.Append(string1);
            }

            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppendForNew()
        {
            var start = "";

            for (int i = 0; i < length; i++)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(start);
                builder.Append(" ");
                builder.Append(string1);
            }

            return "";
        }
    }
}
