using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellRunes : Template
    {
        public static readonly Guid ID = Guid.Parse("ea41d131-3253-480c-8fcb-f8bc1303b388");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spell Runes",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f74ad135-d5db-4929-a376-a39a5331e54d"), Type = TextBlockType.Text, Text = "The magical runes on your body grant you several magical abilities. Choose a 1st-level arcane spell. You gain a spell rune on your body corresponding to the chosen spell, which you can cast once per day as an innate spell. At 6th level, you gain a spell rune corresponding to a 2nd-level arcane spell, and at 8th level, you gain a spell rune corresponding to a 3rd-level arcane spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b0479952-eab5-4195-a540-ecb7dc231a27"), Feats.Instances.RunescarredDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37d1b3f3-4689-415a-9606-721b7f632827"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
