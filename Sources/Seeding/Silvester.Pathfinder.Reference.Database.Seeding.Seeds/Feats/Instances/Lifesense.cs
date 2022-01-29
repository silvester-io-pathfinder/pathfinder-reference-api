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
    public class Lifesense : Template
    {
        public static readonly Guid ID = Guid.Parse("1748d82b-6115-4620-963c-691913c7af9b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lifesense",
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
            yield return new TextBlock { Id = Guid.Parse("13721b90-3834-4446-9b5d-bb81e88e0e7e"), Type = TextBlockType.Text, Text = $"You have a limited ability to sense life force, like your psychopomp forebears. You gain lifesense as an imprecise sense with a range of 10 feet. This allows you to sense the life force within living creatures and its counterforce that animates the undead, though you can't distinguish between the two." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a68d8e86-772b-4eb3-95ef-02fd69d24ed7"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("a1150813-f019-45ac-a20c-2311b2f568a6"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("8e4e255a-bb2d-4600-a1cf-33817f8814ee"), Traits.Instances.Duskwalker.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f7f7872-16c2-4146-9d9b-830f30618298"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
