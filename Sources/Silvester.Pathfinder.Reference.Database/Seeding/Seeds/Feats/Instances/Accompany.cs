using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Accompany : Template
    {
        public static readonly Guid ID = Guid.Parse("8a04ef36-dafb-42c6-b74a-911bc61906aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Accompany",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet Casts a Spell.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6046086a-fa17-424c-a7cc-59575a555b0f"), Type = TextBlockType.Text, Text = "You use your performances to supplement an ally’s spellcasting, providing magical energy for their spells. Attempt a Performance check, using a very high DC for the ally’s level, and either spend a focus Point (if the triggering spell is a focus spell) or expend a spell slot at least 1 level higher than the triggering spell. If you succeed at the Performance check, your ally’s spell doesn’t cost the focus Point or spell slot." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6997744e-aaf8-4ef5-a92a-d8404734d061"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
