using System;
using System.Collections;

namespace Diamond {
    public class Diamond {
        protected internal static ArrayList Returns;

        public static string Process(char input) {
            ValidateInput(input);
            
            Returns = new ArrayList();

            if (input == 'A') {
                return "A";
            }

            var currentLetterAsciiCode = (int)input;
            var totalDistance = input - 'A';

            AddCenterLine(currentLetterAsciiCode, totalDistance);
            currentLetterAsciiCode--;

            for (; currentLetterAsciiCode > 'A'; currentLetterAsciiCode--) {
                AddSimetricLines(LineBuilder.BuildIntermediaryLine(totalDistance, currentLetterAsciiCode));
            }

            AddSimetricLines(LineBuilder.BuildLetterALine(totalDistance));

            return string.Join("\n", Returns.ToArray());
        }

        private static void ValidateInput(char input) {
            if (input < 'A' || input > 'Z') { 
                throw new ArgumentOutOfRangeException(nameof(input));
            }
        }

        private static void AddSimetricLines(string currentString) {
            Returns.Insert(0, currentString);
            Returns.Add(currentString);
        }

        private static void AddCenterLine(int current, int distance) {
            Returns.Add(LineBuilder.BuildCenterLine(current, distance));
        }
    }
}
