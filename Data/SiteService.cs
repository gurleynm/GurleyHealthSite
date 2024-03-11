namespace GurleyHealthSite.Data
{
    public class SiteService
    {        
        private static string[] ENV => File.ReadAllLines(".env");
        Site[] AllSites = new Site[ENV.Length];

        public Site[] GetSites()
        {
            for(int index = 0; index < ENV.Length; index++)
            {
                AllSites[index] = new Site
                {
                    URL = ENV[index],
                    Status = "InProgress"
                };
            }

            return AllSites;
        }
    }
}
