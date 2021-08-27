using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VegaIDE_V2.Server.Data;
using VegaIDE_V2.Shared;

namespace VegaIDE_V2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EditorController : Controller
    {
        private readonly ApplicationDbContext context;
        string fileName = @"C:\Users\Ashton\OneDrive - Nebula\Desktop\test\sample.py";
        //string fileName = $"{Environment.CurrentDirectory}\\sample.py";
        public EditorController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Editor>> GetItems()
        {
            return await context.Editors.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<Editor> GetItem(int id)
        {
            return await context.Editors.FirstOrDefaultAsync(editor => editor.Id == id);
        }

        [HttpPost]
        public async Task CreateItem(Editor editor)
        {
            var submission = context.Submissions.FirstOrDefault(q => q.Id == 1);

            if (editor != null)
            {
                CreateFile(editor.Code);
                string result = ExecuteScript(fileName);

                submission.Output = result;
                var _r = UpdateSubmission(1, submission);

            }                       

            //await context.Editors.AddAsync(editor);
            //await context.SaveChangesAsync();

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSubmission(int id, Submission submission)
        {
            if (id != submission.Id)
            {
                return BadRequest();
            }

            context.Entry(submission).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return NoContent();
        }

        [HttpGet]
        [Route("code")]
        public async Task<Submission> GetSubmission()
        {

            var submission = context.Submissions.FirstOrDefault(q => q.Id == 1);

            return submission;
            
        }

        public void CreateFile(string code)
        {

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(code);
            }

        }

        string ExecuteScript(string fileName)
        {
            //1. create process info
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Python39\python.exe";

            //var a = "cat";

            //2. provide script and arguments
            var script = fileName;
            psi.Arguments = $"\"{script}\"";


            //3. process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            //4. Execute process and get output
            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                results = process.StandardOutput.ReadToEnd();
                errors = process.StandardError.ReadToEnd();
            }

            return results;

        }

    }
}
