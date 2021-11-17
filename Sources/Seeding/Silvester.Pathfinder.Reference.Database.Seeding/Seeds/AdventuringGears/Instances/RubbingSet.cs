using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class RubbingSet : Template
    {
        public static readonly Guid ID = Guid.Parse("929665f3-dc26-4cd4-aa4b-01c2fee66be2");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Rubbing Set",
                Hands = "2",
                Price = 100,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("865d7423-d1f3-406b-adf2-1bc81dd9ee39"), Type = TextBlockType.Text, Text = "By using a rubbing set, you can quickly make a copy of carvings or etchings you find during your explorations, making them easier to accurately reproduce. This kit consists of a roll of thin onion-skin paper in a waterproof leather case, several thick wax crayons, and a bar of sealing wax that can be melted and used to temporarily hold the paper in place while you take the rubbing. Using the kit consumes the materials and provides a +1 item bonus on checks to document or reproduce artwork or writing that has been carved, etched, or otherwise physically added to a surface." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d87e786e-de4e-4bc8-8290-886eb7fac321"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
