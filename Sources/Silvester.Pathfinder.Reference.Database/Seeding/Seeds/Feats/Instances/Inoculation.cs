using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Inoculation : Template
    {
        public static readonly Guid ID = Guid.Parse("7f98bd82-4e5f-431e-9ff8-4dfd57e34df8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inoculation",
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
            yield return new TextBlock { Id = Guid.Parse("ee9ad620-8753-4599-b3a9-76fc1d59c9a9"), Type = TextBlockType.Text, Text = "You have practice combating plague, and your patients are less likely to succumb to the same disease again for a time. When you successfully (action: Treat a Disease | Treat Disease) on someone and they fully recover from the disease, they gain a +2 circumstance bonus to saving throws against that same disease for 1 week." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("fbd98b85-dca5-4a5d-8f63-bbef28bf10aa"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("398b4fb2-f4ff-451d-ab1f-f48ba720224a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
