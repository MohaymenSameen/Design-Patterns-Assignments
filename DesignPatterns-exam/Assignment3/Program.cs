using System;
using System.Threading;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            VotingSystem votingSystem1 = VotingSystem.GetUniqueInstance();
            VotingSystem votingSystem2 = VotingSystem.GetUniqueInstance();

            //voting code is 1 in system 1
            votingSystem1.Vote("1",true);
            votingSystem1.VotingCodeUsed("2");

            Console.WriteLine();
            //checking for vote code 1 in system 2 if it exists
            votingSystem2.Vote("3", false);
            votingSystem2.VotingCodeUsed("1");
            Console.ReadKey();
        }
    }
}
