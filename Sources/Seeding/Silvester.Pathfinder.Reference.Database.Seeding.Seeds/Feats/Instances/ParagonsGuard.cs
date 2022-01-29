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
    public class ParagonsGuard : Template
    {
        public static readonly Guid ID = Guid.Parse("46393e65-23f6-4ad5-a820-859473cd0e81");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Paragon's Guard",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f65d68b8-a385-4b6b-8f8d-07f313e4daf6"), Type = TextBlockType.Text, Text = $"Once you've had a moment to set your stance, you always have your shield ready without a thought. While you are in this stance, you constantly have your shield raised as if you'd used the {ToMarkdownLink<Models.Entities.Action>("Raise a Shield", Actions.Instances.RaiseAShield.ID)} action, as long as you meet that action's requirements." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Stance.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5998c76d-5295-415d-a548-17b224c6be70"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
