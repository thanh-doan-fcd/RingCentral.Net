using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AuthzProfile.Check
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.AuthzProfile.Index parent;

        public Index(Restapi.Account.Extension.AuthzProfile.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/check";
        }

        /// <summary>
        /// Operation: Check User Permission
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile/check
        /// </summary>
        public async Task<RingCentral.AuthProfileCheckResource> Get(CheckUserPermissionParameters queryParams = null)
        {
            return await rc.Get<RingCentral.AuthProfileCheckResource>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.AuthzProfile
{
    public partial class Index
    {
        public Restapi.Account.Extension.AuthzProfile.Check.Index Check()
        {
            return new Restapi.Account.Extension.AuthzProfile.Check.Index(this);
        }
    }
}