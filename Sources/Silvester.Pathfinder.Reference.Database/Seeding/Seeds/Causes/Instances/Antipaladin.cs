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
    public class Antipaladin : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Cause GetCause()
        {
            return new Cause
            {
                Id = ID, 
                Name = "Antipaladin",
                DivineSmite = "An enemy damaged by the initial damage from your Destructive Vengeance also takes persistent evil damage equal to your Charisma modifier. This applies only to the damage the reaction itself deals to the triggering creature, not the damage you deal with subsequent Strikes.",
                Exalt = "When you use Destructive Vengeance, each enemy within 15 feet of you other than the triggering creature takes half the damage you deal to the triggering enemy, of the same damage type you chose.",
                ClassId = Classes.Instances.Champion.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You're dishonorable, dishonest, and committed to breaking the false hopes of kindness. You gain the Destructive Vengeance champion's reaction and the touch of corruption devotion spell. After the tenets of evil, add these tenets." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must not bind yourself with any law or oath beyond that of your code (though you can still select a champion feat with the oath trait). Act dishonorably, take advantage of others, lie, cheat, and steal to get what you want." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must destroy that which offends you and that which stands in your way, including—and perhaps especially—the forces of good and law that oppose you. This tenet doesn't force you to take action immediately if it could mean your destruction, nor does it require you to destroy something that might be useful if corrupted toward your ends." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.DestructiveVengeance.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TouchOfCorruption.ID);
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
