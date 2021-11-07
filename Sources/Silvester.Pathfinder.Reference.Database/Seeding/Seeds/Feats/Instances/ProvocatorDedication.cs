using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProvocatorDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("c9bbfc80-ab0d-4275-9ae5-c9cf494d07d1");

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
            yield return new TextBlock { Id = Guid.Parse("a8fa9554-87cf-4fc0-af31-54de3443e833"), Type = TextBlockType.Text, Text = "~ Access: Successfully defeat the eberarks in the Irorium." };
            yield return new TextBlock { Id = Guid.Parse("fd8319d5-46e0-4523-97d1-ac553732e920"), Type = TextBlockType.Text, Text = "For you, fighting is as much about style as skill. You become trained in simple weapons, martial weapons, and one advanced weapon of your choice. When you critically succeed at an attack roll using your chosen advanced weapon, you also apply the critical specialization of that weapon. You become an expert in Performance and your choice of either Acrobatics or Athletics. If you were an expert in all three of these skills, you instead become an expert in a skill of your choice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("c99595a5-5e17-4580-a14f-73442a1c413d"), requiredStatValue: 14, Stats.Instances.Strength.ID);
            builder.HaveSpecificStat(Guid.Parse("a05b4f50-1934-45b2-9eaa-803f1447c285"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f81ac3b-8a2e-4ccf-b281-a2381f047c08"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
