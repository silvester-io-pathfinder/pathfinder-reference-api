using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkillMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("89d17056-b946-4f1e-b41f-db06b31bf497");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skill Mastery",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat up to five times.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f733158-fdef-4c25-87b6-9ecf0244b311"), Type = TextBlockType.Text, Text = $"Increase your proficiency rank in one of your skills from expert to master and in another of your skills from trained to expert. You gain a skill feat associated with one of the skills you chose." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f9098521-29b6-4014-a0f6-c55ad5de6020"), Feats.Instances.InvestigatorDedication.ID);
            builder.HaveAnySkillSpecificProficiency(Guid.Parse("f70f33a6-4aa8-47c9-9fd6-bd460add0256"), Proficiencies.Instances.Trained.ID);
            builder.HaveAnySkillSpecificProficiency(Guid.Parse("d4e8d1f0-6e20-4d95-b438-0a54b698ad39"), Proficiencies.Instances.Expert.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7cb6eb0f-f0ee-4430-8c3a-6ac2780e764f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
