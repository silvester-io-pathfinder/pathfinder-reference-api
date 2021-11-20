using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Causes.Instances
{
    public class Liberator : Template
    {
        public static readonly Guid ID = Guid.Parse("b0e2fee4-d8b4-49ee-bfdb-1005443eaecb");
        
        protected override Cause GetCause()
        {
            return new Cause
            {
                Id = ID, 
                Name = "Liberator",
                DivineSmite = MarkdownText.FromMarkdown(ID, $"You punish those who ensnare your allies in bondage. If the triggering enemy was using any effects to make your ally [grabbed](conditions/{Conditions.Instances.Grabbed.ID}), [restrained](conditions/{Conditions.Instances.Restrained.ID}), [immobilized](conditions/{Conditions.Instances.Immobilized.ID}), or [paralyzed]((conditions/{Conditions.Instances.Paralyzed.ID})) when you used [Liberating Step](feats/{Feats.Instances.LiberatingStep.ID}), that enemy takes persistent good damage equal to your [Charisma](stats/{Stats.Instances.Charisma.ID}) modifier."),
                Exalt = "You can help your whole group get into position. When you use Liberating Step, if your ally doesn�t attempt to break free of an effect, you and all allies within 15 feet can Step, in addition to the triggering ally.",
                ClassId = Classes.Instances.Champion.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("51fc9945-69de-47be-bbb7-021b114faf24"), Type = TextBlockType.Text, Text = "You�re committed to defending the freedom of others. You gain the Liberating Step champion�s reaction and the lay on hands devotion spell. After the tenets of good, add these tenets:" };
            yield return new TextBlock { Id = Guid.Parse("1612d7f9-df9d-41e8-a3da-525f468aa9b6"), Type = TextBlockType.Enumeration, Text = "You must respect the choices others make over their own lives, and you can�t force someone to act in a particular way or threaten them if they don�t." };
            yield return new TextBlock { Id = Guid.Parse("fa82479f-3f80-4b76-8cf9-cfccd23cd385"), Type = TextBlockType.Enumeration, Text = "You must demand and fight for others� freedom to make their own decisions. You may never engage in or countenance slavery or tyranny." };
        }


        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("e569047d-be53-4ee3-bcd4-b4f26f473146"), Feats.Instances.LiberatingStep.ID);
            builder.GainSpecificSpell(Guid.Parse("93c36937-ffbc-4008-9765-6c6b8d3060fc"), Spells.Instances.LayOnHands.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac0c430c-15c1-4a7e-96f0-cc1bcb7d567a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page =  107
            };
        }
    }
}
