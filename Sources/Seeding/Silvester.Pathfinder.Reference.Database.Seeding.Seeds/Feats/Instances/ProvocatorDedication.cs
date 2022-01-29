using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProvocatorDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("c9df8ad3-1809-41ab-ac10-97a00ecd47b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Provocator Dedication",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the provocator archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("624d1803-3376-4390-a081-f373ae367bc8"), Type = TextBlockType.Text, Text = $"~ Access: Successfully defeat the eberarks in the Irorium." };
            yield return new TextBlock { Id = Guid.Parse("e84c3faf-bac9-4275-ac76-1e8321ec5f65"), Type = TextBlockType.Text, Text = $"For you, fighting is as much about style as skill. You become trained in simple weapons, martial weapons, and one advanced weapon of your choice. When you critically succeed at an attack roll using your chosen advanced weapon, you also apply the critical specialization of that weapon. You become an expert in Performance and your choice of either Acrobatics or Athletics. If you were an expert in all three of these skills, you instead become an expert in a skill of your choice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("1a15d84b-8807-45a8-b396-11a779bf2a72"), requiredStatValue: 14, Stats.Instances.Strength.ID);
            builder.HaveSpecificStat(Guid.Parse("639f82c4-6ef8-410e-8ee2-f8d2c31d0414"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7007213c-36f9-420e-85b0-1363959840d7"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
