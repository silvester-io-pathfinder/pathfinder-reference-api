using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickIdentification : Template
    {
        public static readonly Guid ID = Guid.Parse("c3357d1c-f7f4-423e-9445-029518265f40");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Identification",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d3feead-6443-4a16-adbb-9cb413ede270"), Type = TextBlockType.Text, Text = "You can (action: Identify Magic) swiftly. You take only 1 minute when using (action: Identify Magic) to determine the properties of an item, ongoing effect, or location, rather than 10 minutes. If you’re a master, it takes a 3-action activity, and if you’re legendary, it takes 1 action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("9a0c1bc9-46c6-4967-ac1b-40e3a718082d"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("7c9a9af6-31d5-4143-ad7a-accf14e14986"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("64d5da23-905a-44d0-abee-f1d459194df4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("769f53f9-469f-47cf-ad8c-d388c0266271"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("9c3c7a7d-19ce-4c67-acf4-c9c2559c5f8b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ea302c0-1330-45bc-aa46-97deadca4517"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
