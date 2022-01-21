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
    public class HuntersDawn : Template
    {
        public static readonly Guid ID = Guid.Parse("728c2f98-495a-4972-ba56-b1fd29aaa89a");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Hunter's Dawn",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e1268c35-692c-4e4a-a0f9-4e320cf35a0a"), "Hunter's Dawn is a +3 greater striking speed ghost touch club. However, the notched head of the weapon marks it as an atlatl, an ancient tool used for throwing darts and javelins. You can use Hunter's Dawn with a mundane dart or javelin like you would use a bow with an arrow; when you do so, the range of the dart or javelin is doubled, and the dart or javelin uses Hunter's Dawn to determine its attack modifier and damage dice.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {            
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("f78b0e6d-66a4-40a4-927c-b66bb6d0d3a3"),
                Name = "Hunter's Dawn",
                Destruction = "Hunter's Dawn can be destroyed only by placing it on the funeral pyre of a dead god.",
                Hands = 1,
                Level = 23,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.OneBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f842c9b5-61fd-49ea-a297-34d2be6bdd4e"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                           .Kind("Interact")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("84aa85e7-7894-47e2-abb4-87cc6d5428c5"), "You swing Hunter's Dawn and launch a magically conjured javelin at a target within 60 feet, making a ranged Strike. The javelin has the statistics of a javelin but gains the magical properties of Hunter's Dawn and disappears immediately after hitting or missing its target. On a successful hit, you deal damage (3d6 piercing, due to the atlatl's greater striking rune, plus your Strength modifier); in addition, a gazelle leaps from the hit target to one or more targets within 20 feet of the first, dealing 2d6 piercing damage plus your Strength modifier. The number of additional targets hit in this way is equal to the number of actions you spend to activate this ability (one additional target if you used one action, two additional targets for two actions, and so forth).");
                           });
                    })
                    .Add(Guid.Parse("1ce275a4-86a3-4311-adea-8dcba6483cdf"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                           .Frequency("")
                           .Requirements("")
                           .Trigger("You hit a creature with a ranged Strike with Hunter's Dawn.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("4419d9dc-5953-4ee7-b3e2-6a78ce314541"), "The target is marked. Once per day, you can cast a 5th-level locate spell on the marked target, regardless of its distance from you or your ability to cast spells. This effect persists until it is dispelled (counterspell DC 46), the creature dies, or a new target is marked.");
                           });
                    })
                    .Add(Guid.Parse("45feabb5-9f12-4eee-b741-ba29f7c4f5db"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                           .Kind("Interact")
                           .Frequency("Three times per day.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("d9edfb63-4891-4602-afb8-818420c88948"), "You shave a curl of wood from Hunter's Dawn and create a roaring fire within 15 feet. You can choose one of the following shapes for the fire to take: a 10-foot square, a 20-foot line, or a 15-foot cone. Each creature in the affected squares take 6d6 fire damage (DC 46 basic Reflex save).");
                           });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a99cac5a-5e1e-4fd6-9704-f89dd503932c"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("4325e4b6-9e4a-47c1-9414-bd8fd849398a"), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse("56ab49ff-d5fa-4694-804d-40a01dfcdb70"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("b7efa2db-e3e2-45cd-b2be-d0ac0f4e06cf"), Traits.Instances.Enchantment.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69440514-0e84-4a41-b016-2765787fb16f"),
                SourceId = Sources.Instances.Pathfinder156.ID,
                Page = 67
            };
        }
    }
}
