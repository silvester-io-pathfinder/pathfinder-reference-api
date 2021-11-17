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
    public class Desecrator : Template
    {
        public static readonly Guid ID = Guid.Parse("81094ded-2714-425d-9d58-f06df4551a99");
        
        protected override Cause GetCause()
        {
            return new Cause
            {
                Id = ID, 
                Name = "Desecrator",
                DivineSmite = "If your Charisma modifier is +2 or greater, your resistance against the triggering damage equals your Charisma modifier + half your level.",
                Exalt = "When you use Selfish Shield, each enemy within 15 feet of you takes a �1 status penalty to attack rolls against you until the start of your next turn.",
                ClassId = Classes.Instances.Champion.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8647b281-f29a-41dd-9eff-9f3070c4edad"), Type = TextBlockType.Text, Text = "You always take what pleases you, no matter who it hurts, and you spread the influence of evil across all you touch. You gain the Selfish Shield champion's reaction and the touch of corruption devotion spell. After the tenets of evil, add this tenet." };
            yield return new TextBlock { Id = Guid.Parse("47add4c0-80b5-477e-ac53-71f53534b992"), Type = TextBlockType.Enumeration, Text = "Subvert or corrupt everything in your path that is pure and good, and sow doubt among those upholding such ideals." };
        }


        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("f8f2c8c4-1dd9-425c-8c5c-41b91689d001"), Feats.Instances.SelfishShield.ID);
            builder.GainSpecificSpell(Guid.Parse("6dba0772-ee8f-4abe-8c97-4387f9904edc"), Spells.Instances.TouchOfCorruption.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f049ebf-a71b-4ba6-8113-2e8cc80558ae"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 116
            };
        }
    }
}
