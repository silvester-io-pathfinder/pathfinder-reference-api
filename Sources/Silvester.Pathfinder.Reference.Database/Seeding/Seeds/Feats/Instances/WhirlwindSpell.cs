using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlwindSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("f3daef4b-2bb9-458c-86c2-2f7edf2e8099");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirlwind Spell",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c6b79a6-871a-4410-a5d1-4b43dbfe2a51"), Type = TextBlockType.Text, Text = "You combine the might of a multitarget spell with a whirling flurry of attacks. You use (feat: Spellstrike), making a melee (action: Strike) against each enemy within your reach instead of against one enemy. If your spell can affect multiple targets, your spell affects all foes you hit, not just the first target, up to the spell’s normal maximum targets. If you (action: Strike) more foes than the spell could target, choose which foes are affected by the spell. Each attack counts toward your multiple attack penalty but doesn’t increase your penalty until you’ve made all your attacks." };
            yield return new TextBlock { Id = Guid.Parse("eed90bf0-b4fd-444b-8913-f0cf9903227d"), Type = TextBlockType.Text, Text = "If you use (feat: Expansive Spellstrike) to (feat: Spellstrike) with an area spell, apply the area as described in (feat: Expansive Spellstrike), choosing one of the creatures you (action: Strike) to determine the area and whether the spell fails due to a critically failed Strike. If you use (feat: Expansive Spellstrike) to (feat: Spellstrike) with a targeted spell, each creature you critically fail to (action: Strike) is unaffected by the spell, but the spell isn’t lost completely from a single critical failure." };
            yield return new TextBlock { Id = Guid.Parse("9596c826-2be9-4a52-940f-d4d897abc020"), Type = TextBlockType.Text, Text = "You can use this activity with only melee (action: Strikes | Strike), even if you have the starlit span hybrid study or a similar ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("54034e27-2684-4aee-8dba-abd573ff889c"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b19d79e-2752-452b-88c3-5619306db3ae"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
