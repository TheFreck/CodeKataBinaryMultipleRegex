using Machine.Specifications;
namespace CodeKataBinaryMultipleRegex.Specs
{
    public class When_Dividing_Binary_Numbers
    {
        Establish context = () =>
        {
            inputs = new string[][]
            {
                new string[]{"10","10" },
                new string[]{"1111","101"},
                new string[]{"10100","10"},
                new string[]{"10100","100"},
            };
            binaryRegexp = new BinaryRegexp();
        };

        Because of = () =>
        {
            for(var i=0; i<inputs.Length; i++)
            {
                answers[i] = binaryRegexp.Divide(inputs[i][0], inputs[i][1]);
            }
        };

        It Should_Return_Divided_Binary_As_String = () =>
        {
            for (var i = 0; i < answers.Length; i++)
            {
                answers[i].ShouldEqual(expected[i]);
            }
        };

        private static string[][] inputs;
        private static BinaryRegexp binaryRegexp;
        private static string[] answers;
        private static string[] expected;
    }

    public class When_Comparaing_Two_Binary_Numbers
    {
        Establish context = () =>
        {
            input = new string[][]
            {
                new string[]{"1","0"},
                new string[]{"11","10"},
                new string[]{"101","111"},
                new string[]{"111","1000"}
            };
            expect = new string[]
            {
                "1","11","111","1000"
            };
            binaryRegexp = new BinaryRegexp();
            answers = new string[expect.Length];
        };

        Because of = () =>
        {
            for (var i = 0; i < input.Length; i++)
            {
                answers[i] = binaryRegexp.GetLarger(input[i][0], input[i][1]);
            }
        };
        It Should_Return_The_Correct_Answers = () => answers.ShouldEqual(expect);
        It Should_Return_Larger_Binary_String = () =>
        {
            for (var i = 0; i < answers.Length; i++)
            {
                answers[i].ShouldEqual(expect[i]);
            }
        };

        private static string[][] input;
        private static string[] expect;
        private static BinaryRegexp binaryRegexp;
        private static string[] answers;
    }

    public class When_Subtracting_Two_Binary_Numbers
    {
        Establish context = () =>
        {
            input = new string[][]
            {
                //new string[]{"111","11" },
                new string[]{"10101","1111"}
            };
            expect = new string[]
            {
                //"100",
                "110"
            };
            answers = new string[expect.Length];
            binaryRegexp = new BinaryRegexp();
        };

        Because of = () =>
        {
            for (var i = 0; i < input.Length; i++)
            {
                answers[i] = binaryRegexp.Subtract(input[i][0].ToCharArray(), input[i][1].ToCharArray());
            }
        };

        It Should_Return_Correct_Difference = () =>
        {
            for (var i = 0; i < input.Length; i++)
            {
                answers[i].ShouldEqual(expect[i]);
            }
        };

        private static string[][] input;
        private static string[] expect;
        private static string[] answers;
        private static BinaryRegexp binaryRegexp;
    }

    public class When_Parsing_A_Binary_From_A_String
    {
        Establish context = () =>
        {
            input = new string[]
            {
                "0",
                "1",
                "10",
                "11",
                "100",
                "101",
                "110",
                "111",
                "1000",
                "1001",
                "1010",
                "1011",
                "1100",
                "1101",
                "1110",
                "1111"
            };
            expect = new int[]
            {
                0,
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12,
                13,
                14,
                15
            };
            br = new BinaryRegexp();
            answer = new int[input.Length];
        };

        Because of = () =>
        {
            for (var i = 0; i < input.Length; i++)
            {
                answer[i] = br.Parse(input[i]);
            }
        };

        It Should_Return_Correct_Int = () =>
        {
            for (var i = 0; i < input.Length; i++)
            {
                answer[i].ShouldEqual(expect[i]);
            }
        };

        private static string[] input;
        private static int[] expect;
        private static BinaryRegexp br;
        private static int[] answer;
    }

    public class When_Getting_Binary_Numbers_Divisible_By_Seven
    {
        Establish context = () =>
        {
            input = 100;
            expect = new string[]
            {
                "1"
            };
            br = new BinaryRegexp();
        };

        Because of = () => answers = br.FindSevens(input);
        private static int input;
        private static string[] expect;
        private static BinaryRegexp br;
        private static string[] answers;
    }

    public class When_Converting_Decimal_To_Binary
    {
        Establish context = () =>
        {
            input = new int[] { 0, 1, 2, 3 };
            expect = new string[] { "0", "1", "10", "11" };
            answers = new string[input.Length];
            br = new BinaryRegexp();
        };

        Because of = () =>
        {
            for (int i = 0; i < input.Length; i++)
            {
                answers[i] = br.DecToBin(input[i]);
            }
        };

        It Should_Return_Correct_Binary = () =>
        {
            for (var i = 0; i < answers.Length; i++)
            {
                answers[i].ShouldEqual(expect[i]);
            }
        };

        private static int[] input;
        private static string[] expect;
        private static string[] answers;
        private static BinaryRegexp br;
    }

    public class When_Finding_The_Largest_Multiple_Of_2_Smaller_Than_N
    {
        Establish context = () =>
        {
            input = new int[] { 0, 1, 3, 15, 21, 76, 139982 };
            expect = new int[] { 0, 1, 2, 8, 16, 64, 131072 };
            answer = new int[input.Length];

            br = new BinaryRegexp();
        };

        Because of = () =>
        {
            for (var i = 0; i < input.Length; i++)
            {
                answer[i] = br.LargestBinaryMultiple(input[i]);
            }
        };

        It Should_Return_The_Largest_Binary_Multiple_Smaller_Than_The_Input = () =>
        {
            for (var i = 0; i < expect.Length; i++)
            {
                answer[i].ShouldEqual(expect[i]);
            }
        };

        private static int[] input;
        private static int[] expect;
        private static int[] answer;
        private static BinaryRegexp br;
    }

    public class When_Using_Regex_To_Find_Binary_Numbers_Divisible_By_Seven
    {
        Establish context = () =>
        {
            input = new string[]
            {
                "111",
                "10101",
                "1111",
                "10111100001",
                "0",
                "1101",
                ""
            };
            expect = new bool[]
            {
                true,
                true,
                false,
                true,
                true,
                false,
                false
            };
            answer = new bool[expect.Length];
            br = new BinaryRegexp();
        };

        Because of = () =>
        {
            for (var i = 0; i < input.Length; i++)
            {
                answer[i] = br.IsDivisible(input[i]);
            }
        };

        It Should_Return_Correct_Boolean = () =>
        {
            for (var i = 0; i < answer.Length; i++)
            {
                answer[i].ShouldEqual(expect[i]);
            }
        };

        private static string[] input;
        private static bool[] expect;
        private static bool[] answer;
        private static BinaryRegexp br;
    }
}