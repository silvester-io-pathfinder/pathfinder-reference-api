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
    public class BloodseekerBeak : Template
    {
        public static readonly Guid ID = Guid.Parse("67e33b60-9fbd-451b-bb0c-05614b2fce81");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Bloodseeker Beak",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5197391c-328a-455a-8364-abc88d405506"), "This long, hollow proboscis is harvested from the notorious bloodseeker beast and drips a trickle of blood. When you activate the beak, you deal an extra 1d4 precision damage on your damage roll. If you deal sneak attack damage to the creature, you also deal 1d4 persistent bleed damage.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("3591f43c-95d0-4d9b-b571-44bada5ea563"),
                Name = "Bloodseeker Beak",
                Usage = "Affixed to a weapon",
                Level = 4,
                Price = 2000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a009864d-c35b-4317-8f27-637f7dc5ab09"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You hit a flat-footed creature with the affixed weapon.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("98b09569-5b14-4dc4-a6e9-ce8fb242f8ce"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("9017d2a8-725f-4cd2-b2e9-7558575546dd"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("cf34b9e8-dbab-4193-a96b-777be485d0e5"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("b0d55b7d-0b41-45e6-a364-a60abd41f8ee"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc7d377e-c34b-46bc-98f6-6c8965cc7239"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 565
            };
        }
    }
}
