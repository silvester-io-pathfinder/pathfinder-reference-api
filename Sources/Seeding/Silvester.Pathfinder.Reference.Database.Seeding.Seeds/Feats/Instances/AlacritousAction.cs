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
    public class AlacritousAction : Template
    {
        public static readonly Guid ID = Guid.Parse("782a67d6-6929-485c-86df-380be3026e66");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alacritous Action",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e31af7b7-64e2-470d-861a-5da5d29c6736"), Type = TextBlockType.Text, Text = $"Your eidolon moves more quickly. It gains a +10-foot status bonus to its Speed." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("79ea8161-8a34-4b2f-8312-3d890a61f5d6"), Traits.Instances.Evolution.ID);
            builder.Add(Guid.Parse("8861a67c-bb85-4458-b802-0d94f08f7410"), Traits.Instances.Summoner.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f6add2a-6cf7-4567-b87d-c92be63f5edb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
