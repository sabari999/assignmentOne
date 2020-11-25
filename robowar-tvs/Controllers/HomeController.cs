using DataAccess;
using DataProvider;
using robowar_tvs.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace robowar_tvs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RoboWar()
        {
            return View();
        }

        public JsonResult ProcessInstructions(InstructionParams obj)
        {
            var processLocation = new ProcessLocation();

            var robot = processLocation.Parse(obj.InitialPositionX, obj.InitialPositionY, obj.InitialDirection);

            IEnumerable<IMove> robotMoves = ProcessMoves.Parse(obj.MovingInstructions);
            //robotMoves.ForEach(item => item.ExecuteOn(robot, out int penalty));

            //var prevX = 0;
            //var prevY = 0;
            //var totalPenalty = 0;
            //bool keepPreviousPosition = false;
            //foreach (var item in robotMoves)
            //{

            //    if (keepPreviousPosition)
            //    {
            //        robot.Coordinate.X = prevX;
            //        robot.Coordinate.Y = prevY;
            //    }
            //    else
            //    {
            //        prevX = robot.Coordinate.X;
            //        prevY = robot.Coordinate.Y;
            //    }
            //    item.ExecuteOn(robot, out int penalty);
            //    keepPreviousPosition = penalty > 0;
            //    if (penalty > 0) { totalPenalty++; }
            //}



            //int[] penalties = { };
            var penalties = new List<int>();
            int totalPenalty = 0;
            int iteration = 0;
            Position previousPostion;
            var prevX = 0;
            var prevY = 0;
            bool keepPreviousPosition = false;
            foreach (var item in robotMoves)
            {
                iteration++;

                prevX = robot.Coordinate.X;
                prevY = robot.Coordinate.Y;

                if (keepPreviousPosition)
                {
                    robot.Coordinate.X = prevX;
                    robot.Coordinate.Y = prevY;
                }
                item.ExecuteOn(robot, out int penalty);

                keepPreviousPosition = penalty > 0;

                penalties.Add(penalty);


                //if (iteration == 1)
                //{
                //    penalties.Add(penalty);
                //}
                //else
                //{
                //    penalties[penalties.Count] = penalty;
                //}

                if (penalty > 0 && penalties[penalties.Count - 1] == 0)
                {
                    totalPenalty++;
                }


            }



            var result = new ProcessOutput
            {
                EndPositionX = robot.Coordinate.X.ToString(),
                EndPositionY = robot.Coordinate.Y.ToString(),
                EndDirection = robot.Direction.ToString()
            };

            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}