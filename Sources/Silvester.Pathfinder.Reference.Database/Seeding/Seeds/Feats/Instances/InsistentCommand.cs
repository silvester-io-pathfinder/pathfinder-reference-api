using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InsistentCommand : Template
    {
        public static readonly Guid ID = Guid.Parse("68c48235-9777-4beb-ad4e-c0d0a6baf3bb");

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
            yield return new TextBlock { Id = Guid.Parse("b3b18fa4-4e47-4524-84ec-909b07dcb711"), Type = TextBlockType.Text, Text = "When you roll a success to (action: Command an Animal), you get a critical success; if you roll a critical failure, you get a failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b6653136-0eb0-4e02-8203-6b2f8c5c365d"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
            builder.HaveSpecificFeat(Guid.Parse("c299e71d-3cab-4e28-b27d-ba02f8db7434"), Feats.Instances.AnimalTrainerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3f118cb-f4e7-4a83-8b16-36316c729d12"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
