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
    public class GallowsTooth : Template
    {
        public static readonly Guid ID = Guid.Parse("5d47a978-8aec-42f9-919e-370609139af1");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Gallows Tooth",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("16804889-bb5c-4f67-872e-a43eca17aad8"), "This grisly molar hangs from a cord threaded through a tiny hole just above its dried, exposed root. When you activate this talisman, the creature you're attacking becomes flat-footed until the end of the current turn.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("7337ecc2-b747-4ab4-aa6e-cce90918c670"),
                Name = "Gallows Tooth",
                Usage = "Affixed to a weapon.",
                Level = 8,
                Price = 10000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("38d6953a-de7b-45ca-9caf-1c73ca2b2c92"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Trigger("You attack an adjacent creature and haven't rolled your attack roll.")
                            .Requirements("You're a master in Intimidation.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("68689062-a634-425b-9b98-712b9a0ed808"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("0639b0d4-3170-489f-9c8a-de8701a9a0b2"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("8610ee4e-6889-48da-8e4c-3a889fc6a1ab"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("47039189-dc09-4ac2-a3a5-a188dd897c93"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d27b2a70-91b1-4908-8da3-de0956ef5b1b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 567
            };
        }
    }
}
