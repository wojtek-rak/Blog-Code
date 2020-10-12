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

    [CsvExporter]
    [CsvMeasurementsExporter]
    [MemoryDiagnoser]
    public class SingleLineJoin
    {
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

        //Interpolation

        [Benchmark]
        public string Interpolation_2_Strings()
        {
            return $"{string1}{string2}";
        }

        [Benchmark]
        public string Interpolation_3_Strings()
        {
            return $"{string1} {string2}";
        }

        [Benchmark]
        public string Interpolation_5_Strings()
        {
            return $"{string1} {string2} {string3}";
        }

        [Benchmark]
        public string Interpolation_7_Strings()
        {
            return $"{string1} {string2} {string3} {string4}";
        }

        [Benchmark]
        public string Interpolation_9_Strings()
        {
            return $"{string1} {string2} {string3} {string4} {string5}";
        }

        [Benchmark]
        public string Interpolation_11_Strings()
        {
            return $"{string1} {string2} {string3} {string4} {string5} {string6}";
        }

        [Benchmark]
        public string Interpolation_13_Strings()
        {
            return $"{string1} {string2} {string3} {string4} {string5} {string6} {string7}";
        }

        [Benchmark]
        public string Interpolation_15_Strings()
        {
            return $"{string1} {string2} {string3} {string4} {string5} {string6} {string7} {string8}";
        }

        [Benchmark]
        public string Interpolation_17_Strings()
        {
            return $"{string1} {string2} {string3} {string4} {string5} {string6} {string7} {string8} {string9}";
        }

        [Benchmark]
        public string Interpolation_19_Strings()
        {
            return $"{string1} {string2} {string3} {string4} {string5} {string6} {string7} {string8} {string9} {string10}";
        }

        //Plus

        [Benchmark]
        public string PlusOperator_2_Strings()
        {
            return string1 + string2;
        }

        [Benchmark]
        public string PlusOperator_3_Strings()
        {
            return string1 + " " + string2;
        }

        [Benchmark]
        public string PlusOperator_5_Strings()
        {
            return string1 + " " + string2 + " " + string3;
        }

        [Benchmark]
        public string PlusOperator_7_Strings()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4;
        }

        [Benchmark]
        public string PlusOperator_9_Strings()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5;
        }

        [Benchmark]
        public string PlusOperator_11_Strings()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6;
        }

        [Benchmark]
        public string PlusOperator_13_Strings()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6 + " " + string7;
        }

        [Benchmark]
        public string PlusOperator_15_Strings()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6 + " " + string7 + " " + string8;
        }

        [Benchmark]
        public string PlusOperator_17_Strings()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6 + " " + string7 + " " + string8 + " " + string9;
        }

        [Benchmark]
        public string PlusOperator_19_Strings()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6 + " " + string7 + " " + string8 + " " + string9 + " " + string10;
        }

        //Concat

        [Benchmark]
        public string StringConcatenate_2_Strings()
        {
            return string.Concat(string1, string2);
        }

        [Benchmark]
        public string StringConcatenate_3_Strings()
        {
            return string.Concat(string1, " ", string2);
        }

        [Benchmark]
        public string StringConcatenate_5_Strings()
        {
            return string.Concat(string1, " ", string2, " ", string3);
        }

        [Benchmark]
        public string StringConcatenate_7_Strings()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4);
        }

        [Benchmark]
        public string StringConcatenate_9_Strings()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5);
        }

        [Benchmark]
        public string StringConcatenate_11_Strings()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6);
        }

        [Benchmark]
        public string StringConcatenate_13_Strings()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6, " ", string7);
        }

        [Benchmark]
        public string StringConcatenate_15_Strings()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6, " ", string7, " ", string8);
        }

        [Benchmark]
        public string StringConcatenate_17_Strings()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6, " ", string7, " ", string8, " ", string9);
        }

        [Benchmark]
        public string StringConcatenate_19_Strings()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6, " ", string7, " ", string8, " ", string9, " ", string10);
        }

        //Join

        [Benchmark]
        public string StringJoin_2_Strings()
        {
            return string.Join("", string1, string2);
        }

        [Benchmark]
        public string StringJoin_3_Strings()
        {
            return string.Join(" ", string1, string2);
        }

        [Benchmark]
        public string StringJoin_5_Strings()
        {
            return string.Join(" ", string1, string2, string3);
        }

        [Benchmark]
        public string StringJoin_7_Strings()
        {
            return string.Join(" ", string1, string2, string3, string4);
        }

        [Benchmark]
        public string StringJoin_9_Strings()
        {
            return string.Join(" ", string1, string2, string3, string4, string5);
        }

        [Benchmark]
        public string StringJoin_11_Strings()
        {
            return string.Join(" ", string1, string2, string3, string4, string5, string6);
        }

        [Benchmark]
        public string StringJoin_13_Strings()
        {
            return string.Join(" ", string1, string2, string3, string4, string5, string6, string7);
        }

        [Benchmark]
        public string StringJoin_15_Strings()
        {
            return string.Join(" ", string1, string2, string3, string4, string5, string6, string7, string8);
        }

        [Benchmark]
        public string StringJoin_17_Strings()
        {
            return string.Join(" ", string1, string2, string3, string4, string5, string6, string7, string8, string9);
        }

        [Benchmark]
        public string StringJoin_19_Strings()
        {
            return string.Join(" ", string1, string2, string3, string4, string5, string6, string7, string8, string9, string10);
        }

        //Format

        [Benchmark]
        public string StringFormat_2_Strings()
        {
            return string.Format("{0}{1}", string1, string2);
        }

        [Benchmark]
        public string StringFormat_3_Strings()
        {
            return string.Format("{0} {1}", string1, string2);
        }

        [Benchmark]
        public string StringFormat_5_Strings()
        {
            return string.Format("{0} {1} {2}", string1, string2, string3);
        }

        [Benchmark]
        public string StringFormat_7_Strings()
        {
            return string.Format("{0} {1} {2} {3}", string1, string2, string3, string4);
        }

        [Benchmark]
        public string StringFormat_9_Strings()
        {
            return string.Format("{0} {1} {2} {3} {4}", string1, string2, string3, string4, string5);
        }

        [Benchmark]
        public string StringFormat_11_Strings()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", string1, string2, string3, string4, string5, string6);
        }

        [Benchmark]
        public string StringFormat_13_Strings()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}", string1, string2, string3, string4, string5, string6, string7);
        }

        [Benchmark]
        public string StringFormat_15_Strings()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", string1, string2, string3, string4, string5, string6, string7, string8);
        }

        [Benchmark]
        public string StringFormat_17_Strings()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", string1, string2, string3, string4, string5, string6, string7, string8, string9);
        }

        [Benchmark]
        public string StringFormat_19_Strings()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", string1, string2, string3, string4, string5, string6, string7, string8, string9, string10);
        }

        //StringBuilder

        [Benchmark]
        public string StringBuilderAppend_2_Strings()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(string2);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppend_3_Strings()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            return builder.ToString();
        }

        [Benchmark]
        public string StringBuilderAppend_5_Strings()
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
        public string StringBuilderAppend_7_Strings()
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
        public string StringBuilderAppend_9_Strings()
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
        public string StringBuilderAppend_11_Strings()
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
        public string StringBuilderAppend_13_Strings()
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
        public string StringBuilderAppend_15_Strings()
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
        public string StringBuilderAppend_17_Strings()
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
        public string StringBuilderAppend_19_Strings()
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

        ////For loops

        //[Benchmark]
        //public string InterpolationFor()
        //{
        //    var start = "";

        //    for (int i = 0; i < length; i++)
        //    {
        //        start = $"{start} {string1}";
        //    }

        //    return start;
        //}

        //[Benchmark]
        //public string PlusOperatorFor()
        //{
        //    var start = "";

        //    for (int i = 0; i < length; i++)
        //    {
        //        start = start + " " + string1;
        //    }

        //    return start;
        //}

        //[Benchmark]
        //public string StringConcatenateFor()
        //{
        //    var start = "";

        //    for (int i = 0; i < length; i++)
        //    {
        //        start = string.Concat(start, " ", string1);
        //    }

        //    return start;
        //}

        //[Benchmark]
        //public string StringJoinFor()
        //{
        //    var start = "";

        //    for (int i = 0; i < length; i++)
        //    {
        //        start = string.Join(" ", start, string1);
        //    }

        //    return start;
        //}

        //[Benchmark]
        //public string StringFormatFor()
        //{
        //    var start = "";

        //    for (int i = 0; i < length; i++)
        //    {
        //        start = string.Format("{0} {1}", start, string1);
        //    }

        //    return start;
        //}

        //[Benchmark]
        //public string StringBuilderAppendFor()
        //{
        //    var start = "";
        //    StringBuilder builder = new StringBuilder();

        //    for (int i = 0; i < length; i++)
        //    {
        //        builder.Append(start);
        //        builder.Append(" ");
        //        builder.Append(string1);
        //    }

        //    return builder.ToString();
        //}

        //[Benchmark]
        //public string StringBuilderAppendForNew()
        //{
        //    var start = "";

        //    for (int i = 0; i < length; i++)
        //    {
        //        StringBuilder builder = new StringBuilder();
        //        builder.Append(start);
        //        builder.Append(" ");
        //        builder.Append(string1);
        //    }

        //    return "";
        //}

        [Benchmark]
        public string Interpolation_4_Strings()
        {
            return $"{string1} {string2} ";
        }

        [Benchmark]
        public string PlusOperator_4_Strings()
        {
            return string1 + " " + string2 + " ";
        }

        [Benchmark]
        public string StringConcatenate_4_Strings()
        {
            return string.Concat(string1, " ", string2, " ");
        }

        [Benchmark]
        public string StringBuilderAppend_4_Strings()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            return builder.ToString();
        }
    }
}