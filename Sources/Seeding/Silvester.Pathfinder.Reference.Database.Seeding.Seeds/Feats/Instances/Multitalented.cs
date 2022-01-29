using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Multitalented : Template
    {
        public static readonly Guid ID = Guid.Parse("855c5669-8b7c-4c32-afa2-c080fcccad7d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Multitalented",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b74f1e37-59c0-4c83-92ac-978b688301f4"), Type = TextBlockType.Text, Text = $"You've learned to split your focus between multiple classes with ease. You gain a 2nd-level multiclass dedication feat, even if you normally couldn't take another dedication feat until you take more feats from your current archetype." };
            yield return new TextBlock { Id = Guid.Parse("456116e5-047f-4f9d-9909-8609cb7cb28c"), Type = TextBlockType.Text, Text = $"If you're a half-elf, you don't need to meet the feat's ability score prerequisites." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("de559f42-eb62-4add-af89-6fa997bb7061"), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c3b2b9e-c155-487a-a298-5c7e3f4f0630"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
