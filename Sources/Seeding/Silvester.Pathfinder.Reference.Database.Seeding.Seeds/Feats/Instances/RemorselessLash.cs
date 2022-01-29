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
    public class RemorselessLash : Template
    {
        public static readonly Guid ID = Guid.Parse("b84f6def-5d5e-4396-b8b1-56b6e991b94a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Remorseless Lash",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("859216c9-524f-406d-9c25-69614d0f723c"), Type = TextBlockType.Text, Text = $"You're skilled at beating a foe when their morale is already breaking. When you succeed at a melee weapon {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a frightened foe, that foe can't reduce their frightened condition below 1 until the beginning of your next turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("975dd6cd-6ea2-47af-a0eb-6e3a23b3809f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
