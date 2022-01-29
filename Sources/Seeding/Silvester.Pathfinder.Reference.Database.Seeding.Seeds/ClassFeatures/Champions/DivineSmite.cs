using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class DivineSmite : Template
    {
        public static readonly Guid ID = Guid.Parse("e294c1d9-d551-4372-ab2f-4f45cddf1810");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Divine Smite", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4d8466fb-f917-4cd6-b19c-2a3550d4b417"), Type = TextBlockType.Text, Text = "Your champion's reaction improves." };
            yield return new TextBlock { Id = Guid.Parse("790a0956-16ae-48ad-b937-badbf3de9687"), Type = TextBlockType.Enumeration, Text = "Paladin - You surround evil targets in a punishing halo. If you hit with your Retributive Strike, the target takes persistent good damage equal to your Charisma modifier." };
            yield return new TextBlock { Id = Guid.Parse("88aec12d-0b6c-46c4-abd5-8e674c0b2dde"), Type = TextBlockType.Enumeration, Text = "Redeemer - A guilty conscience assails foes who spurn your Glimpse of Redemption. A foe that responds to your Glimpse of Redemption by dealing damage takes persistent good damage equal to your Charisma modifier." };
            yield return new TextBlock { Id = Guid.Parse("e2e0d552-c7d3-4f72-aa6f-7df3adccba16"), Type = TextBlockType.Enumeration, Text = "Liberator - You punish those who ensnare your allies in bondage. If the triggering enemy was using any effects to make your ally grabbed, restrained, immobilized, or paralyzed when you used Liberating Step, that enemy takes persistent good damage equal to your Charisma modifier." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34e73114-efd2-4ae1-a0d0-528ecb1e1cdf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
