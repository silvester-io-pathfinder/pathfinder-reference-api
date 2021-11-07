using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScholasticIdentification : Template
    {
        public static readonly Guid ID = Guid.Parse("8684b2ee-b385-491d-8336-c0adcda55c43");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scholastic Identification",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e9e70ee-b253-4647-a9da-24d250869760"), Type = TextBlockType.Text, Text = "You have the knowledge needed to understand ancient texts and cultural artifacts. You can use Society when (action: Deciphering Writing | Decipher Writing), no matter the type of writing you are examining. You can also use Society to (action: Identify Magic) when examining a magic item or location with cultural significance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5e634a2a-c1b9-4c9f-8852-dba81a3e0de8"), Feats.Instances.ArchaeologistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("856ca9d0-9023-418a-8195-ad09e45e6980"), Proficiencies.Instances.Master.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43f9864f-0f93-4ec1-a918-cbfb6e3174aa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
