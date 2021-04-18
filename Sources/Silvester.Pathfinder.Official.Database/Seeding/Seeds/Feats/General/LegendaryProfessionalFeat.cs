using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryProfessionalFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("171b6ae6-cda9-45a7-8c0a-64672e338e0b"),
                Name = "Legendary Professional",
                Level = 15
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1851b98-e05d-4c7a-bed7-90b4e44ddc0a"), Type = Utilities.Text.TextBlockType.Text, Text = "Your fame has spread throughout the lands (for instance, if you have Warfare Lore, you might be a legendary general or tactician). This works as Legendary Performer above, except you gain higher-level jobs when you Earn Income with Lore." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new LorePrerequisite { Id = Guid.Parse("526aa978-d5c8-4482-a522-73605e128b2c"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
