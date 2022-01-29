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
    public class MimicProtections : Template
    {
        public static readonly Guid ID = Guid.Parse("d80e14fe-cc82-4c9a-91b1-b09e1a2c3bb8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mimic Protections",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22f38834-f99d-4abe-8553-f15b1e8e2a05"), Type = TextBlockType.Text, Text = $"By adopting resonant reflections, you have learned to copy the abilities of other creatures as well. When you use {ToMarkdownLink<Models.Entities.Feat>("Hunt Prey", Feats.Instances.HuntPrey.ID)} on a foe within 100 feet, you gain resistance 10 to all damage types that target has resistance or immunity to for as long as the foe remains within 100 feet." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff6082c0-adb3-4778-8b47-20675ef3bd3b"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
