using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Skill : Template
    {
        public static readonly Guid ID = Guid.Parse("6640d452-69f2-433d-b721-393a0bde16f5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Skill",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fabc30cb-cf5b-467d-8fa4-3242646a35da"), Type = TextBlockType.Text, Text = "A general feat with the skill trait improves your skills and their actions or gives you new actions for a skill. A feat with this trait can be selected when a class grants a skill feat or general feat. Archetype feats with the skill trait can be selected in place of a skill feat if you have that archetype’s dedication feat." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1865f32-89e7-4759-b5d4-107185630a36"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
