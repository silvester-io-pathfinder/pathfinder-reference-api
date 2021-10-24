using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Methodologies.Instances
{
    public class ForensicMedicine : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Methodology GetMethodology()
        {
            return new Methodology
            {
                Id = ID, 
                Name = "Forensic Medicine",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’ve learned that in most cases, especially murders, criminals tend to leave more evidence of the crime on the body than they’d like to believe. Information from bruising, bone fractures, blood spatters, and even the life cycle of carrion insects can provide valuable clues that help reconstruct the scene." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’re trained in Medicine and gain the Forensic Acumen (page 206) and Battle Medicine (Core Rulebook 258) skill feats. When you use Battle Medicine, on a success the target recovers additional Hit Points equal to your level, and the target becomes temporarily immune for only 1 hour, not 1 day." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ForensicAcumen.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.BattleMedicine.ID);
            //TODO: Add modifications to BattleMedicine.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 58
            };
        }
    }
}
