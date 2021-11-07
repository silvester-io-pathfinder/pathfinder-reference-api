using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShieldSalvation : Template
    {
        public static readonly Guid ID = Guid.Parse("c77eca4e-555f-4b80-91d0-f269b3214fb6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shield Salvation",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44bdf9c0-c098-42cd-b023-0dbe6532e673"), Type = TextBlockType.Text, Text = "You can save your shield from total destruction, even after a devastating attack. If a shield would be destroyed due to damage taken during your (feat: Shield Block), the shield remains intact at 1 Hit Point instead. Its construction is weakened until you take the time to repair it, preventing you from using Shield Salvation to save the same shield until your next preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ecabf884-e04c-4878-a464-d325f5b22d53"), Feats.Instances.BastionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8d710c5-29bd-4ddf-acf4-50ee3982cfb2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
