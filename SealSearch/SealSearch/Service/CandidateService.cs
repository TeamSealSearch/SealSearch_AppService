using SealSearch.Context;
using SealSearch.IService;
using SealSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealSearch.Service
{
    public class CandidateService : ICandidateService
    {
        private readonly DatabaseContext _context;
        public CandidateService(DatabaseContext context)
        {
            _context = context;
        }
        public Candidate GetSavedCandidate()
        {
            return _context.CandidateList.SingleOrDefault();
        }

        public Candidate Save(Candidate oCandidate)
        {
            _context.CandidateList.Add(oCandidate);
            _context.SaveChanges();
            return oCandidate;
        }
    }
}
