using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EagleEye : Template
    {
        public static readonly Guid ID = Guid.Parse("0e03a288-87f5-4ec3-8e82-9cb1a24a81a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eagle Eye",
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
            yield return new TextBlock { Id = Guid.Parse("9d58ef23-dd48-4a24-ad33-e9f7560ed202"), Type = TextBlockType.Text, Text = "Your practice with crossbows and firearms has sharpened your attention to detail. You become a master in Perception." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ebb78993-7ed9-47cf-b4f2-491faa47c2de"), Feats.Instances.GunslingerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("f2d9fd76-a37a-4027-bd2e-2bb960809943"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f34dc612-de2b-453c-a352-d06e7ada5ae8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
