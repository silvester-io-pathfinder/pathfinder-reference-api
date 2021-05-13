using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Planes.Instances
{
    public class Nirvana : Template
    {
        public static readonly Guid ID = Guid.Parse("b1ed0a25-c679-4365-a45e-4d7fc057c1d9");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.OuterSpherePlane.ID, 
                AlignmentId = Alignments.Instances.NeutralGood.ID, 
                Name = "Nirvana", 
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("922ba14e-112b-40e7-840d-12b8ea77f44e"), Type = TextBlockType.Text, Text = "The pastoral paradise of Nirvana is the realm of purest good, a plane that promises sanctuary to the weary and enlightenment and transcendence to those who seek it out. Filled with beautiful wilderness of all types in perfect harmony with its occupants, Nirvana’s wilds are home to angels and others. The plane’s petitioners, known as the cleansed, most often take the forms of glorified, sapient wild animals, though many eventually leave their carefree existence to aid others, ascending to assist the benevolent works of angels. Devoted to guiding and assisting mortals, angels are often charged with delivering important messages that reflect the will of benevolent deities." };
            yield return new TextBlock { Id = Guid.Parse("acea4eed-c3b1-414c-8747-ce22a78f64f6"), Type = TextBlockType.Text, Text = "Various divinities make their home amid Nirvana’s wilds, including a host of empyreal lords and, most prominently, Sarenrae and Shelyn. While the great cities of High Ninshabur and Llourith welcome visitors, most mortals visiting Nirvana witness the plane’s beauty and supernatural feeling of peace but rarely encounter many of its residents, as the plane itself protectively hides much of its contents from any but the most selfless and pure of heart. The plane’s hinterlands hint at hidden mysteries, including legends that the plane shelters the vanished heroes of innumerable mortal worlds, peacefully sleeping until their peoples’ times of greatest need." };
        }
    }
}
