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
    public class BleedingFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("bba81858-d4cc-491e-9f82-3e6a11049278");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bleeding Finisher",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("184dacd5-f3bf-431f-822d-adcd2f408627"), Type = TextBlockType.Text, Text = $"Your blow inflicts profuse bleeding. Make a slashing or piercing {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a weapon or unarmed attack that allows you to add your precise strike damage. If you hit, the target also takes persistent bleed damage equal to your precise strike finisher damage." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8f51fda-fbb0-48a9-bd39-ee68f5875eb5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
