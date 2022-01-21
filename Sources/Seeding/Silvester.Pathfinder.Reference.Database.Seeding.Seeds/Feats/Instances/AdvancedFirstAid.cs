using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedFirstAid : Template
    {
        public static readonly Guid ID = Guid.Parse("65ab8f38-e565-46ad-88a8-c119ff7448c4");

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
            yield return new TextBlock { Id = Guid.Parse("4b2a9766-f39b-420a-ab09-de79f2556ce9"), Type = TextBlockType.Text, Text = $"You use your medical training to ameliorate sickness or assuage fears. When you use Medicine to {ToMarkdownLink<Models.Entities.SkillAction>("Administer First Aid", SkillActions.Instances.AdministerFirstAid.ID)}, instead of Stabilizing a character or Stopping Bleeding, you can reduce an ally's frightened or sickened condition by 2, or remove either of those conditions entirely on a critical success. You can remove only one condition at a time. The DC for the Medicine check is usually the DC of the effect that caused the condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f58b0cd3-d71a-4447-9756-54a6bba9aebd"), Proficiencies.Instances.Master.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3576dfee-2767-4390-a2f5-532f59cb4362"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
