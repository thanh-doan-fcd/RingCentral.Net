using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams.Unarchive
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Teams.Index parent;

        public Index(Restapi.Glip.Teams.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/unarchive";
        }

        /// <summary>
        /// Operation: Unarchive Team
        /// Http Post /restapi/v1.0/glip/teams/{chatId}/unarchive
        /// </summary>
        public async Task<string> Post()
        {
            return await rc.Post<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Unarchive.Index Unarchive()
        {
            return new Restapi.Glip.Teams.Unarchive.Index(this);
        }
    }
}