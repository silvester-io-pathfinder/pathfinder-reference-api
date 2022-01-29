using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Items;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class HolySteamBall : Template
    {
        public static readonly Guid ID = Guid.Parse("f23d5390-42e3-4d1f-b76c-c88f8fa107f6");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Holy Steam Ball",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3a95774a-c060-465d-8b0e-804260f1425f"), "The holy steam ball is an odd-looking device that's nevertheless effective at reinforcing its user's mind against fiendish control. It's a hollow black-rubber ball with small, flexible twin tubes sticking out from its center. Sealed within the rubber ball is vapor made from a mixture of evaporated holy water and a special type of incense smoke. The tube's twin prongs are placed into the user's nostrils, after which the user squeezes the rubber ball to activate the device, forcing the vapor into the user's body through their nose. The holy power contained within the vapor strengthens the user's will against creatures that are weak to holy water, making it tougher for malevolent creatures to subvert the user's mind.");
            builder.Text(Guid.Parse("a089067d-a6f9-4f33-8873-b237db1acd31"), "When the holy steam ball was first introduced in Mendev fifty years ago, few trusted it's efficacy. The nation had seen many charlatans peddle so-called 'anti-demon' products, and most thought this was no different. Only when soldiers of the Mendevian Crusades used the ball and personally testified to its effectiveness did suspicion gave way to enthusiastic use. Nobody remembers who first invented the holy steam ball; they're likely lost to history because most initially thought it was a scam. After receiving endorsement from the Mendevian Crusade, a team of alchemists and inventors were able to determine the vapor's exact composition and mass produce them. The holy steam ball's highly specialized purpose kept it from widespread use outside of the nations that once bordered the Worldwound. Yet with the return of the Whispering Tyrant in the past few years, the growing undead threat presents a new opportunity for more citizens to use holy steam balls for protection against the mind control powers of vampires and other undead.");
            builder.Text(Guid.Parse("1a3fecd2-3e4d-4bf5-b679-d2584aba69c5"), "After using a holy steam ball, you must refill it before the next use in a process that takes five minutes to complete.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2ca4fba5-778b-49ac-a438-487b3e30ae23"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("9365377a-2b0b-4c1e-830b-0abd89788ae5"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("c53c1aa1-a869-4c32-aa75-791dff7d9db1"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("97377036-24c3-4f27-834b-dfa6dbf03e9b"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("7d86d745-ce3b-484c-a0f9-70f5614dad62"), Traits.Instances.Good.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0c2f0014-634f-495a-af97-999d0528c109"),
                Name = "Holy Steam Ball",
                Usage = "Held in 1 hand.",
                Level = 2,
                Price = 3000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("57630c83-9bea-4d3f-9015-16d39a3b1670"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Requirements("The Holy Steam Ball is filled with evaporated Holy Wayer and incense smoke.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("526dade4-4e04-4a6a-bb32-33e49811bb5c"), "You release the stored steam and smoke to grant yourself its protections. Each use of the holy steam ball lasts for 1 hour and gives you a +2 item bonus to Will saving throws against possession effects from fiends and undead and effects from fiends and undead that cause the controlled condition.");
                            });
                    })
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("509dbb98-7e6a-4997-829b-608a78803106"),
                Name = "Holy Steam Ball (Refill)",
                Level = 2,
                Price = 200,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae11ca4b-c965-4ee7-81e2-7df141cf8c98"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 87
            };
        }
    }
}
