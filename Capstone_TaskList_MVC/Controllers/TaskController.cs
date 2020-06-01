using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using Capstone_TaskList_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Capstone_TaskList_MVC.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        public TaskDbContext _context { get; set; }
        public TaskController(TaskDbContext context)
        {
            this._context = context;
        }
        protected string GetLogonUser()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public List<Models.Task> GetAllUserTasks()
        {
            string logonUserId = GetLogonUser();
            List<Models.Task> tasks = _context.Task.Where(x => x.Userid == logonUserId).ToList();
            return tasks;
        }
        public IActionResult TaskList()
        {
            return View(GetAllUserTasks());
        }
        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
       }
        [HttpPost]
        public IActionResult AddTask(Models.Task newTask)
        {
            if (ModelState.IsValid)
            {
                newTask.Userid = GetLogonUser();
                _context.Task.Add(newTask);
                _context.SaveChanges();
                TempData["Result"] = $"Added task, {newTask.TaskDescription}";
            }
            return RedirectToAction("TaskList");
       }
        [HttpGet]
        public IActionResult DeleteTask(int Id)
        {
            var foundTask = _context.Task.Where(x => x.Id == Id).ToList();
            if (foundTask.Count > 0)
            {
                TempData["Result"] = $"Deleted task, {foundTask[0].TaskDescription}";
                _context.Remove(foundTask[0]);
                _context.SaveChanges();
                return RedirectToAction("TaskList");
            }
            else
            {
                TempData["Result"] = "Task not found.";
                return View();
            }
       }
        [HttpGet]
        public IActionResult UpdateTask(int Id)
        {
            var foundTask = _context.Task.Where(x => x.Id == Id).ToList();
            if (foundTask.Count > 0)
            {
                return View(foundTask[0]);
            }
            else
            {
                TempData["Result"] = "Task not found.";
                return RedirectToAction("TaskList");
            }
        }
        [HttpPost]
        public IActionResult UpdateTask(Models.Task updateTask)
        {
            var foundTasks = _context.Task.Where(x => x.Id == updateTask.Id).ToList();
            if (foundTasks.Count > 0)
            {
                Models.Task dbTask = foundTasks[0];
                dbTask.TaskDescription = updateTask.TaskDescription;
                dbTask.DueDate = updateTask.DueDate;
                dbTask.CompletedStatus = updateTask.CompletedStatus;
                _context.Update(dbTask);
                _context.SaveChanges();
                TempData["Result"] = $"Task updated, {dbTask.TaskDescription}";
            }
            else
            {
                TempData["Result"] = "Task not found.";
            }
            return RedirectToAction("TaskList");
        }
        [HttpGet]
        public IActionResult MarkComplete(int Id)
        {
            var foundTasks = _context.Task.Where(x => x.Id == Id).ToList();
            if (foundTasks.Count > 0)
            {
                Models.Task dbTask = foundTasks[0];
                dbTask.CompletedStatus = true;
                _context.Update(dbTask);
                _context.SaveChanges();
                TempData["Result"] = $"Task marked as Completed, {dbTask.TaskDescription}";
            }
            else
            {
                TempData["Result"] = "Task not found.";
            }
            return RedirectToAction("TaskList");
        }
        public List<Models.Task> GetUserTasksBySearch(
            string? SearchDescription,
            DateTime? SearchDate,
            string? SearchCompleted
            )
        {
            string userId = GetLogonUser();
            List<Models.Task> foundTasks;
            if (SearchDescription != null && SearchDescription != "")
            {
                if (SearchDate == null)
                {
                    if (SearchCompleted == "ignore")
                    {
                        // return all this user's task by partial Description
                        foundTasks = _context.Task.Where(x => x.Userid == userId
                            && x.TaskDescription.Contains(SearchDescription)
                            ).ToList();
                    }
                    else
                    {
                        // return all this user's task by partial Description and Completed Status
                        bool searchStatus = SearchCompleted == "true";
                        foundTasks = _context.Task.Where(x => x.Userid == userId
                            && x.TaskDescription.Contains(SearchDescription)
                            && x.CompletedStatus == searchStatus
                            ).ToList();
                    }
                }
                else
                {
                    if (SearchCompleted == "ignore")
                    {
                        // return all this user's task by partial Description and chosen Date
                        foundTasks = _context.Task.Where(x => x.Userid == userId
                            && x.TaskDescription.Contains(SearchDescription)
                            && x.DueDate >= SearchDate
                            ).ToList();
                    }
                    else
                    {
                        // return all this user's task by partial Description and chosen Date and Completed Status
                        bool searchStatus = SearchCompleted == "true";
                        foundTasks = _context.Task.Where(x => x.Userid == userId
                            && x.TaskDescription.Contains(SearchDescription)
                            && x.DueDate >= SearchDate
                            && x.CompletedStatus == searchStatus
                            ).ToList();
                    }
                }
            }
            else if (SearchDate != null)
            {
                if (SearchCompleted == "ignore")
                {
                    // return all this user's task by chosen Date
                    foundTasks = _context.Task.Where(x => x.Userid == userId
                        && x.DueDate >= SearchDate
                        ).ToList();
                }
                else
                {
                    // return all this user's task by chosen Date and Completed Status
                    bool searchStatus = SearchCompleted == "true";
                    foundTasks = _context.Task.Where(x => x.Userid == userId
                        && x.DueDate >= SearchDate
                        && x.CompletedStatus == searchStatus
                        ).ToList();
                }
            }
            else if (SearchCompleted != "ignore")
            {
                // return all this user's task by chosen Completed Status
                bool searchStatus = SearchCompleted == "true";
                foundTasks = _context.Task.Where(x => x.Userid == userId
                    && x.CompletedStatus == searchStatus
                    ).ToList();
            }
            else
            {
                // return all this user's task
                foundTasks = GetAllUserTasks();
            }
            return foundTasks;
        }
        [HttpPost]
        public IActionResult FilterTaskList(
            string? SearchDescription,
            DateTime? SearchDate,
            string? SearchCompleted,
            bool? SortByDate,
            bool? SortByCompleted
        )
        {
            List<Models.Task> foundTasks = GetUserTasksBySearch(
                SearchDescription, SearchDate, SearchCompleted);

            if (SortByDate != null && SortByDate == true)
            {
                if (SortByCompleted == null || SortByCompleted == false)
                {
                    foundTasks = foundTasks.OrderBy(x => x.DueDate).ThenBy(x => x.CompletedStatus).ToList();
                }
                else
                {
                    foundTasks = foundTasks.OrderBy(x => x.DueDate).ToList();
                }
            }
            else if (SortByCompleted != null || SortByCompleted == true)
            {
                foundTasks = foundTasks.OrderBy(x => x.CompletedStatus).ToList();
            }
            else
            {
                // no ordering requested
            }
 
            TempData["SearchDescription"] = SearchDescription;
            TempData["SearchDate"] = SearchDate;
            TempData["SearchCompleted"] = SearchCompleted;
            TempData["SortByDate"] = SortByDate;
            TempData["SortByCompleted"] = SortByCompleted;

            TempData["Results"] = $"{foundTasks.Count} found for {SearchDescription}";
            ViewData["Results"] = $"{foundTasks.Count} found for {SearchDescription}";

            return View("TaskList", foundTasks);
        }
        [HttpPost]
        public IActionResult SortTaskList(
            string? SearchDescription,
            DateTime? SearchDate,
            string? SearchCompleted,
            bool? SortDate,
            bool? SortCompleted
        )
        {
            List<Models.Task> foundTasks = GetUserTasksBySearch(SearchDescription, SearchDate, SearchCompleted);

            if (SortDate != null)
            {
                if (SortCompleted == null)
                {
                    foundTasks = foundTasks.OrderBy(x => x.DueDate).ThenBy(x => x.CompletedStatus).ToList();
                }
                else
                {
                    foundTasks = foundTasks.OrderBy(x => x.DueDate).ToList();
                }
            }
            else if (SortCompleted == null)
            {
                bool searchStatus = SearchCompleted == "true";
                foundTasks = foundTasks.OrderBy(x => x.CompletedStatus).ToList();
            }
            else
            {
                // no ordering requested
            }
            TempData["SearchDescription"] = SearchDescription;
            TempData["SearchDate"] = SearchDate;
            TempData["SearchCompleted"] = SearchCompleted;
            TempData["SortDate"] = SortDate;
            TempData["SortCompleted"] = SortCompleted;

            return View("TaskList", foundTasks);
        }
  }
}