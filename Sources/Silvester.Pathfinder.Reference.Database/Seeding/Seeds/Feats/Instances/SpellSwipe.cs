using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellSwipe : Template
    {
        public static readonly Guid ID = Guid.Parse("01494250-9bbe-4538-9711-a05e378ed051");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spell Swipe",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6f97880c-e831-4e7f-abf4-248b6b6c4032"), Type = TextBlockType.Text, Text = "You attack in an arc and enact your spell against everyone you hit. Make a (feat: Spellstrike), but roll separate (action: Strikes | Strike) to attack two creatures, each of whom must be within your melee reach and adjacent to each other. If your spell could affect two or more targets, your spell affects whichever foes you hit, not just the first target; otherwise, choose one target to affect with the spell. A Spell Swipe counts as two attacks for your multiple attack penalty, but the penalty doesn’t increase until after you make both attacks." };
            yield return new TextBlock { Id = Guid.Parse("c343e9c5-1f4f-412d-af54-5434f66aee01"), Type = TextBlockType.Text, Text = "If you’re using a weapon that has the (trait: sweep) trait, its circumstance bonus applies against both targets. You can use this activity with only melee (action: Strikes | Strike), even if you have the starlit span hybrid study or a similar ability." };
            yield return new TextBlock { Id = Guid.Parse("07764c1a-75cb-4623-a3d9-3ef1f84d3191"), Type = TextBlockType.Text, Text = "If you use (feat: Expansive Spellstrike) to (feat: Spellstrike) with an area spell, apply the area as described in (feat: Expansive Spellstrike), choosing one of the creatures you (action: Strike) to determine the area and whether the spell fails due to a critically failed (action: Strike). If you use (feat: Expansive Spellstrike) to (feat: Spellstrike) with a targeted spell, the spell is lost completely only if both (action: Strikes | Strike) are critical failures" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e9176e11-e937-49d6-8ff9-eda727f3d84a"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1eb63092-f176-4ff8-9cd7-6eb335962d3c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
