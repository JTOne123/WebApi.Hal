using HalWebApi.Tests.Representations;

namespace HalWebApi.Tests.Linkers
{
    public class OrganisationListLinker : IResourceLinker<ResourceList<OrganisationRepresentation>>
    {
        public void CreateLinks(ResourceList<OrganisationRepresentation> resource, IResourceLinker resourceLinker)
        {
            resource.Rel = "organisations";
            resource.Href = "/api/organisations";

            foreach (var organisationRepresentation in resource)
            {
                resourceLinker.CreateLinks(organisationRepresentation);
            }
        }
    }
}