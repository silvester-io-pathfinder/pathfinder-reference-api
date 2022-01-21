using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Artifacts.Instances
{
    public class AxeOfTheDwarvenLords : Template
    {
        public static readonly Guid ID = Guid.Parse("698dcef9-9c91-435c-9fc1-e81f0ec05113");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Axe of the Dwarven Lords",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("55417e8b-1778-45e6-957b-3a06e43c8b3c"), "");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("3e1e0e55-5e6e-4fd0-bcaa-7a3498a66739"),
                Name = "Axe of the Dwarven Lords",
                Hands = 2,
                Destruction = "If an orc beheads a dwarven king with the Axe of the Dwarven Lords, the axe rusts away to nothing.",
                Level = 26,
                BulkId = Bulks.Instances.ThreeBulk.ID,
                RarityId = Rarities.Instances.Unique.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("740c73e9-7624-4402-89be-75b7f1b0c358"), "The blade of this +4 major striking keen returning speed dwarven waraxe is carved with an intricate design depicting countless generations of great dwarven warriors and leaders. The axe has the thrown 30 feet weapon trait, in addition to the normal weapon traits for a dwarven waraxe. Strikes with the axe deal an additional 1d6 damage to orcs. While the axe is in your possession, you gain a +4 item bonus when Crafting armor, jewelry, metalworking, stonemasonry, snares, traps, and weapons. If you are a dwarf, you gain greater darkvision while holding the axe. If you are not a dwarf, you are stupefied 4 while holding the axe, and if you are an orc, you are also drained 4 and enfeebled 4 while holding it.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("21e49cbb-ab50-4035-a15e-fde6a0832c4a"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision, Interact")
                            .Frequency("Once per week.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("0820e64c-31ca-4c14-b80b-99724bf66342"), "The axe casts a 10th-level summon elemental spell to conjure an elite elemental avalanche. The spell is automatically sustained, requiring no action on your part but still allowing you to command the elemental on each of your turns. You can Dismiss the Spell.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6cc249e6-fc21-411c-9111-2e5625011773"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("ba622176-6275-4a58-86f3-51858659ddb6"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("4fe8e7b2-0a8b-44dc-98d9-092ab3bbfd35"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("ce55fe6d-f029-4210-a4e0-b3bc93cdcf45"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("a4649377-61c3-48a7-98b4-c7afc9ce9a8b"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5e7030d-d535-463a-a69b-7e2e7fd31e0c"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 106
            };
        }
    }
}
