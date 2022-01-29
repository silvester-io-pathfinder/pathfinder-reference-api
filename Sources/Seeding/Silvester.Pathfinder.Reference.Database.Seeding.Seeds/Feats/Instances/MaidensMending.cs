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
    public class MaidensMending : Template
    {
        public static readonly Guid ID = Guid.Parse("16ce51ff-bf01-4833-ad96-d3631d632529");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Maiden's Mending",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You cast a non-cantrip occult spell or an innate spell from a changeling ancestry feat.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe2f1ee1-264e-4e38-9837-8e0c84ff7700"), Type = TextBlockType.Text, Text = $"You can tap into some of the magic that flows through your blood to give you new life. You gain a number of temporary Hit Points equal to half your level (minimum 1) that last until the end of your next turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Changeling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8fbead52-e79e-4d1d-bb45-f73fb71e4e7e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
