using Project.BLL.DesignPatterns.genericRepository.ConcRep;
using Project.COMMON.Tools;
using Project.ENTITIES.Models;
using Project.MVCUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Areas
{
    public class TeamController : Controller
    {
        TeamRepository _tRep;
        public TeamController()
        {
            _tRep = new TeamRepository();
        }
        // GET: Team
        public ActionResult ListTeam()
        {
            TeamVM tvm = new TeamVM();
            tvm.Teams = _tRep.GetAll();
            return View(tvm);
        }

        public ActionResult AddTeam()
        {
            TeamVM tvm = new TeamVM();
            tvm.Team = new Team();
            return View(tvm);
        }
        [HttpPost]
        public ActionResult AddTeam(Team team, HttpPostedFileBase resim)
        {
            team.ProfileImage = ImageUploader.UploadImage("/Pictures", resim);
            _tRep.Add(team);
            return RedirectToAction("ListTeam");
        }
        public ActionResult UpdateTeam(int id)
        {
            TeamVM tvm = new TeamVM();
            tvm.Team = _tRep.Find(id);
            return View(tvm);
        }
        [HttpPost]
        public ActionResult UpdateTeam(Team team, HttpPostedFileBase resim)
        {
            
            if (resim==null)
            {
                team.ProfileImage = _tRep.Find(team.ID).ProfileImage;
            }
            else
            {
                team.ProfileImage = ImageUploader.UploadImage("/Pictures", resim);
            }
            



            _tRep.Update(team);
            return RedirectToAction("ListTeam");

        }

        public ActionResult DeleteTeam(int id)
        {
            _tRep.Delete(_tRep.Find(id));
            return RedirectToAction("ListTeam");
        }
    }
}