using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpiritSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("001e4650-d3f3-4a36-ae9c-6ff3c4d418ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spirit Spells",
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
            yield return new TextBlock { Id = Guid.Parse("a4c84e33-8c9f-4828-937d-093c2d5bdc00"), Type = TextBlockType.Text, Text = "Your ability to confront incorporeal menaces develops into full-fledged spellcasting. Choose a 1st-level occult spell. You can (activity: Cast this Spell | Cast a Spell) as an innate occult spell. At 6th level, you gain a 2nd-level occult spell, and at 8th level, you gain a 3rd-level occult spell. Each of these spells must have the (trait: divination), (trait: enchantment), or (trait: necromancy) trait. You can cast each of these spells once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2ee56b2f-1011-4cc2-a0ae-17e6fa25cba3"), Feats.Instances.GhostHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a6acdc4-e9ac-4fd1-9bd4-2fd005dc1bef"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
