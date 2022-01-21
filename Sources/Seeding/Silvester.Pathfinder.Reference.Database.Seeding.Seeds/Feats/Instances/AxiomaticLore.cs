using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AxiomaticLore : Template
    {
        public static readonly Guid ID = Guid.Parse("037f245f-1899-453b-b84e-caae2dfcf091");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Axiomatic Lore",
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
            yield return new TextBlock { Id = Guid.Parse("5ddf3aca-c96b-4e6c-a513-6e06908c78af"), Type = TextBlockType.Text, Text = $"You possess a strong understanding of process among mortals and lawful outsiders alike. The source of this knowledge might be intuition, study, or a childhood spent among other aphorites. You gain the trained proficiency rank in Diplomacy and Society. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Axis Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("148b009d-9193-4620-bc73-c8f6ba4fcaed"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
