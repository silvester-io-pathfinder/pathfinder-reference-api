using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalTools.Instances
{
    public class Tindertwig : Template
    {
        public static readonly Guid ID = Guid.Parse("37fff04c-1d07-49d9-ae10-02fb910e782b");

        protected override AlchemicalTool GetAlchemicalTool()
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Tindertwig",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("237853b6-f295-4158-bb31-dc141d046bae"), "An alchemical substance applied to one end of this tiny wooden stick ignites when struck against a rough surface. Creating a flame with a tindertwig is much faster than creating a flame with flint and steel. You can ignite the tindertwig and touch it to a flammable object as part of the same Interact action.");;
        }

        protected override IEnumerable<AlchemicalToolVariant> GetAlchemicalToolVariants()
        {
            yield return new AlchemicalToolVariant
            {
                Id = Guid.Parse("fe684bf2-016c-4d4e-bc87-089a7796cc63"),
                Name = "Tindertwig",
                Level = 1,
                Price = 20,
                Usage = "Held in 1 hand",
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5967d436-348d-40f4-bf16-ab4021ccbd2b"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("52c58592-97a1-47f0-97c6-cf5c6319e38e"), "Ignite the tindertwig by stricking it against a rought surface. You can ignite the tindertwig and touch it to a flammable object as part of the same Interact action.");
                            });
                    })
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("00005d2b-16a6-4ac1-903e-a2fde9db78cd"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("b66858ad-a5cb-48fb-898a-138322623a0a"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("d58e8cc3-c565-47da-ad34-637bd44db362"), Traits.Instances.Fire.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("14701f2b-1426-4501-b27f-c048f157301e"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }

    }
}
