using Portfolio.WebAPI.Models;
using Portfolio.WebAPI.Repository;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Portfolio.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HomeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetPortfolioDetail(string username)
        {
            HomeRepository _homeRepository = new HomeRepository();
            var details= _homeRepository.GetPortfolioDetail(username);
            if(details == null)
            {
                return NotFound();
            }
            return Ok(details);
        }

        [HttpPost]
        public async Task<IHttpActionResult> SendMessage(sendMessageModel payload)
        {
            HomeRepository _homeRepository = new HomeRepository();
            var details = await _homeRepository.SendMessage(payload);
            if (details == null)
            {
                return NotFound();
            }
            return Ok(details);
        }

        
    }
}
