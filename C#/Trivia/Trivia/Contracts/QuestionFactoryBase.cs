using System;
namespace Trivia.Contracts
{
    public abstract class QuestionFactoryBase
    {
        public abstract string CreateQuestion(string type, int index);
    }
}

