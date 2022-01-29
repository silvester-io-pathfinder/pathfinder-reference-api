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
    public class GlyphExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("1748dcfc-c501-4cfc-ab0c-8a40774d0e26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glyph Expert",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("57bdfe32-5248-4d75-8a4b-571182f51573"), Type = TextBlockType.Text, Text = $"You've learned to recognize the telltale writings and other signs that indicate the presence of magical traps. You gain a +2 circumstance bonus to Perception checks to find magical traps, to AC against attacks made by magical traps, to saves against magical traps, and to checks to {ToMarkdownLink<Models.Entities.SkillAction>("Disable", SkillActions.Instances.DisableADevice.ID)} magical traps. Even if you aren't {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}, you get a check to find magical traps that normally require you to be {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}. You still need to meet any other requirements to find the trap." };
            yield return new TextBlock { Id = Guid.Parse("da22372d-18c7-47ef-8193-46769851aed3"), Type = TextBlockType.Text, Text = $"You're also adept at avoiding the effects of traps that feature magical writing, such as runes, glyphs, ancient script, or other forms. When you attempt a saving throw against the effects of these traps, if you roll a success, you get a critical success instead. If you roll a critical failure, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("33a503b3-948f-41ba-b8ca-1b37e4a627ee"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f20658e2-2eaa-4eed-913e-767c17d973b6"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
