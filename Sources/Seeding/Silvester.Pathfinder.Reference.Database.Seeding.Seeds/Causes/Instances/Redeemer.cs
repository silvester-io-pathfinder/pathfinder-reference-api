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
        public static readonly Guid ID = Guid.Parse("746573d4-63d7-43d2-a85b-abc34e6036da");
        
        protected override Cause GetCause()
        {
            return new Cause
            {
                Id = ID, 
                Name = "Redeemer",
                DivineSmite = MarkdownText.FromMarkdown(ID, $"A guilty conscience assails foes who spurn your Glimpse of Redemption. A foe that responds to your [Glimpse of Redemption](feats/{Feats.Instances.GlimpseOfRedemption.ID}) by dealing damage takes persistent good damage equal to your [Charisma](stats/{Stats.Instances.Charisma.ID}) modifier."),
                Exalt = "You protect multiple allies. You can apply the resistance granted by Glimpse of Redemption to yourself and all allies within 15 feet of you, including the triggering ally, except the resistance is reduced by 2 for all.",
                ClassId = Classes.Instances.Champion.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("de68291f-17a8-4836-ad41-f6e1088b0359"), Type = TextBlockType.Text, Text = "you're full of kindness and forgiveness. You gain the Glimpse of Redemption champion's reaction and the lay on hands devotion spell. After the tenets of good, add these:" };
            yield return new TextBlock { Id = Guid.Parse("d4bb2041-b9f9-44b2-89d8-f17b32b613b3"), Type = TextBlockType.Enumeration, Text = "You must first try to redeem those who commit evil acts, rather than killing them or meting out punishment. If they then continue on a wicked path, you might need to take more extreme measures." };
            yield return new TextBlock { Id = Guid.Parse("1548fd85-b08b-47a3-bc5e-2117b687dfbd"), Type = TextBlockType.Enumeration, Text = "You must show compassion for others, regardless of their authority or station." };
        }


        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("7d70d202-b9fa-4d69-bb2c-bc57ba4462e2"), Feats.Instances.GlimpseOfRedemption.ID);
            builder.GainSpecificSpell(Guid.Parse("7847c205-b5ff-4cd0-833a-4318180e1e5d"), Spells.Instances.LayOnHands.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08d34ca3-355e-41c7-808b-b8f7b35423ca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page =  106
            };
        }
    }
}
