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
    public class DriveByAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("0b6cf965-f780-4354-935b-11e558cb1bed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drive-By Attack",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("29dafc95-42b1-4923-80c6-9c93128d159e"), Type = TextBlockType.Text, Text = $"You can smoothly line up an attack without disrupting your control. You Drive, gaining the effects of the Drive action for the same number of actions you spent to Drive-By Attack. At any point during your vehicle's movement, you {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("f3a23bb0-0b52-4dc9-8cf3-23204cb47efb"), Type = TextBlockType.Text, Text = $"You may use ONE-ACTION to THREE-ACTIONS when performing this activity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ad495c79-d30e-497c-a5f5-afab6fb77e4b"), Feats.Instances.TrickDriverDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e1eeed96-1b1f-402e-8713-1a532fba7fe5"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("5c7683db-a796-479b-958f-766fcfac02ba"), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd6e2819-3251-4aab-8fd3-ba4c8a344d44"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
