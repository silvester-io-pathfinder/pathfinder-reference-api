using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReadTheLand : Template
    {
        public static readonly Guid ID = Guid.Parse("f3a68c5f-f573-4f58-8fa9-9eec0bdc5203");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Read the Land",
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
            yield return new TextBlock { Id = Guid.Parse("2b2fc4e5-931a-4c98-8238-a20e9341f0ce"), Type = TextBlockType.Text, Text = "You’ve learned how to commune with the land to learn information. You learn the commune with nature ritual if you didn’t know it already. You can perform this ritual with a casting time of 1 hour instead of 1 day and without a secondary caster." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e9df0798-73de-4a0c-bfbd-d235192b818a"), Feats.Instances.GeomancerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ee0c8296-cbed-40a4-a953-b25d26620722"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ce4b882-bdc9-4b9f-8efe-0f0df2e59f7b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
