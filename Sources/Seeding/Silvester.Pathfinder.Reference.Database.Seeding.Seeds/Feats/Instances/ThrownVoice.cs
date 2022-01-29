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
    public class ThrownVoice : Template
    {
        public static readonly Guid ID = Guid.Parse("c6167721-2a2b-43c4-8ece-3e5aa7a2bc30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thrown Voice",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b70bc49a-db2a-4c19-997a-b6c3cf68e22a"), Type = TextBlockType.Text, Text = $"You've learned how to throw your voice through the winds, tricking others as to your location. You can cast {ToMarkdownLink<Models.Entities.Spell>("ventriloquism", Spells.Instances.Ventriloquism.ID)} as a primal innate spell once per day. If you're a songbird strix, you can cast it twice per day instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Strix.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6745bce8-1381-4f77-b001-315104c1d9b1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
