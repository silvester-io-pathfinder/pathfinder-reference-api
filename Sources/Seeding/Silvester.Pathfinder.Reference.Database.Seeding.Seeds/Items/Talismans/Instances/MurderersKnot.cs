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
    public class MurderersKnot : Template
    {
        public static readonly Guid ID = Guid.Parse("cead2963-0ade-4f7b-a5df-ce4a2586c3c7");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Murderer's Knot",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8b2423dc-3d8d-4d48-93ad-a355f3221e7e"), "This black strand of leather is tied to look like a peace knot when the weapon is worn, but it doesn't hamper drawing the weapon. When you activate the knot, the creature you damaged takes 1d6 persistent bleed damage.");
            builder.Text(Guid.Parse("eb5eadef-fad5-41f0-9ab8-dea59f9b4f77"), "If you have the Twist the Knife feat, the talisman instead deals persistent bleed damage equal to your sneak attack damage.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("b33395dc-1109-4778-b1cf-d00d75fad10f"),
                Name = "Murderer's Knot",
                Usage = "Affixed to a weapon.",
                Level = 7,
                Price = 6600,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("7e1a6260-09e1-4a1b-904c-55b3d6bbaca3"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command")
                            .Trigger("You damage a flat-footed creature with a Strike using the affixed weapon; Requirements You are an expert with the affixed weapon.")
                            .Requirements("You are an expert with the affixed weapon.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7fde18ec-eb1b-4b6e-9dd5-9123976d6770"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("8ad193a7-3cf2-45bf-921a-b33b95eb9472"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("42fc69a4-5d38-403f-b6a0-47425a06f51c"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("59cb17cf-6e6d-45a4-98be-78240c403a4b"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d910c6a-17df-4ef6-b097-0c9447b48924"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 568
            };
        }
    }
}
