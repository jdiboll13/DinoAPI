using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DinoAPI.Models;

namespace DinoAPI.Controllers
{
    [Route("api/[controller]")]
    public class DinoController : Controller
    {
        // GET api/dino
        [HttpGet]
        public List<DinoModel> Get()
        {
            var dino = new DinoModel();
            List<DinoModel> dinosaurs = dino.GetDinosaurs();
            return dinosaurs;
        }

        // GET api/dino/5
        [HttpGet("{id}")]
        public DinoModel Get(int id)
        {
            var dino = new DinoModel();
            List<DinoModel> dinosaurs = dino.GetDinosaurs();
            return dinosaurs[id - 1];
        }

        // POST api/dino
        [HttpPost]
        public List<DinoModel> Post([FromBody]int id, string name, string imageurl, string length, string weight, string habitat)
        {
            var dino = new DinoModel();
            List<DinoModel> dinosaurs = dino.GetDinosaurs();
            var newDino = new DinoModel
            {
                ID = id,
                Name = name,
                ImageURL = imageurl,
                Length = length,
                Weight = weight,
                Habitat = habitat
            };
            dinosaurs.Add(newDino);
            return dinosaurs;
        }

        // PUT api/dino/5
        [HttpPut("{id}")]
        public List<DinoModel> Put(int id, [FromBody]string name, string imageurl, string length, string weight, string habitat)
        {
            var dino = new DinoModel();
            List<DinoModel> dinosaurs = dino.GetDinosaurs();
            if (dinosaurs.Any(i => i.ID == id))
            {
                dino = dinosaurs.SingleOrDefault(w => w.ID == id);
                dino.Name = name;
                dino.ImageURL = imageurl;
                dino.Length = length;
                dino.Weight = weight;
                dino.Habitat = habitat;
            } else {
                var newDino = new DinoModel
                {
                    ID = id,
                    Name = name,
                    ImageURL = imageurl,
                    Length = length,
                    Weight = weight,
                    Habitat = habitat
                };
                dinosaurs.Add(newDino);
            }
            return dinosaurs;
        }

        // DELETE api/dino/5
        [HttpDelete("{id}")]
        public List<DinoModel> Delete(int id)
        {
            var dino = new DinoModel();
            List<DinoModel> dinosaurs = dino.GetDinosaurs();
            dino = dinosaurs.SingleOrDefault(i => i.ID == id);
            dinosaurs.Remove(dino);
            return dinosaurs;
        }
    }
}
