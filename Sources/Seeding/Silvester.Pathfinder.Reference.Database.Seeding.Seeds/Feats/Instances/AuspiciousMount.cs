using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuspiciousMount : Template
    {
        public static readonly Guid ID = Guid.Parse("29e728cc-6a2f-45ad-81e6-f2ec6ebf3d44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Auspicious Mount",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("387d13af-d68d-4504-98d1-ec3c26192f02"), Type = TextBlockType.Text, Text = $"Guided by your ongoing care, your steed has developed incredible intelligence and skill. The mount you gained through the divine ally class feature is now a specialized animal companion (page 217). You can select one of the usual specializations or the auspice specialization." };
            yield return new TextBlock { Id = Guid.Parse("5903c454-d3c2-41d9-8630-afaa98e18ac7"), Type = TextBlockType.Text, Text = $"Auspice mounts gain the following benefits: Your companion is marked by your deity's religious symbol as a sacred creature of your deity. Its proficiency rank in Religion increases to expert, it can speak the language associated with your deity's servitors (Celestial for champions who follow the tenets of good), and its Intelligence modifier increases by 2 and its Wisdom modifier by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("e9c5f16f-5e1e-4e9b-9748-fe21159ac384"), DivineAllies.Instances.Steed.ID);
            builder.HaveSpecificFeat(Guid.Parse("58d074dc-b543-408d-be13-6ac0a65b108d"), Feats.Instances.ImposingDestrier.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("95089b2b-5611-4fdb-a961-f0aceba402a0"), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87cc4906-3c4d-4ff2-9559-bdf0d0eab9c2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
