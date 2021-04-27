using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Infused : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("fe38dce6-c98c-4641-8092-2b3bedf58746");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Infused",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7fdf825-5831-4064-9e56-f60021840ad0"), Type = TextBlockType.Text, Text = "You created an alchemical item with the infused trait using your infused reagents, and it has a limited time before it becomes inert. Any nonpermanent effects from your infused alchemical items, with the exception of afflictions such as slow-acting poisons, end when you make your daily preparations again." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bef0f9c3-2875-458e-83e3-08f29e8953b1"),
                SourceId = CoreRulebook.ID,
                Page = 75
            };
        }
    }
}
