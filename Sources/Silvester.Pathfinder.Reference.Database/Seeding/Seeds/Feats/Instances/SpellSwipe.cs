using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellSwipe : Template
    {
        public static readonly Guid ID = Guid.Parse("8a82180f-192d-4e85-9cf8-4fa9e9d4b5a9");

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
            yield return new TextBlock { Id = Guid.Parse("0300beb9-efce-4ea3-87fd-c2be7299844f"), Type = TextBlockType.Text, Text = "You attack in an arc and enact your spell against everyone you hit. Make a (feat: Spellstrike), but roll separate (action: Strikes | Strike) to attack two creatures, each of whom must be within your melee reach and adjacent to each other. If your spell could affect two or more targets, your spell affects whichever foes you hit, not just the first target; otherwise, choose one target to affect with the spell. A Spell Swipe counts as two attacks for your multiple attack penalty, but the penalty doesn’t increase until after you make both attacks." };
            yield return new TextBlock { Id = Guid.Parse("33cf17bf-5f63-452a-94e8-2b92a9a74bd9"), Type = TextBlockType.Text, Text = "If you’re using a weapon that has the (trait: sweep) trait, its circumstance bonus applies against both targets. You can use this activity with only melee (action: Strikes | Strike), even if you have the starlit span hybrid study or a similar ability." };
            yield return new TextBlock { Id = Guid.Parse("76cf799b-f20f-47d4-bedc-ac27913e3e52"), Type = TextBlockType.Text, Text = "If you use (feat: Expansive Spellstrike) to (feat: Spellstrike) with an area spell, apply the area as described in (feat: Expansive Spellstrike), choosing one of the creatures you (action: Strike) to determine the area and whether the spell fails due to a critically failed (action: Strike). If you use (feat: Expansive Spellstrike) to (feat: Spellstrike) with a targeted spell, the spell is lost completely only if both (action: Strikes | Strike) are critical failures" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("19cb154d-ca72-4a4d-92c9-ca83a813cb4a"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e21e8f42-060f-468f-8aff-1d254bdadc22"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
