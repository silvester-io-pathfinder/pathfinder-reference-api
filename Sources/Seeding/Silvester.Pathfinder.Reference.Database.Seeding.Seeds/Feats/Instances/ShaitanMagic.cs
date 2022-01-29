using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShaitanMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("e83a1f35-ba9f-4581-a6f6-79df08d85c7e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shaitan Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("01de1ffc-28c7-4575-837a-43bbdcf04cdc"), Type = TextBlockType.Text, Text = $"The magic of shaitans runs through your blood. You can cast {ToMarkdownLink<Models.Entities.Spell>("glitterdust", Spells.Instances.Glitterdust.ID)} and {ToMarkdownLink<Models.Entities.Spell>("resist energy", Spells.Instances.ResistEnergy.ID)} once per day each as 2nd-level arcane innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a732baff-204c-480d-ab10-27b76949f6fc"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
