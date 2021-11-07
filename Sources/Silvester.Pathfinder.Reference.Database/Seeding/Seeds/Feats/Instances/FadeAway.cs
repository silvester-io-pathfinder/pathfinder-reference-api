using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FadeAway : Template
    {
        public static readonly Guid ID = Guid.Parse("2b0237e0-920e-48d8-9ac0-26c82bcd0232");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fade Away",
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
            yield return new TextBlock { Id = Guid.Parse("a2d7a0fa-d412-47e0-aff0-504abb85ad6d"), Type = TextBlockType.Text, Text = "Your ability to blend into the background allows you to fade away entirely or appear innocuous even to magical effects. You gain (Spell: invisibility) and (Spell: misdirection) as 2nd-level innate occult spells. You can target only yourself with (Spell: invisibility), and you must be the primary target of (Spell: misdirection). You can cast each spell once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0d7eabcd-cf6a-427b-b284-530ce3eacd93"), Feats.Instances.EasilyDismissed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfe75ba4-efca-4445-ba6c-8049208d451c"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
