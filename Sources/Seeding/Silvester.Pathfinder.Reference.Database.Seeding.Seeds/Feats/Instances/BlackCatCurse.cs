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
    public class BlackCatCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("f61fd1b1-3ff5-48b0-a428-f2b42d206832");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Black Cat Curse",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within 30 feet you can see would succeed at a save.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1361c916-3b0a-4df0-a60d-1c347fba50d8"), Type = TextBlockType.Text, Text = $"You hiss a spiteful curse at the creature. The target must reroll the triggering saving throw and use the worse result." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("0d422a8d-66b8-43e8-bb8b-f03c29ae65aa"), Traits.Instances.Catfolk.ID);
            builder.Add(Guid.Parse("13bdaf2d-6252-4e1e-a137-cd480ef8a6af"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("16ab0968-c2bc-4eb9-b5de-8c94b7c25b63"), Traits.Instances.Misfortune.ID);
            builder.Add(Guid.Parse("544b46ba-a384-4335-8d98-af540006292a"), Traits.Instances.Occult.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee5372eb-cf9d-428b-a69d-782f27392cf3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
