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
    public class PotencyCrystal : Template
    {
        public static readonly Guid ID = Guid.Parse("8d9e2011-351f-4aae-bd08-1d4065f68ced");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Potency Crystal",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("559a752b-7366-4ae0-8770-69d5253c9f91"), "This fluorite crystal glows with a strange phosphorescence. When you activate the crystal, the weapon becomes a +1 striking weapon for the rest of the turn, gaining a +1 item bonus to the attack roll and increasing the damage on a hit to two weapon damage dice.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("b0e020c1-cea8-4464-a7b0-ef77091f23bc"),
                Name = "Potency Crystal",
                Usage = "Affixed to a weapon.",
                Level = 1,
                Price = 400,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6b849dbe-20b4-431d-a6c6-69e57d3517c5"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You make an attack with the affixed weapon, but you haven't rolled yet.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4c76f6c7-bafa-4aba-941d-cff72a354619"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("c4e260c5-7c23-4c75-84a7-1337954392b7"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("d5f9efc6-3900-45dc-9ea2-dfff9f9360fa"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("60baf5cf-8ec8-445a-92ad-ccb34f574020"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("499cbd0e-1f0c-4ab9-9794-2cd17a6febf2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 569
            };
        }
    }
}
