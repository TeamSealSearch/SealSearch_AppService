using SealSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealSearch.IService
{
    public interface ICandidateService
    {
        Candidate Save(Candidate oCandidate);
        Candidate GetSavedCandidate();

    }
}
