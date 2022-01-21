using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class Axis : Template
    {
        public static readonly Guid ID = Guid.Parse("e57522d4-5e50-44c7-bbcb-1c4d0d81baeb");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.OuterSpherePlane.ID, 
                AlignmentId = Alignments.Instances.LawfulNeutral.ID, 
                Name = "Axis", 
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a996b52a-fae7-45c6-ba4a-dd5157c94122"), Type = TextBlockType.Text, Text = "Axis is a realm of pure, absolute law, unhindered by the moral concerns of good or evil. The plane takes the form of a vast, gleaming, perfectly structured city. Built at the base of Pharasma's Spire, the Perfect City is a bulwark against the chaos of the Maelstrom and Abyss, with vast mechanical armies of inevitables marching forth to explore, define, and pacify an imperfect, unruly universe. Axis is also home to axiomites: beings composed of living mathematics and equations who helped create the first inevitables. Axiomites continue to work on the maintenance of the inevitables, but increasingly turn their attentions to the planar city of Axis itself; as with any city, Axis requires non-stop maintenance and improvement in order to resist the march of time." };
            yield return new TextBlock { Id = Guid.Parse("46452f41-8999-430c-9cba-ed0aa8c44418"), Type = TextBlockType.Text, Text = "Axis's natives are far from the only inhabitants of their cosmopolitan realm. Devils and archons often visit along with petitioners, mortal travelers, and smaller numbers of most every other kind of extraplanar being. Abadar and other lawful deities make their homes here. The empty, former domain of Aroden languishes here, while below the streets lies Norgorber's domain, a labyrinthine undercity." };
        }
    }
}
