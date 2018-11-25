namespace Diamond {
    public class LineBuilder {
        public static string BuildCenterLine(int currentLetterAsciiCode, int totalDistance) {
            return $"{(char) currentLetterAsciiCode}{GetIntermediarySpacesForLine(totalDistance)}{(char) currentLetterAsciiCode}";
        }

        public static string BuildIntermediaryLine(int totalDistance, int currentLetterAsciiCode) {
            var currentDistance = currentLetterAsciiCode - 'A';
            return 
                $"{GetStartingSpacesForLine(totalDistance, currentDistance)}" +
                $"{(char)currentLetterAsciiCode}" + 
                $"{GetIntermediarySpacesForLine(currentDistance)}" +
                $"{(char)currentLetterAsciiCode}";
        }

        public static string BuildLetterALine(int totalDistance) {
            return $"{new string(' ', totalDistance)}A";
        }

        private static string GetStartingSpacesForLine(int totalDistance, int currentDistance) {
            return new string(' ', totalDistance - currentDistance);
        }

        public static string GetIntermediarySpacesForLine(int distance) {
            return new string(' ', 2 * (distance-1) + 1);
        }

    }
}