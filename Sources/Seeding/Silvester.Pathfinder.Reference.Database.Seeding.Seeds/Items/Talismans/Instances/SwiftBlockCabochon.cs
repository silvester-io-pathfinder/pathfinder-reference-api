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
    public class SwiftBlockCabochon : Template
    {
        public static readonly Guid ID = Guid.Parse("f255e73f-f5e2-4c00-9c19-5a2925dbbe43");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Swift Block Cabochon",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c85ea4a2-6431-40a5-ae0d-f338285d9aad"), "");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("cba26476-4e0e-4e1d-bcc7-06b273e07dd2"),
                Name = "Swift Block Cabochon",
                Usage = "Affixed to a shield.",
                Level = 7,
                Price = 7000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("266697b0-d298-4304-83cb-62cfac465f61"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You take damage from a physical attack while you don't have the affixed shield raised.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d4a7e345-524b-41ed-bf31-a4088efba7e0"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("306ff431-6c08-407e-953e-8df986f0bda1"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("f0d129b8-21bd-4486-967e-ef114f56ecda"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("f3defa87-2dba-40e8-bf97-b4b6b63d2bfc"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3ef462d-e302-44eb-b291-c1c7f538f556"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 569
            };
        }
    }
}
