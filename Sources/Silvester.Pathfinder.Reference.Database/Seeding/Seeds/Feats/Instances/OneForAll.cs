using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OneForAll : Template
    {
        public static readonly Guid ID = Guid.Parse("668e8af7-20a4-476c-bccf-cbf25e7cfb3e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One for All",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c6c25dd-dbb1-460e-b68f-d7b4545170bc"), Type = TextBlockType.Text, Text = "With precisely the right words of encouragement, you bolster an ally’s efforts. Designate an ally within 30 feet; this action counts as sufficient preparation to (action: Aid) that ally. When you use the (action: Aid) reaction to help that ally, you can roll Diplomacy in place of the usual check. If your swashbuckler’s style is wit and your Diplomacy check to (action: Aid) meets or exceeds the very hard DC for your level, you gain panache." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("10f40e83-6c5c-4dd7-bf93-c818408ac379"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e81a2bc-f877-4e03-ac22-16709c800efe"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
