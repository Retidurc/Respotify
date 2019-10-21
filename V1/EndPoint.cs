using DalSoft.RestClient;

namespace Remotify.V1
{
    public abstract class EndPoint
    {
        protected abstract string Ressource { get; }
        protected EndPoint() : base()
        {
            this.RestClient = new RestClient(API.BaseAdress);
            //temporary bearer token
            var token = this.RestClient
                .Authorization(AuthenticationSchemes.Bearer, "BQCRwgu-Oh-7nKE0AqozSdtTOx0aURowPi1lqwPOhBDRQRTbMSahI__SYKgcgwrZ9rTSn7fDVrsRdcWYz6B1_WeJVlBylxRH81cMFFsAmJjE-owM2bdi5IeKlwVhJMT7mTDvScuhc_MTSJ59YADfoI4JTPIS8v3p75ruQbVxw_N03oHPnuGXD-1s4cpD1xtqQo8dnvHDw06i6Yr7InWaoBujVM-dVW0dmz3a_2Q8asJ-aT5K_jOqt_4hFzLLSfzcuqeASOzXHi0bo8KN50mEGn6ayVm21tdVY5Mk")
                .Get().Result;

        }

        protected RestClient RestClient { get; }
        protected  dynamic Endpoint => this.RestClient.Resource(this.Ressource);
    }
}
