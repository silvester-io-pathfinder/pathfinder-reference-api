using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DivineFonts.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Deities.Instances
{
    public class CaidenCailean : Template
    {
        public static readonly Guid ID = Guid.Parse("aa1df0bf-575b-45c3-b9fb-70caa7eb9d1e");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = ChaoticGood.ID,
                Name = "Caiden Cailean", 
                Description = "The Drunken Hero ascended from mortal life on a drunken dare, becoming the god of ale, freedom, and wine. Cayden promotes freedom and encourages others to find their own path in life. He fights for just causes and delights in the best indulgences.",
                Edicts = "Drink, free slaves and aid the oppressed, seek glory and adventure.",
                Anathema = "Waste alcohol, be mean or standoffish when drunk, own a slave.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Cities.ID;
            yield return Freedom.ID;
            yield return Indulgence.ID;
            yield return Might.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return NeutralGood.ID;
            yield return ChaoticGood.ID;
            yield return ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce605cd6-2cf8-4cb5-8372-1679f540271a"),
                SourceId = CoreRulebook.ID,
                Page = 437
            };
        }
    }
}
