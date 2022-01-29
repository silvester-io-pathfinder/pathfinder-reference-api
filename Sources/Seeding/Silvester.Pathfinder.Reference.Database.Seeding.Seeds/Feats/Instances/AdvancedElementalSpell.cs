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
    public class AdvancedElementalSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("630bec0c-97e6-49dd-9efb-e9fa54670706");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Elemental Spell",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5278f2b4-76b0-4d2a-9ec2-26bc2e92e65f"), Type = TextBlockType.Text, Text = $"Your connection to one of the great elemental aspects of nature deepens, allowing you further control over its powers. You gain the advanced order spell associated with your order: if you're a member of the flame order, you gain {ToMarkdownLink<Models.Entities.Spell>("combustion", Spells.Instances.Combustion.ID)}; if you're a member of the stone order, you gain {ToMarkdownLink<Models.Entities.Spell>("stone lance", Spells.Instances.StoneLance.ID)}; if you're a member of the storm order, you gain {ToMarkdownLink<Models.Entities.Spell>("powerful inhalation", Spells.Instances.PowerfulInhalation.ID)}; if you're a member of the wave order, you gain {ToMarkdownLink<Models.Entities.Spell>("pulverizing cascade", Spells.Instances.PulverizingCascade.ID)}. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("0d91abe9-88a5-4fcb-88ce-4c0659c04fb3"), or => 
            {
                or.HaveSpecificDruidicOrder(Guid.Parse("2804efb1-aac8-4fbd-9329-1c3aadc7b4fc"), DruidicOrders.Instances.Flame.ID);
                or.HaveSpecificDruidicOrder(Guid.Parse("0e2651a2-ad33-4512-aa6b-64c3023d4299"), DruidicOrders.Instances.Stone.ID);
                or.HaveSpecificDruidicOrder(Guid.Parse("d64a5500-2a39-465c-8df2-e55482d8e46a"), DruidicOrders.Instances.Storm.ID);
                or.HaveSpecificDruidicOrder(Guid.Parse("efa61d17-5880-4b25-873e-17f490383681"), DruidicOrders.Instances.Wave.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Druid.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e080c1f-0666-462a-a532-cb1c38b13f02"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
