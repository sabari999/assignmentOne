using DataAccess;
using DataProvider;
using robowar_tvs.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace robowar_tvs.Controllers
{
    public class HomeController : Controller
    {
                
        public ActionResult RoboWar()
        {
            return View();
        }

        public JsonResult ProcessInstructions(InstructionParams obj)
        {
            try
            {
                var processLocation = new ProcessLocation();

                var robot = processLocation.Parse(obj.InitialPositionX, obj.InitialPositionY, obj.InitialDirection);

                IEnumerable<IMove> robotMoves = ProcessMoves.Parse(obj.MovingInstructions);

                int totalPenalty = 0;

                foreach (var item in robotMoves)
                {

                    item.ExecuteOn(robot, out int penalty);

                    if (penalty > 0)
                    {
                        totalPenalty++;
                    }

                }

                var result = new ProcessOutput
                {
                    EndPositionX = robot.Coordinate.X.ToString(),
                    EndPositionY = robot.Coordinate.Y.ToString(),
                    EndDirection = robot.Direction.ToString(),
                    Penalties = totalPenalty.ToString()
                };

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);

            }

        }

    }
}