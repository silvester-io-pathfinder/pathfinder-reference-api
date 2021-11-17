using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Inoculation : Template
    {
        public static readonly Guid ID = Guid.Parse("ed4fb16e-71c4-49e0-96db-e0b191ac8ed8");

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
            yield return new TextBlock { Id = Guid.Parse("9bc309e4-d57d-441e-9648-6b12ed0a7b00"), Type = TextBlockType.Text, Text = "You have practice combating plague, and your patients are less likely to succumb to the same disease again for a time. When you successfully (action: Treat a Disease | Treat Disease) on someone and they fully recover from the disease, they gain a +2 circumstance bonus to saving throws against that same disease for 1 week." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f8290466-6e6a-428a-af46-e264e8ce5bd4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21ade120-387b-4062-b542-6940f322a2a6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
