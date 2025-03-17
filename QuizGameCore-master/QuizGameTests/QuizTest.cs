// using QuizGameCore;
// using QuizGameCore.Utils;
// using System.Linq;
// using Xunit;
//
//
// namespace QuizGameTests;
//
// public class QuizTest
// {
//     // [Fact]
//     // public void Question()
//     // {
//     //     Assert.Equal(
//     //         "Unity is ...".Cache(out var question),
//     //         new Quiz(question, "game engine", new[] {"game", "a thing", "motorcycle"}).Question
//     //     );
//     // }
//     //
//     //
//     // [Fact]
//     // public void CorrectAnswer()
//     // {
//     //     Assert.True(
//     //         new Quiz(
//     //             "Unity is ...",
//     //             "game engine".Cache(out var answer),
//     //             new[] {"game", "a thing", "motorcycle"}
//     //         ).Answer(answer)
//     //     );
//     // }
//     //
//     //
//     // [Fact]
//     // public void WrongAnswer()
//     // {
//     //     Assert.False(
//     //         new Quiz(
//     //             "Unity is ...",
//     //             "game engine",
//     //             new[] {"game", "a thing", "motorcycle"}
//     //         ).Answer("random thing")
//     //     );
//     // }
//     //
//     //
//     // [Fact]
//     // public void Variants()
//     // {
//     //     var supposedResult = new[]
//     //     {
//     //         "game engine", "game", "a thing", "motorcycle"
//     //     };
//     //     var realVariants = new Quiz(
//     //         "Unity is ...",
//     //         supposedResult.Last(),
//     //         supposedResult.Take(supposedResult.Length - 1).ToList()
//     //     ).Variants;
//     //
//     //     Assert.True(supposedResult.SequenceEqual(realVariants));
//     // }
// }