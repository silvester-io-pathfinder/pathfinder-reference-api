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
    public class JadeCat : Template
    {
        public static readonly Guid ID = Guid.Parse("164e8cb4-cebd-4c61-8538-f81f67cef242");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Jade Cat",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("369779d3-c564-4fe8-afd3-a7e2d39f250a"), "");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("d8c72716-c516-4533-a951-f74acb84ff8a"),
                Name = "Jade Cat",
                Usage = "Affixed to armor.",
                Level = 2,
                Price = 600,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("28c35a4a-e189-4e4f-8148-0a591bf48dd5"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You fall or attempt an Acrobatics check to Balance.")
                            .Requirements("You are trained in Acrobatics.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4faa3b40-1366-4257-9571-e8cc89a64d4d"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("fe054655-f992-48b8-b1aa-38b14a9b18aa"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("60db545c-5a0b-4a5c-bb6d-4e5cb1def131"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("5b7b94ee-91d8-4341-bc3a-0a8eb03f7aa2"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("10f72be2-ccec-4d33-93a1-4a04576d94db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 568
            };
        }
    }
}
