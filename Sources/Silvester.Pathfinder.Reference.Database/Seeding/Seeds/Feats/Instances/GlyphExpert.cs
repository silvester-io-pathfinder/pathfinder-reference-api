using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GlyphExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("2a73e007-5a8c-4d28-8e5a-569fc3b180af");

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
            yield return new TextBlock { Id = Guid.Parse("aa0676c7-de8f-4ecb-a7d2-dc19ba4acd27"), Type = TextBlockType.Text, Text = "You&#39;ve learned to recognize the telltale writings and other signs that indicate the presence of magical traps. You gain a +2 circumstance bonus to Perception checks to find magical traps, to AC against attacks made by magical traps, to saves against magical traps, and to checks to (action: Disable | Disable a Device) magical traps. Even if you aren&#39;t (action: Searching | Search), you get a check to find magical traps that normally require you to be (action: Searching | Search). You still need to meet any other requirements to find the trap." };
            yield return new TextBlock { Id = Guid.Parse("26adf2d6-fa7a-4aaa-a552-adeb1a403d90"), Type = TextBlockType.Text, Text = "You&#39;re also adept at avoiding the effects of traps that feature magical writing, such as runes, glyphs, ancient script, or other forms. When you attempt a saving throw against the effects of these traps, if you roll a success, you get a critical success instead. If you roll a critical failure, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("57dc0346-2328-423b-a358-a210f48dfae3"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc3b9113-ba99-440f-9735-3d455fc4817a"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
