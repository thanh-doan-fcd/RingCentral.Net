using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.Health
{
    public partial class Index
    {
        public RestClient rc;
        public Scim.Index parent;

        public Index(Scim.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/health";
        }

        /// <summary>
        /// Operation: Check Health
        /// Http Get /scim/v2/health
        /// </summary>
        public async Task<string> Get()
        {
            return await rc.Get<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Scim.Health.Index Health()
        {
            return new Scim.Health.Index(this);
        }
    }
}