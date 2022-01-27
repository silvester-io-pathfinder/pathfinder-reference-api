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
    public class SharkToothCharm : Template
    {
        public static readonly Guid ID = Guid.Parse("4bbb450c-3402-493d-a1a3-8b9c7cd22c77");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Shark Tooth Charm",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bf3bad33-a902-48ba-8264-156c02657236"), "This dried-seaweed bracelet is lined with charms shaped like small shark teeth. When you activate the bracelet, if you roll a success on the triggering check, you get a critical success instead (if you roll a critical failure, you get a failure instead). If you fail the Acrobatics check against a grabbing creature, the creature must either release you as a free action or take 2d8 piercing damage as shark�s teeth momentarily emerge from your skin.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("f52f9171-5820-4c5d-9b05-a980f996ac5e"),
                Name = "Shark Tooth Charm",
                Usage = "Affixed to armor.",
                Level = 5,
                Price = 2300,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fbc4450d-e196-4d82-a183-ad5ede1a0161"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command")
                            .Trigger("You attempt to Escape using Acrobatics for your roll, but you haven�t rolled yet.")
                            .Requirements("You are an expert in Acrobatics.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e76a10f5-4f38-4e35-aedc-a2c63dcf2465"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("c224c3c7-ac0a-4880-a136-313d43a1f9ca"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e9d61cb6-b19e-49da-b9a3-5c975618e325"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("ffeba3c3-2393-400c-bb05-cf598731898d"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b72e262a-d701-4b01-96a9-af29a85e95fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 569
            };
        }
    }
}
