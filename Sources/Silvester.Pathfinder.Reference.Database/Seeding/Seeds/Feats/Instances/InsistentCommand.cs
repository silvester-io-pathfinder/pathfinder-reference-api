using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InsistentCommand : Template
    {
        public static readonly Guid ID = Guid.Parse("61d34725-e567-4189-898f-bdcc9f6b51e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Insistent Command",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("984b176a-a7f2-4c9f-b072-59817764a031"), Type = TextBlockType.Text, Text = "When you roll a success to (action: Command an Animal), you get a critical success; if you roll a critical failure, you get a failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b678dbe2-d0df-48f4-aaa7-1aea04669435"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
            builder.HaveSpecificFeat(Guid.Parse("9753c3ae-8288-4d7f-b89b-9edc52d5aef7"), Feats.Instances.AnimalTrainedDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ebdf6a7-9e19-4297-9652-d85a490a8163"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
