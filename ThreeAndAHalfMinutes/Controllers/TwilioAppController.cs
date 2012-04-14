using System.Web.Mvc;
using Twilio.TwiML.Mvc;

namespace ThreeAndAHalfMinutes.Controllers
{
    public class TwilioAppController : Controller
    {
        //
        // GET: /TwilioApp/

        public ActionResult Receive()
        {
            var twiml = new Twilio.TwiML.TwilioResponse();
            twiml.Say("Hello Monkey!");

            return new TwiMLResult(twiml);
        }

    }
}
