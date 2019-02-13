using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups.Users
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.PagingOnlyGroups.Index parent;

        public Index(Restapi.Account.PagingOnlyGroups.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/users";
        }

        public class GetQueryParams
        {
            // Indicates the page number to retrieve. Only positive number values are accepted
            public string page;

            // Indicates the page size (number of items)
            public string perPage;
        }

        public async Task<RingCentral.PagingOnlyGroupUsers> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.PagingOnlyGroupUsers>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.PagingOnlyGroups
{
    public partial class Index
    {
        public Restapi.Account.PagingOnlyGroups.Users.Index Users()
        {
            return new Restapi.Account.PagingOnlyGroups.Users.Index(this);
        }
    }
}