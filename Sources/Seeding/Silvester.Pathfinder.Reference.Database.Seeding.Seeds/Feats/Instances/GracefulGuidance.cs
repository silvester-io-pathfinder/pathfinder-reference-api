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
    public class GracefulGuidance : Template
    {
        public static readonly Guid ID = Guid.Parse("dbc53f71-fa82-4e82-a2cf-9cea1ed47beb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Graceful Guidance",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("91ab668f-ccdb-46d8-b39f-ef3ebaed90d1"), Type = TextBlockType.Text, Text = $"You can demonstrate how to quickly twist out of the way of dangerous effects. You can use the {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} reaction to grant a bonus to an ally's Reflex save. As usual for {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)}, you need to prepare by using an action on your turn to encourage the ally." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Catfolk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19fcfbdf-5f1a-419d-a4ff-c380c089f7b9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
