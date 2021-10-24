using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Causes.Instances
{
    public class Redeemer : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Cause GetCause()
        {
            return new Cause
            {
                Id = ID, 
                Name = "Redeemer",
                DivineSmite = "A guilty conscience assails foes who spurn your Glimpse of Redemption. A foe that responds to your Glimpse of Redemption by dealing damage takes persistent good damage equal to your Charisma modifier.",
                Exalt = "You protect multiple allies. You can apply the resistance granted by Glimpse of Redemption to yourself and all allies within 15 feet of you, including the triggering ally, except the resistance is reduced by 2 for all.",
                ClassId = Classes.Instances.Champion.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’re full of kindness and forgiveness. You gain the Glimpse of Redemption champion’s reaction and the lay on hands devotion spell. After the tenets of good, add these:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must first try to redeem those who commit evil acts, rather than killing them or meting out punishment. If they then continue on a wicked path, you might need to take more extreme measures." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must show compassion for others, regardless of their authority or station." };
        }


        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.GlimpseOfRedemption.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.LayOnHands.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page =  106
            };
        }
    }
}
