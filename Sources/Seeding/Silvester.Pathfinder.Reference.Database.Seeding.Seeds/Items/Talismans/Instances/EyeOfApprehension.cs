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
    public class EyeOfApprehension : Template
    {
        public static readonly Guid ID = Guid.Parse("4e825d83-0444-49d9-8347-99e04d4bb9cc");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Eye of Apprehension",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("903a1682-b6cf-4fce-aca1-571815a50bdf"), "This round piece of cymophane�s silky inclusion makes it look like a cat�s eye. While affixed, it makes you jittery.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("d9a50a38-e32f-410b-bdb9-b90251790618"),
                Name = "Eye of Apprehension",
                Usage = "Affixed to armor.",
                Level = 12,
                Price = 40000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8a01965f-f9af-4766-88f9-7b220ee6f1d7"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You are about to roll Perception for initiative but haven�t rolled yet.")
                            .Requirements("You are a master in Perception.")
                            .Details(effect => 
                            {
                                effect.Text(Guid.Parse("06711ec6-c9e9-47ab-861d-e44eb9f84ccd"), "Roll Perception twice and use the higher result");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5f55105a-1656-429f-941e-4b6af0e4c1b8"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("37c6a908-c218-4747-b915-3f569845d5b9"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("27d1f396-9bd6-4c0d-bfb3-6c3867442b2b"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("45e4020f-ae4c-4789-b64c-97037867979a"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff284466-54a6-4dc7-beb1-7ce7f584bef0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 566
            };
        }
    }
}
