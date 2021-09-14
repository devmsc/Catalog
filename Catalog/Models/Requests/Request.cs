using System;
using System.Collections.Generic;
using Catalog.Models.Base;
using Catalog.Models.Comments;
using Catalog.Models.Questionnaires;
using Catalog.Models.Requirements;
using Catalog.Models.Users;

namespace Catalog.Models.Requests
{
    public class Request : ModelBase
    {
        public Request()
        {
            
        }

        public Request(Questionnaire questionnaire, BusinessClient businessClient, RequirementOffer requirementOffer)
        {
            Questionnaire = questionnaire;
            BusinessClient = businessClient;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
            RequestStatus = RequestStatus.New;
            Comments = new List<Comment>();
            RequirementOffer = requirementOffer;
        }

        public DateTime UpdatedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public Questionnaire Questionnaire { get; set; }
        public BusinessClient BusinessClient { get; set; }
        public Guid BusinessClientId { get; set; }
        public RequestStatus RequestStatus { get; set; }
        public RequirementOffer RequirementOffer { get; set; }
        public BusinessClientResponse BusinessClientResponse { get; set; }
        public List<Comment> Comments { get; set; }
    }

    public class BusinessClientResponse : ModelBase
    {
        public BusinessClientResponse(List<RequirementConclusion> requirementConclusions)
        {
            RequirementConclusions = requirementConclusions;
        }

        private List<RequirementConclusion> RequirementConclusions { get; set; }
        public BusinessClientResponseStatus BusinessClientResponseStatus { get; set; }

        public void UpdateConclusions(List<RequirementConclusion> conclusions)
        {
            RequirementConclusions = conclusions;
        }
    }

    public enum BusinessClientResponseStatus
    {
        Pending,
        Approved
    }
}