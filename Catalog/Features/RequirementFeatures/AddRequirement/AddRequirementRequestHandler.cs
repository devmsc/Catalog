using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Catalog.Models.Questions;
using Catalog.Models.Requirements;
using Catalog.Repositories.ComplianceProcesses;
using Catalog.Repositories.ComplianceRisks;
using Catalog.Repositories.RelationStages;
using Catalog.Repositories.Requirements;
using Catalog.Repositories.Triggers;
using MediatR;

namespace Catalog.Features.RequirementFeatures.AddRequirement
{
    public class AddRequirementRequestHandler : IRequestHandler<AddRequirementRequest, AddRequirementResponse>
    {
        private IRequirementsRepository _requirementsRepository;
        private IComplianceRisksRepository _complianceRisksRepository;
        private IComplianceProcessesRepository _complianceProcessesRepository;
        private IRelationStagesRepository _relationStagesRepository;
        private ITriggersRepository _triggersRepository;
        
        public async Task<AddRequirementResponse> Handle(AddRequirementRequest request, CancellationToken cancellationToken)
        {
            var relationStage = await _relationStagesRepository.GetById(request.RelationStage);
            var complianceRisk = await _complianceRisksRepository.GetById(request.ComplianceRisk);
            var complianceProcess = await _complianceProcessesRepository.GetById(request.ComplianceProcess);
            var conclusion = request.Conclusion;
            //any
            var anyTriggers = new List<Trigger>();
            foreach (var id in request.AnyTriggerSet)
            {
                var trigger = await _triggersRepository.GetById(id);
                anyTriggers.Add(trigger);
            } 
            //required
            var requiredTriggers = new List<Trigger>();
            foreach (var id in request.RequiredTriggerSet)
            {
                var trigger = await _triggersRepository.GetById(id);
                requiredTriggers.Add(trigger);
            }
            //triggerSets
            var anyTriggerSet = new AnyTriggerSet(anyTriggers);
            var requiredTriggerSet = new RequiredTriggerSet(requiredTriggers);
            
            //new requirement
            var requirement = new Requirement(relationStage, complianceRisk, complianceProcess,
                conclusion, anyTriggerSet, requiredTriggerSet);
            var requirementId = await _requirementsRepository.Insert(requirement, cancellationToken);
            
            //response
            return await Task.FromResult(AddRequirementResponse.GetSuccess(requirementId));
        }
    }
}