namespace Tier3.Models
{
    public class ClientBurial
    {
        public int ClientId { get; set; }
        public Client.Client Client { get; set; }
        public int BurialId { get; set; }
        public Burial.Burial BurialClient { get; set; }
    }
}