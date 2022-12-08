using System;
using Trivia.Contracts;

namespace Trivia
{
    public class QuestionFactory : QuestionFactoryBase
    {
        public override string CreateQuestion(string type, int index)
        {
            switch (type)
            {
                case "Pop":
                    return "Pop Question " + index;

                case "Science":
                    return "Science Question " + index;

                case "Sports":
                    return "Sports Question " + index;

                case "Rock":
                    return "Rock Question " + index;

                default:
                    throw new NotImplementedException($"Unknown type: {type}");
            }
        }

    }
}

