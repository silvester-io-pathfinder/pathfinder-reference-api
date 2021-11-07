using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickenedAttunement : Template
    {
        public static readonly Guid ID = Guid.Parse("afda45fe-c919-4875-bb46-6f1e1559b70c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quickened Attunement",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't use Quickened Attunement and Quickened Casting in the same round.",
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee875d69-ed8e-4dd7-80be-56512b605ce5"), Type = TextBlockType.Text, Text = "If your next action is to cast a spell that would grant your terrain attunement bonus, reduce the number of actions to cast it by 1 (to a minimum of 1 action)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a1dab223-e522-460d-b92f-e180743a2ac3"), Feats.Instances.GeomancerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("9f301f8a-f145-4e8b-8e0b-cc6b2f092acb"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae46f47e-73f5-41f1-b236-86764f547852"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
