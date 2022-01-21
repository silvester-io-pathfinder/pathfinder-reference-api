using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class PersonaMask : Template
    {
        public static readonly Guid ID = Guid.Parse("332ba538-ab9d-4ba3-98b0-c8eb96bbb3d9");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Persona Mask",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e85b60ef-d99c-46ef-a025-dadf440e8607"), "Despite covering the entire face, this alabaster mask does not hinder vision or other senses. Wearing the mask grants a +1 item bonus to Performance checks while acting, orating, performing comedy, or singing.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b523e33d-362c-4d47-b204-6d2f88899de5"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("f72e4e10-6df8-4cae-a291-ac58e364757c"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("a4c5c7c1-a0c0-4497-815a-7b4460f4e148"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("061e5027-0256-4a99-acca-9a4c4900bede"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("47ffa2ab-b8cf-4560-97fc-833c0bcd86d0"),
                Name = "Persona Mask",
                Usage = "Worn mask.",
                Level = 3,
                Price = 5000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e8513dd5-583c-4e2c-928e-2827ff88261f"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("6b793177-5f6b-445d-8ce6-ecfd496667f4"), "You change the mask's appearance into an artistic rendition of a dramatic character of your choice.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("815466eb-d1d1-49b9-9eb5-088884ef3282"),
                Name = "Persona Mask (Greater)",
                Usage = "Worn mask.",
                Level = 9,
                Price = 65000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("30e37cee-a832-407d-aacf-dd341c35b305"), "The mask grants a +2 bonus and can be activated.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("d680cba8-d25d-494a-88a6-ffbe77727763"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                     {
                         action
                             .Kind("Envision")
                             .Details(builder =>
                             {
                                 builder.Text(Guid.Parse("eb16a761-d54d-4544-83aa-5fee5ad46fd9"), "You change the mask's appearance into an artistic rendition of a dramatic character of your choice.");
                             });
                     })
                    .Add(Guid.Parse("913402bb-ca72-4cf5-8507-8530d3e81f73"), ActionTypes.Instances.Reaction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You fail a Performance check that benefits from the mask's bonus.")
                            .Frequency("Once per day.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("4839b35a-57ed-427b-8ecb-619c5a6cdc20"), Traits.Instances.Fortune.ID);
                            })
                            .Details(effects =>
                            {
                                effects.Text(Guid.Parse("9acba094-31c6-4743-8225-67b9cf553be7"), "You change the mask's character and reroll the Performance check, using the second result.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8105468-32a0-40ed-8201-3936945386f0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 613
            };
        }
    }
}
