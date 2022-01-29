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
    public class BurrowElocutionist : Template
    {
        public static readonly Guid ID = Guid.Parse("466b9986-29ff-451b-91f4-e133df356d2e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Burrow Elocutionist",
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
            yield return new TextBlock { Id = Guid.Parse("cf917273-c419-41b3-a023-626727d07de3"), Type = TextBlockType.Text, Text = $"You recognize the chittering of ground creatures as its own peculiar language. You can ask questions of, receive answers from, and use the Diplomacy skill with animals that have a burrow Speed, such as badgers, ground squirrels, moles, and prairie dogs. The GM determines which animals count for this ability." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gnome.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2eabcae9-3eb1-4b7d-bc57-d768c03d6e93"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
