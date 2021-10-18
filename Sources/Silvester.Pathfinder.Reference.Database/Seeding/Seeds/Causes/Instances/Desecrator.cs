using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Causes.Instances
{
    public class Desecrator : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Cause GetCause()
        {
            return new Cause
            {
                Id = ID, 
                Name = "Desecrator",
                DivineSmite = "If your Charisma modifier is +2 or greater, your resistance against the triggering damage equals your Charisma modifier + half your level.",
                Exalt = "When you use Selfish Shield, each enemy within 15 feet of you takes a –1 status penalty to attack rolls against you until the start of your next turn.",
                ClassId = Classes.Instances.Champion.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You always take what pleases you, no matter who it hurts, and you spread the influence of evil across all you touch. You gain the Selfish Shield champion's reaction and the touch of corruption devotion spell. After the tenets of evil, add this tenet." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Subvert or corrupt everything in your path that is pure and good, and sow doubt among those upholding such ideals." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.SelfishShield.ID
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.TouchOfCorruption.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 116
            };
        }
    }
}
