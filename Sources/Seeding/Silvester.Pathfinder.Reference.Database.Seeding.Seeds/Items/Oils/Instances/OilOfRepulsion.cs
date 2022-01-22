using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Oils.Instances
{
    public class OilOfRepulsion : Template
    {
        public static readonly Guid ID = Guid.Parse("70484a5f-afeb-4fe1-abe6-467e0f8c7984");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Oil of Repulsion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ab225760-e907-4991-baac-a172b2d03365"), "This oil contains magnetically charged iron filings repelled into opposite ends of the vial. For 1 minute after you apply this oil to armor, any creature that hits you with a melee Strike must attempt a DC 28 Fortitude save with the following effects.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("5d2c7edd-704b-4981-ae08-83b2b819ed5f"),
                Name = "Oil of Repulsion",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 11,
                Price = 17500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("372bbb63-4bea-4517-838b-c00870937b20"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .RollableEffect(Guid.Parse("5e731ab5-cfcf-4914-8be9-c8cfbdf4295b"), effect => 
                            {
                                effect.Success("The creature is unaffected.");
                                effect.Failure("The creature is pushed up to 10 feet away from you (the GM determines the direction).");
                                effect.CriticalFailure("As failure, and the creature is also knocked prone.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8d8ab21f-9de7-46b5-b733-dff714774b95"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("8173aef5-c990-4b13-a401-a740c0f76aef"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("7753e3fa-6c4e-46ae-83f8-7a52eeef087e"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("c3f33ccb-97ad-4b3a-8c5d-ff13ec0947ac"), Traits.Instances.Oil.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6018a16-748b-4d70-9174-427bc2902d09"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 562
            };
        }
    }
}
