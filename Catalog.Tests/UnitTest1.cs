using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Database;
using Catalog.Models.Questionnaires;
using Catalog.Models.Requests;
using Catalog.Models.Requirements;
using Catalog.Repositories.Requirements;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Catalog.Tests
{
    public class UnitTest1
    {
        private IRequirementsRepository _requirementsRepository;

        public UnitTest1(IRequirementsRepository requirementsRepository)
        {
            _requirementsRepository = requirementsRepository;
        }

        [Fact]
        public async void RequirementsLoading()
        {
            var request = new Request();
            request.RequirementOffer = await GenerateOffer(request.Questionnaire);
            request.BusinessClientResponse = GenerateBusinessClientResponse(request.RequirementOffer.Requirements);
            
        }

        private BusinessClientResponse GenerateBusinessClientResponse(List<Requirement> requirements)
        {
            var conclusions = requirements.Select(item => new RequirementConclusion(item)).ToList();
            return new BusinessClientResponse(conclusions);
        }

        private async Task<RequirementOffer> GenerateOffer(Questionnaire requestQuestionnaire)
        {
            var offer = await _requirementsRepository.GenerateRequirementsOffer(requestQuestionnaire);
            var requirementOffer = new RequirementOffer(offer);
            return requirementOffer;
        }
    }
}