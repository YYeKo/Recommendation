using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Web.Http;
using BL;
using System.Runtime.Remoting.Contexts;

namespace API.Controllers
{
    public class VoiceController : ApiController
    {
        [HttpGet]
        [Route("api/voice/phone")]
        public HttpResponseMessage getProfInformation(int letterForProf, int? profession = null, int? area = null, int? city = null)
        {
            if (city != null)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("read=t-" + VoiceService.selectedRecommended((int)letterForProf, (int)profession,(int)area,(int)city) + ".s-005=city,no,2,1,5,no,,,,,3",
                                               Encoding.UTF8, "text/plain")
                };
            }

            if (area != null)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("read=t-" + VoiceService.selectedCities((int)area) + ".s-004=city,no,1,1,5,no,,,,,3",
                                               Encoding.UTF8, "text/plain")
                };
            }
            if (profession != null)
            {
                return new HttpResponseMessage()
                {
                    Content = new StringContent("read=t-" + VoiceService.selectedAreas() + ".s-003=area,no,1,1,5,no,,,,,3",
                                Encoding.UTF8, "text/plain")
                };
            }
            return new HttpResponseMessage()
            {
                Content = new StringContent("read=t-" + VoiceService.SelectedProfByLetters(VoiceService.SelectedLetters(letterForProf)) + ".s-002=profession,no,2,1,5,no,,,,",
                 Encoding.UTF8, "text/plain")
            };
        }
    }
}