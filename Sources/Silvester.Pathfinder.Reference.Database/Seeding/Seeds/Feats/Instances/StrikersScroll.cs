using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrikersScroll : Template
    {
        public static readonly Guid ID = Guid.Parse("7d4e3a8b-8064-4c36-abf6-066830bcaf4d");

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
            yield return new TextBlock { Id = Guid.Parse("0cff00b1-9569-4bb1-b41e-2c97d3151200"), Type = TextBlockType.Text, Text = "You can attach a scroll to your weapon or (item: handwraps of mighty blows) to blend its spell into an attack, carefully folding it around a part of the weapon or sealing it to the weapon’s surface. Attaching a scroll requires using the (action: Affix a Talisman) action (Core Rulebook 565). You can have only one scroll affixed to a weapon at a time, and you can’t have both a talisman and scroll attached." };
            yield return new TextBlock { Id = Guid.Parse("ef227dfc-0e59-433e-90d4-068d2c7cf1c5"), Type = TextBlockType.Text, Text = "You can (action: Cast the Spell | Cast a Spell) from the scroll as part of a (feat: Spellstrike), assuming the spell is one you could normally use with (feat: Spellstrike). You can’t (action: Cast the Spell | Cast a Spell) in any other way while it’s affixed, though you can use (action: Affix a Talisman) again to remove the scroll and use it as a normal—if a bit crumpled—scroll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9e6c3e1b-7e8f-459d-b09f-f65d1251af03"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("679d45ba-78c1-415d-a753-394aab576309"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
