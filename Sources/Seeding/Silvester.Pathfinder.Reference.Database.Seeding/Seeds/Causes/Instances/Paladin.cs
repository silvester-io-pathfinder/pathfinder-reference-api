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
        public static readonly Guid ID = Guid.Parse("190e7af1-44f8-426b-b2c1-beb2da4e94aa");
        
        protected override Cause GetCause()
        {
            return new Cause
            {
                Id = ID, 
                Name = "Paladin",
                DivineSmite = "You surround evil targets in a punishing halo. If you hit with your Retributive Strike, the target takes persistent good damage equal to your Charisma modifier.",
                Exalt = "When you use Retributive Strike, each ally within 15 feet of you with the target in their melee reach can spend a reaction to Strike the target with a �5 penalty.",
                ClassId = Classes.Instances.Champion.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7a621b88-fec8-41eb-89f4-d258b52cf0a2"), Type = TextBlockType.Text, Text = "You�re honorable, forthright, and committed to pushing back the forces of cruelty. You gain the Retributive Strike champion�s reaction and the lay on hands devotion spell. After the tenets of good, add these tenets:" };
            yield return new TextBlock { Id = Guid.Parse("618bc755-a01f-409e-a827-dfb6e7880f53"), Type = TextBlockType.Enumeration, Text = "You must act with honor, never taking advantage of others, lying, or cheating." };
            yield return new TextBlock { Id = Guid.Parse("b4845a80-621f-4a71-8c33-76f727908fe1"), Type = TextBlockType.Enumeration, Text = "You must respect the lawful authority of legitimate leadership wherever you go, and follow its laws." };
        }


        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("803dff53-9dc2-4c2c-9494-812a311cc88a"), Feats.Instances.RetributiveStrike.ID);
            builder.GainSpecificSpell(Guid.Parse("9a6c7f8c-8de5-4050-a43e-3c564dc08a1e"), Spells.Instances.LayOnHands.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecbc4f57-9522-49d5-a6df-3615d880196b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page =  107
            };
        }
    }
}
