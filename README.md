# Job.Deveveloper.Assignment
Candidate assignment for ParsePort developer job interviews.  

The solution contains the following extension method, that must be implemented, in order to satisfy the tests in the solutuon. There are several possible solutions, but of course the fastest and most optimal implementation is prefered. Also Use your best code quality.  

```csharp
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
    throw new NotImplementedException();
}
```

***
