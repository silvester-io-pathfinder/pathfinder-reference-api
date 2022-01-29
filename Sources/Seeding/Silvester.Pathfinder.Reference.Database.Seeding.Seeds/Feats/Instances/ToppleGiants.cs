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
    public class ToppleGiants : Template
    {
        public static readonly Guid ID = Guid.Parse("9145b135-e781-4c36-9f28-5f294ba87056");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Topple Giants",
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
            yield return new TextBlock { Id = Guid.Parse("783f551a-e321-4d37-a0ae-2cde4cea4f2e"), Type = TextBlockType.Text, Text = $"When you observe an ally try and fail to execute a strategic maneuver against your enemies, you coordinate with your other allies to finish the job, using the opening from the first attempt to keep your foe off-balance and ensure your eventual success." };
            yield return new TextBlock { Id = Guid.Parse("1dfd4375-61c4-488d-8320-b574e9ccc0b2"), Type = TextBlockType.Text, Text = $"When an ally within your overwatch field attempts to {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} an opponent within your overwatch field and fails, you coordinate efforts to provide a +2 circumstance bonus to the next Athletics check rolled by a different ally to attempt the same action on the same target before that target's next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a00b1626-e7b6-482c-bc49-49c8d31f8f68"), Feats.Instances.OverwatchDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80ab2339-26f7-49d7-83fd-336fb7764e21"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
