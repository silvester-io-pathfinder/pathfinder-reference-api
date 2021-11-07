using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedFirstAid : Template
    {
        public static readonly Guid ID = Guid.Parse("e8e6f265-8d9e-4a0e-afb9-06c9403a5be9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced First Aid",
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
            yield return new TextBlock { Id = Guid.Parse("e93c184a-a930-4011-b60c-e48520871896"), Type = TextBlockType.Text, Text = "You use your medical training to ameliorate sickness or assuage fears. When you use Medicine to (action: Administer First Aid), instead of Stabilizing a character or Stopping Bleeding, you can reduce an ally’s frightened or sickened condition by 2, or remove either of those conditions entirely on a critical success. You can remove only one condition at a time. The DC for the Medicine check is usually the DC of the effect that caused the condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("947819f1-b12d-4760-afa8-6cc7f49ad398"), Proficiencies.Instances.Master.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e857a77-a70e-4846-bb00-46916e38fd5f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
