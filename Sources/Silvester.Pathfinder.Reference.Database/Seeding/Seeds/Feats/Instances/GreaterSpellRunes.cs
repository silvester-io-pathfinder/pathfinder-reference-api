using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterSpellRunes : Template
    {
        public static readonly Guid ID = Guid.Parse("a4f9d12c-73d5-4810-a701-3c798c820489");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Spell Runes",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4025cd2e-c81a-42de-8ef7-2223d88ded96"), Type = TextBlockType.Text, Text = "You gain more powerful spell runes. You gain a spell rune corresponding to a 4th-level arcane spell. At 12th level, you gain a spell rune corresponding to a 5th-level arcane spell, and at 14th level, you gain a spell rune corresponding to a 6th-level arcane spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e6dfbb06-0529-4b33-a30a-41b0d1e238ef"), Feats.Instances.SpellRunes.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad4e84da-5285-4f3f-b6f1-86e9abdc383d"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
