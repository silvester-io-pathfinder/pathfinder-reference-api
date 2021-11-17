using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class Elysium : Template
    {
        public static readonly Guid ID = Guid.Parse("cc26757e-a07a-4213-84a3-36b300a2306a");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.OuterSpherePlane.ID, 
                AlignmentId = Alignments.Instances.ChaoticGood.ID, 
                Name = "Elysium", 
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("674e9f09-ebe4-4824-ad63-5abe4787e2d7"), Type = TextBlockType.Text, Text = "Verdant, wild, and unrestrained by law, where passion and creation are fostered and rewarded, the plane of Elysium is a place of wild, idealized natural beauty. The so-called Promised Land and its inhabitants represent a wide variety of freely given benevolence, often willing to directly aid visitors but more often serving as inspirations and muses to foster positive change and self-realized success. Elysium’s petitioners, known as the chosen, appear as idealized versions of their mortal selves, each pursuing their own self-determined actions and finding their own unique paths to join the ranks of the plane’s celestials." };
            yield return new TextBlock { Id = Guid.Parse("91d3c06c-40da-44d9-9d09-de5221fd0bd9"), Type = TextBlockType.Text, Text = "Azatas—the plane’s primary denizens—organize into fleeting, competitive courts, each rewarding heroism and creativity above all else. Elysium hosts a number of resident deities, including Calistria and the elven pantheon, Cayden Cailean, Desna, Gorum, and various empyreal lords. Visitors from across the planes are drawn to Elysium’s Wandering City of Emerald Song, a mobile, impermanent, and ever-changing city of lillend azatas organized by their princess, Anduarine the Muse, filled with art, craft, revelry, song, and trade." };
        }
    }
}
