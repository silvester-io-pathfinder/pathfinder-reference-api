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
    public class DualEnergyHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("93fed03c-034f-4ade-b6bc-ee4deebf590c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual Energy Heart",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5da9b28b-ce05-4199-aabd-49f0c9bae591"), Type = TextBlockType.Text, Text = $"A second energy dwells in your eidolon. Choose an additional energy damage type. Your unarmed attack that deals energy damage gains the {ToMarkdownLink<Models.Entities.Trait>("versatile", Traits.Instances.Versatile.ID)} trait for the second energy damage type, and your eidolon gains resistance to the second type of energy damage equal to half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a6353d8d-65bd-41fe-8457-efe58bc181f2"), Feats.Instances.EnergyHeart.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Evolution.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Summoner.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1413a8ce-1562-40a3-b9b6-8cd068f96635"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
