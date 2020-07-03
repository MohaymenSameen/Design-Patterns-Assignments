using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class VotingSystem
    {
        private List<string> votesAgainst;
        private List<string> votesInFavour;
        private static VotingSystem uniqueInstance;
        public VotingSystem()
        {
            votesAgainst = new List<string>();
            votesInFavour = new List<string>();
        }
        public static VotingSystem GetUniqueInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new VotingSystem();
            }
            return uniqueInstance;
        }
        public void Vote(string votingCode, bool voteInFavour)
        {
            if(voteInFavour == true)
            {
                votesInFavour.Add(votingCode);
                Console.WriteLine("Thank you for adding your vote '{0}' for votes in favour",votingCode);
            }
            else
            {
                votesAgainst.Add(votingCode);
                Console.WriteLine("Thank you for adding your vote '{0}' for votes against",votingCode);
            }
        }
        public bool VotingCodeUsed(string votingCode)
        {            
            if (votesInFavour.Contains(votingCode) || votesAgainst.Contains(votingCode))
            {
                Console.WriteLine("voting code has already been added and is duplicated");               
                return true;
            }
            return false; 
        }
    }
}
