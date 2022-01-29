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
    public class KillingStone : Template
    {
        public static readonly Guid ID = Guid.Parse("3c571156-910c-44fb-af8c-368a01da053e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Killing Stone",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("193b04cc-fad6-42dd-80d6-910d8ab1a714"), Type = TextBlockType.Text, Text = $"Your star orb hides a deadly miasma. You can cast 5th-level {ToMarkdownLink<Models.Entities.Spell>("cloudkill", Spells.Instances.Cloudkill.ID)} as a divine innate spell once per day. The spell's normal components are replaced with a focus component (your star orb) and a somatic component to aim the orb towards the location for the spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("41d5a4c1-dbf0-4cbb-9e8b-1bb4d730d8c7"), Feats.Instances.StarOrb.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e7e42d1-2530-490f-bebf-26fd0290aabd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
