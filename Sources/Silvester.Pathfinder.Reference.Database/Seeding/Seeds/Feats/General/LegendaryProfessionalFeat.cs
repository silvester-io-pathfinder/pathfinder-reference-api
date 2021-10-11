using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryProfessionalFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("171b6ae6-cda9-45a7-8c0a-64672e338e0b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Professional",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1851b98-e05d-4c7a-bed7-90b4e44ddc0a"), Type = Utilities.Text.TextBlockType.Text, Text = "Your fame has spread throughout the lands (for instance, if you have Warfare Lore, you might be a legendary general or tactician). This works as Legendary Performer above, except you gain higher-level jobs when you Earn Income with Lore." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new LorePrerequisite { Id = Guid.Parse("526aa978-d5c8-4482-a522-73605e128b2c"), RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a54d3285-6bc9-49a6-ac04-ce123d54e2af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 263
            };
        }
    }
}
