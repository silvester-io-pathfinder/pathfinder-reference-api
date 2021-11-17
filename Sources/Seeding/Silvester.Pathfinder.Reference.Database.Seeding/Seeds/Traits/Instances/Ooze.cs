using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Ooze : Template
    {
        public static readonly Guid ID = Guid.Parse("507589cf-c145-4184-91fc-20e5638dfaf7");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ooze",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4b1ff51d-f758-4a92-8d08-0067795d59b6"), Type = TextBlockType.Text, Text = "Oozes are creatures with simple anatomies. They tend to have low mental ability scores and immunity to mental effects and precision damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cda82bc2-45e9-4c57-964d-88e4c854ea5f"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
