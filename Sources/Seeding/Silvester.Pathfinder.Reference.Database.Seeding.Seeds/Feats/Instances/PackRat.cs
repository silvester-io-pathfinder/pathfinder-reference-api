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
    public class PackRat : Template
    {
        public static readonly Guid ID = Guid.Parse("867d6eb6-8020-4a91-a330-319eba939f6a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pack Rat",
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
            yield return new TextBlock { Id = Guid.Parse("e698660e-1f19-4b91-85e0-4e7bc34a8e8a"), Type = TextBlockType.Text, Text = $"Years of packing for travel have taught you how to cram vast quantities into small spaces. You can fit an additional 50% of the listed Bulk capacity into mundane storage containers or vehicles. For example, you can fit 6 Bulk in a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("backpack", Items.AdventuringGears.Instances.Backpack.ID)}, or 12 Bulk in a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("chest", Items.AdventuringGears.Instances.Chest.ID)}. This doesn't alter the items' Bulk, nor does it change how much you can store in a {ToMarkdownLink<Models.Entities.Trait>("magical", Traits.Instances.Magical.ID)} or {ToMarkdownLink<Models.Entities.Trait>("extradimensional", Traits.Instances.Extradimensional.ID)} storage space, such as a {ToMarkdownLink<Models.Items.Instances.HeldItem>("bag of holding", Items.HeldItems.Instances.BagOfHolding.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("cd467103-0a03-4f36-9942-cd04b24954ab"), Traits.Instances.Ratfolk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a037ebb7-964d-4c1f-b0dc-66b5eb34b37a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
