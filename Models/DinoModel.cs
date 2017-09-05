using System;
using System.Collections.Generic;

namespace DinoAPI.Models
{
    public class DinoModel
    {
        public DinoModel()
        {

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Length { get; set; }
        public string Weight { get; set; }
        public string Habitat { get; set; }

        public List<DinoModel> GetDinosaurs()
        {
            var DinosaurList = new List<DinoModel>();
            var TyrannosaurusRex = new DinoModel{
                ID = 1,
                Name = "Tyrannosaurus Rex",
                ImageURL = "http://www.sciencekids.co.nz/images/pictures/dinosaurs/tyrannosaurusrex/trexroar.jpg",
                Length = "42 feet",
                Weight = "7 tons",
                Habitat = "Temperate Coniferous Forest"
            };
            var Velociraptor = new DinoModel{
                ID = 2,
                Name = "Velociraptor",
                ImageURL = "http://www.sciencekids.co.nz/images/pictures/dinosaurs/velociraptor.jpg",
                Length = "6 feet",
                Weight = "33 lbs",
                Habitat = "Desert"
            };
            var Triceratops = new DinoModel{
                ID = 3,
                Name = "Triceratops",
                ImageURL = "http://www.sciencekids.co.nz/images/pictures/dinosaurs/triceratops/triceratopsfacesketch.JPG",
                Length = "26 feet",
                Weight = "12 tons",
                Habitat = "Temperate Coniferous Forest"
            };
            var Brachiosaurus = new DinoModel{
                ID = 4,
                Name = "Brachiosaurus",
                ImageURL = "http://www.sciencekids.co.nz/images/pictures/dinosaurs/brachiosaurusdrawing.jpg",
                Length = "85 feet",
                Weight = "50 tons",
                Habitat = "Temperate Deciduous Forest"
            };
            var Stegosaurus = new DinoModel{
                ID = 5,
                Name = "Stegosaurus",
                ImageURL = "http://www.sciencekids.co.nz/images/pictures/dinosaurs/stegosaurus/stegosaurusillustration.jpg",
                Length = "30 feet",
                Weight = "5 tons",
                Habitat = "Grassland"
            };
            var Iguanodon = new DinoModel{
                ID = 6,
                Name = "Iguanodon",
                ImageURL = "http://www.sciencekids.co.nz/images/experiments/iguanodon170.jpg",
                Length = "33 feet",
                Weight = "3.5 tons",
                Habitat = "Temperate Deciduous Forest"
            };
            DinosaurList.Add(TyrannosaurusRex);
            DinosaurList.Add(Velociraptor);
            DinosaurList.Add(Triceratops);
            DinosaurList.Add(Brachiosaurus);
            DinosaurList.Add(Stegosaurus);
            DinosaurList.Add(Iguanodon);
            return DinosaurList;
        }

    }
}