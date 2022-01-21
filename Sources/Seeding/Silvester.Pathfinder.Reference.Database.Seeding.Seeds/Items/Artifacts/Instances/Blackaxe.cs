using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Artifacts.Instances
{
    public class Blackaxe : Template
    {
        public static readonly Guid ID = Guid.Parse("926863c7-4212-4b4c-9351-72a59548218a");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Blackaxe",
            };
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("f7db9a11-7c57-4d7d-a7ca-37615be5ef1a"),
                Name = "Blackaxe",
                Level = 25,
                Hands = 2,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ca277f35-ec88-454a-8f06-3dc304030a85"), "This potent weapon used by Treerazer is a +4 greater corrosive major striking obsidian greataxe that grants a +4 item bonus to attack rolls, deals an extra 2d6 damage to plants, and has the properties of adamantine.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("53ef6a65-45e0-47d1-8a68-830f25141cb4"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Requirements("You aren't wielding Blackaxe and you are its true owner.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("400c4cb3-d3d4-48bb-a246-627058cfbb52"), Traits.Instances.Divination.ID);
                                traits.Add(Guid.Parse("b94a4f1c-2062-47f4-a94c-206be5fa5090"), Traits.Instances.Scrying.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("38022610-9803-4d96-aed8-5661d9064187"), "You sense the world around Blackaxe as though you were in its location and can use any of your innate spells through the link as if it were the source of the spell. If another creature is wielding Blackaxe, it must succeed at a DC 50 Will save or be slowed 2 until it relinquishes the weapon.");
                            });
                    })
                    .Add(Guid.Parse("0c37b3ea-002f-414e-b674-d37519246087"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Requirements("You aren't wielding Blackaxe and you are its true owner.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("457a70a3-3e08-4a2c-8e4f-79f41c2c0994"), Traits.Instances.Conjuration.ID);
                                traits.Add(Guid.Parse("afbd89c1-286e-4adb-9519-dac66b9888d6"), Traits.Instances.Teleportation.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("6d6abc79-0bd0-466e-822c-c09e21f6383a"), "Blackaxe appears in your hands, teleporting instantly from its prior location.");
                            });
                    })
                    .Add(Guid.Parse("b300bad6-b1b0-4f67-a343-197d13322b4c"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per minute.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("6543adfc-61a8-46b8-9a7a-127ec13ffbb6"), Traits.Instances.Death.ID);
                                traits.Add(Guid.Parse("062a7d01-1374-4e85-9b05-864eacb78829"), Traits.Instances.Healing.ID);
                                traits.Add(Guid.Parse("85f4ab8b-613f-45e2-8023-fb97d4ebd553"), Traits.Instances.Necromancy.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("a8c1aaf6-409c-4b31-b1d5-dec133ee04cc"), "Make a Strike against a living tree with Blackaxe. If it hits, the tree withers to ash and you heal 250 Hit Points and gain the benefit of restoration (6th) and restore senses.");
                            });
                    })
                    .Build()
            };
        }
        
        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("cb86b725-686d-4181-8fd9-52e54dc614bf"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("363012de-fe1f-4c9b-ade6-6ad732d97b63"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("531d8559-72ec-4b9b-b698-785feb346806"), Traits.Instances.Cursed.ID);
            builder.Add(Guid.Parse("6d2b5b81-ab12-4d98-ba51-b0a386d33006"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("6897c5f8-c83e-4617-879a-74cb4d78b15a"), Traits.Instances.Primal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96be0c17-2b16-4a03-95ea-638593688ac2"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 313
            };
        }
    }
}
