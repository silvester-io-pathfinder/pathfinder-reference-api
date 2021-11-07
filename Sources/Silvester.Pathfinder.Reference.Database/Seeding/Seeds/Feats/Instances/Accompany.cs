using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Accompany : Template
    {
        public static readonly Guid ID = Guid.Parse("0873fac4-3cd7-4e67-978c-4db2061ecf31");

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
            yield return new TextBlock { Id = Guid.Parse("d99a2a49-3852-464b-8c56-92d23bdb3e2b"), Type = TextBlockType.Text, Text = "You use your performances to supplement an ally’s spellcasting, providing magical energy for their spells. Attempt a Performance check, using a very high DC for the ally’s level, and either spend a focus Point (if the triggering spell is a focus spell) or expend a spell slot at least 1 level higher than the triggering spell. If you succeed at the Performance check, your ally’s spell doesn’t cost the focus Point or spell slot." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e91895ca-f4a3-4e35-acab-c0974e3aa3a1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
