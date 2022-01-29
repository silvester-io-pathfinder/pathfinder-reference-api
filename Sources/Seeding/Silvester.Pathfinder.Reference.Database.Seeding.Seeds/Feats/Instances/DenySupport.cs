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
    public class DenySupport : Template
    {
        public static readonly Guid ID = Guid.Parse("fe23450a-5ce8-4285-808e-3b486c53d861");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deny Support",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e34b166e-0632-45cd-96ed-a8348b0830b1"), Type = TextBlockType.Text, Text = $"~ Access: Help either the Washboard Dogs or the Diobel Sweepers destroy their rival." };
            yield return new TextBlock { Id = Guid.Parse("7af94da7-14bc-4e83-bb37-3a4b92a8e9eb"), Type = TextBlockType.Text, Text = $"When you succeed or critically succeed at a Deception check to {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)} an opponent, that target can't flank with their allies until the beginning of your next turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ca0d375-0c64-4f63-906b-a687695c67c8"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
