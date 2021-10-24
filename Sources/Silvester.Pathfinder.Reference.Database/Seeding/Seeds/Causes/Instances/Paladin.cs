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
    public class Paladin : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Cause GetCause()
        {
            return new Cause
            {
                Id = ID, 
                Name = "Paladin",
                DivineSmite = "You surround evil targets in a punishing halo. If you hit with your Retributive Strike, the target takes persistent good damage equal to your Charisma modifier.",
                Exalt = "When you use Retributive Strike, each ally within 15 feet of you with the target in their melee reach can spend a reaction to Strike the target with a –5 penalty.",
                ClassId = Classes.Instances.Champion.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’re honorable, forthright, and committed to pushing back the forces of cruelty. You gain the Retributive Strike champion’s reaction and the lay on hands devotion spell. After the tenets of good, add these tenets:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must act with honor, never taking advantage of others, lying, or cheating." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "You must respect the lawful authority of legitimate leadership wherever you go, and follow its laws." };
        }


        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.RetributiveStrike.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.LayOnHands.ID);
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
