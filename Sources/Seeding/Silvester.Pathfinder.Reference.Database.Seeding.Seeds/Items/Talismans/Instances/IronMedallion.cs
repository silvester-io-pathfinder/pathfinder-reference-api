using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Talismans.Instances
{
    public class IronMedallion : Template
    {
        public static readonly Guid ID = Guid.Parse("f7aaf7b7-5caf-437c-936e-32936dc0b888");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Iron Medallion",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("dda7839c-3ee9-4a33-92a3-9837f0355e1d"), "This small medallion is shaped like a shield. When you activate it, you gain a +2 status bonus to saves against fear for 1 minute. On the triggering save, if the outcome of your roll is a failure, you get a success instead or if the outcome is a critical failure, you get a failure instead.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("c6ca86c4-2854-4dd3-a586-6354ae15e55e"),
                Name = "Iron Medallion",
                Usage = "Affixed to armor.",
                Level = 10,
                Price = 17500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ee04426e-36c1-4151-a280-601b50030c3b"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You attempt a Will save against a fear effect but haven't rolled yet.")
                            .Requirements("You have master proficiency in Will saves or have the bravery class feature.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2306f052-7303-434f-9821-849714964312"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("0a4fe395-0e10-4ccc-be34-94475da68a4a"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("23ee268f-df32-48d3-aad9-e1281705aa47"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("14ee440d-ae32-4493-a2c9-083c42c21034"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c325d678-9397-49bf-950c-4395abb60006"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 568
            };
        }
    }
}
