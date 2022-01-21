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
        public static readonly Guid ID = Guid.Parse("8634cc0c-be73-4f9c-9e12-bc3fbd011cb6");
        
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
            yield return new TextBlock { Id = Guid.Parse("1b98c01e-a615-4885-bb20-3c18a637c4e9"), Type = TextBlockType.Text, Text = "You�ve learned that in most cases, especially murders, criminals tend to leave more evidence of the crime on the body than they�d like to believe. Information from bruising, bone fractures, blood spatters, and even the life cycle of carrion insects can provide valuable clues that help reconstruct the scene." };
            yield return new TextBlock { Id = Guid.Parse("5b8729b8-6bae-43a8-820c-bd052875d906"), Type = TextBlockType.Text, Text = "You�re trained in Medicine and gain the Forensic Acumen (page 206) and Battle Medicine (Core Rulebook 258) skill feats. When you use Battle Medicine, on a success the target recovers additional Hit Points equal to your level, and the target becomes temporarily immune for only 1 hour, not 1 day." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("79a2f9c8-5b43-45fe-b1e0-062f56646cd8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
            builder.GainSpecificFeat(Guid.Parse("4902e1cb-c4b9-44d4-bddf-25043becb772"), Feats.Instances.ForensicAcumen.ID);
            builder.GainSpecificFeat(Guid.Parse("3d88e89a-43a2-4577-b052-58c4c4ed2bf9"), Feats.Instances.BattleMedicine.ID);
            //TODO: Add modifications to BattleMedicine.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b76cd116-fc64-4c52-a690-6af6a5a03d45"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 58
            };
        }
    }
}
