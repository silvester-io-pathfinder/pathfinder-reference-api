using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Causes.Instances
{
    public class Liberator : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Cause GetCause()
        {
            return new Cause
            {
                Id = ID, 
                Name = "Liberator",
                DivineSmite = "You punish those who ensnare your allies in bondage. If the triggering enemy was using any effects to make your ally grabbed, restrained, immobilized, or paralyzed when you used Liberating Step, that enemy takes persistent good damage equal to your Charisma modifier.",
                Exalt = "You can help your whole group get into position. When you use Liberating Step, if your ally doesn’t attempt to break free of an effect, you and all allies within 15 feet can Step, in addition to the triggering ally.",
                ClassId = Classes.Instances.Champion.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’re committed to defending the freedom of others. You gain the Liberating Step champion’s reaction and the lay on hands devotion spell. After the tenets of good, add these tenets:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must respect the choices others make over their own lives, and you can’t force someone to act in a particular way or threaten them if they don’t." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must demand and fight for others’ freedom to make their own decisions. You may never engage in or countenance slavery or tyranny." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.LiberatingStep.ID
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.LayOnHands.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page =  107
            };
        }
    }
}
