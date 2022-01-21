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
    public class CloakOfElvenkind : Template
    {
        public static readonly Guid ID = Guid.Parse("67f6b3d5-aeb6-451b-a6e8-c9025d71eabc");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Cloak of Elvenkind",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("16d89550-3d44-4751-9f7c-44a55dd83559"), "This cloak is deep green with a voluminous hood, embroidered with gold trim and symbols significant in elven culture. The cloak allows you to cast the ghost sound cantrip as an arcane innate spell. When you adjust the cloak�s clasp (an Interact action), the cloak transforms to match the environment around you and muffles your sounds, granting you a +1 item bonus to Stealth checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7d199727-eded-4110-a275-9b6d238315c8"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("9bea7122-fd01-4202-9f17-8f35ad92b4e3"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("9a582567-2b18-4def-9242-feac1e1a4d81"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("8f803967-8e30-4bdd-a673-a20bcfd378a9"),
                Name = "Cloak of Elvenkind",
                Usage = "Worn cloak.",
                Level = 7,
                Price = 36000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()

                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("049f4765-bc19-4132-a29d-f6e73cd3aaaa"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                     {
                         action
                             .Kind("Interact")
                             .Frequency("Once per day.")
                             .Details(builder =>
                             {
                                 builder.Text(Guid.Parse("b3bd209f-fed7-416c-8697-37b27d36ae30"), "You draw the hood up and gain the effects of invisibility, with the spell�s normal duration or until you pull the hood back down, whichever comes first. If you�re also wearing boots of elvenkind, you can activate this ability twice per day.");
                             });
                     })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("a7652787-0fa2-4673-9835-f106468f2de1"),
                Name = "Cloak of Elvenkind (Greater)",
                Usage = "Worn cloak.",
                Level = 12,
                Price = 175000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("04489fc8-b589-4a51-988b-59e41cdbdbb1"), "The cloak grants a +2 item bonus, and the effects of 4th-level invisibility. If you're also wearing boots of elvenkind, the greater cloak of elvenkind allows you to Sneak in forest environments even when creatures are currently observing you.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("bf046147-3632-4400-93b0-ea513bb71ea0"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                     {
                         action
                             .Kind("Interact")
                             .Frequency("Once per day.")
                             .Details(builder =>
                             {
                                 builder.Text(Guid.Parse("bc73ab51-83f2-4fbc-9668-289a2c2f7003"), "You draw the hood up and gain the effects of 4th-level invisibility, with the spell's normal duration or until you pull the hood back down, whichever comes first. If you're also wearing boots of elvenkind, you can activate this ability twice per day, and you can Sneak in forest environments even when creatures are currently observing you.");
                             });
                     })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27ae901a-283f-4a34-b00b-5e6642ca98ec"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 608
            };
        }
    }
}
