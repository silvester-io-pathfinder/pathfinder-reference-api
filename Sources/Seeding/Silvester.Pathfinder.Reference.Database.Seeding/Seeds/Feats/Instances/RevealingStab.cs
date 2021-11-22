using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RevealingStab : Template
    {
        public static readonly Guid ID = Guid.Parse("57cf0b78-6db0-4f14-ad4a-7b152ff344e3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Revealing Stab",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c752bb37-7774-4d8f-8ba7-ca26298601ac"), Type = TextBlockType.Text, Text = "You drive your piercing weapon into an imperceptible foe, revealing its location to your allies. Make a (Action: Strike) with the required melee weapon. You don't have to attempt a flat check to hit a concealed creature, and you have to succeed at only a DC 5 flat check to target a hidden creature. If you hit and deal damage, you can drive the required weapon into a corporeal target, revealing its current position. You (Action: Release) the weapon, and it becomes lodged in the target. If the target is concealed, other creatures don't need to succeed at a flat check to hit it. If the target is hidden, other creatures have to succeed at only a DC 5 flat check to target it. The creatures need to be able to see your weapon to gain any of these benefits, and the target can't become undetected to anyone who sees your weapon. If the target is invisible, the weapon remains visible while lodged in it." };
            yield return new TextBlock { Id = Guid.Parse("a0246417-d34d-4ce6-a0b9-6e95985bb113"), Type = TextBlockType.Text, Text = "This benefit lasts until the weapon is removed from the creature. An adjacent creature or the target can remove the weapon with 2 (Action: Interact) actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cdb6cf9-a828-4f4f-8167-1faf37e7b431"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
