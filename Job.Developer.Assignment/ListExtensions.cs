namespace Job.Developer.Assignment
{
    /// <summary>
    /// List Extensions.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Returns all combinations of <paramref name="matches"/> in <paramref name="sequence"/>.
        /// Example:
        /// - sequence: { 0, 1, 1 }
        /// - matches: { 0, 1 }
        /// - combinations: { 0, 1 }, { 0, 2 }
        /// </summary>
        /// <param name="sequence">The sequence to find matches.</param>
        /// <param name="matches">The matches to find.</param>
        /// <returns>The collection of match results, that contains the positions of a match.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<IEnumerable<int>> FindCombinations<T>(this IList<T> sequence, IList<T> matches)
        {
            if (sequence is null || matches is null)
                throw new ArgumentNullException();

            return GenerateCombinations(sequence, matches, 0, new List<int>());
        }

        private static IEnumerable<IEnumerable<int>> GenerateCombinations<T>(IList<T> sequence, IList<T> matches, int matchIndex, List<int> currentCombination)
        {
            if (matchIndex == matches.Count)
            {
                yield return currentCombination;
                yield break;
            }

            var currentMatch = matches[matchIndex];
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i].Equals(currentMatch) &&
                    (!currentCombination.Any() || i > currentCombination.Last()))
                {
                    var updatedCombination = new List<int>(currentCombination) { i };
                    foreach (var combination in GenerateCombinations(sequence, matches, matchIndex + 1, updatedCombination))
                    {
                        yield return combination;
                    }
                }
            }
        }
    }
}

