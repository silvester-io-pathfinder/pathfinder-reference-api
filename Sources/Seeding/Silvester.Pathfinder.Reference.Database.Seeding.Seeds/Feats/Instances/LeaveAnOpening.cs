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
    public class LeaveAnOpening : Template
    {
        public static readonly Guid ID = Guid.Parse("b5469623-ce13-4fad-97f5-1f87f9145b31");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leave an Opening",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("83487ca9-7b9d-4010-aed4-638453bc11fc"), Type = TextBlockType.Text, Text = $"When you hit hard enough, you leave an opening so your ally can jump in on the action. Whenever you critically hit a flat-footed opponent with a melee attack and deal damage, the target triggers an {ToMarkdownLink<Models.Entities.Feat>("Attack of Opportunity", Feats.Instances.AttackOfOpportunity.ID)} reaction from one ally of your choice who has that reaction, as if the enemy had used a manipulate action." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32162dee-b3ca-40af-8bdf-1a6de4d955b3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
