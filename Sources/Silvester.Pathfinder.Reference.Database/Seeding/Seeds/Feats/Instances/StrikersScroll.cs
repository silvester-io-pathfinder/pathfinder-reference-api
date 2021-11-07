using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrikersScroll : Template
    {
        public static readonly Guid ID = Guid.Parse("0f8697cf-09b7-4dff-8900-f985210eaaf9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Striker's Scroll",
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
            yield return new TextBlock { Id = Guid.Parse("9832927b-2869-4dfc-ae0f-95bbb8b67d55"), Type = TextBlockType.Text, Text = "You can attach a scroll to your weapon or (item: handwraps of mighty blows) to blend its spell into an attack, carefully folding it around a part of the weapon or sealing it to the weapon’s surface. Attaching a scroll requires using the (action: Affix a Talisman) action (Core Rulebook 565). You can have only one scroll affixed to a weapon at a time, and you can’t have both a talisman and scroll attached." };
            yield return new TextBlock { Id = Guid.Parse("47bcbb4c-0098-432a-a95e-97306e761c50"), Type = TextBlockType.Text, Text = "You can (action: Cast the Spell | Cast a Spell) from the scroll as part of a (feat: Spellstrike), assuming the spell is one you could normally use with (feat: Spellstrike). You can’t (action: Cast the Spell | Cast a Spell) in any other way while it’s affixed, though you can use (action: Affix a Talisman) again to remove the scroll and use it as a normal—if a bit crumpled—scroll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("83ac4585-5e0a-4abc-bf7f-da940f32529d"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a6799cf-2dc2-4c86-8888-4790757dfb66"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
