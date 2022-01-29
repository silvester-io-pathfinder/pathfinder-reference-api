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
    public class Wortwitch : Template
    {
        public static readonly Guid ID = Guid.Parse("8c1fcb86-eb2c-431b-9584-a62ddacb1e64");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wortwitch",
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
            yield return new TextBlock { Id = Guid.Parse("90823d1b-c40d-4ebb-9380-9775e98fdc55"), Type = TextBlockType.Text, Text = $"You have a particular affinity for leafy plants. Your patron grants you a leshy familiar. If you already had a familiar, this leshy replaces your previous familiar, as if your previous familiar had been slain. In addition, you gain the ability to see through leaves, vines, and other foliage. You don't take circumstance penalties to ranged spell attacks or Perception checks caused by foliage, and your targeted attacks don't require a flat check to succeed against a target concealed only by such vegetation." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Witch.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5f05436-6772-4ff9-a343-50794284ce80"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
