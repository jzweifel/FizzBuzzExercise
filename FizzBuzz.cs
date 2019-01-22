using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz {
    public static class FizzBuzz {
        /*
            - Takes an array of ints and returns an array of strings
                [1] => ["1"], 
                [1,2,3,4,5] => ["1","2","3","4","5"],
                [1..10] => ["1","2","3","4","5","6","7","8","9","10"]
            - for multiples of three, print "Fizz” instead of the number
                [1,2,3] => ["1","2","Fizz"]
            - for multiples of five, print "Buzz"
                [1,2,3,4,5] => ["1","2","Fizz","4","Buzz"]
            - For numbers which are multiples of both three and five,
                print "FizzBuzz".


                --------
                7 => "Bang!"
                3, 7 => "FizzBang!"
                5, 7 => "BuzzBang!"
                3,5,7 => "FizzBuzzBang!"
         */

        private static Dictionary<int, string> translations = new Dictionary<int, string> () { 
            { 3, "Fizz" }, { 5, "Buzz" }, {7, "Bang!"}
        };
        public static List<string> GetFizzBuzz (List<int> ints) {
            if (ints == null) return null;
            return ints.Select (i => FizzBuzzTranslation (translations, i)).ToList ();
        }

        private static string FizzBuzzTranslation (Dictionary<int, string> translations, int input) {
            var result = String.Empty;
            foreach (var translation in translations) {
                if (IsMultipleOf (input, translation.Key)) result += translation.Value;
            }
            return result != String.Empty ? result : input.ToString();
        }

        private static bool IsMultipleOf (int input, int multiple) {
            return input % multiple == 0;
        }
    }
}
