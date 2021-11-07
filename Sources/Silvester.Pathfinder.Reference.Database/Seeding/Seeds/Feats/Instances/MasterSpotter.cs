using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterSpotter : Template
    {
        public static readonly Guid ID = Guid.Parse("d0977003-b9fd-4699-8aa1-0be4de0a0c2c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Spotter",
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
            yield return new TextBlock { Id = Guid.Parse("35cda70d-1196-4363-89ad-265960f0a6b3"), Type = TextBlockType.Text, Text = "Your incredible perception and trusty enhanced visual gear allow you to see things others miss. Your proficiency rank in Perception increases to master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ed680797-7ab7-448c-869d-e05245a6d706"), Feats.Instances.OverwatchDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("05016cc6-fee0-4f1e-8dbf-a4137342756b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ce69f53-46e7-44f5-bc0c-f47c5eddbf0d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
