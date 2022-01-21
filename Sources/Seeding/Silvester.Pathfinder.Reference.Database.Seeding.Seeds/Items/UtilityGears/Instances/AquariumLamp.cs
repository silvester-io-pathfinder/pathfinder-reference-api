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
    public class AquariumLamp : Template
    {
        public static readonly Guid ID = Guid.Parse("99f2b76e-f4a9-476b-a1af-0caaa9921539");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Aquarium Lamp",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("abf75140-9494-4c66-bc17-1434faba1402"), "The aquarium lamp is a combination light source and exotic animal aquarium, intended to provide rich nobles amusement and illumination. It takes the shape of a glass cube 50 feet wide and seven feet high filled with sea water, flanked by two much smaller water tanks. A sparse brass frame around the device keeps the tanks themselves from touching the ground and serves as a mounting point for a pair of electrical coils on the top, which are enclosed within separate glass tubes. Six electric eels swim within the central tank, while a number of animals belonging to species considered to be the eels� natural prey swim in the smaller feeding tanks. With the simple pull of a lever attached to either smaller tank, one of the prey animals is released into the eel tank. Within seconds, the eels converge on the hapless animal, using their electrical charges to stun their victims. When this happens, the salty seawater conducts the electrical energy into transfer coils hidden within the brass frame, which send the energy to the top-mounted electrical coils. The end result produces enough light to fully illuminate a room as though it were midday.");
            builder.Text(Guid.Parse("4611a522-ea2d-4455-9e26-8fb9a17e794c"), "This device is an expression of a recent trend among certain Avistani nobles to blend form and function in their manors� interior decorations. In such circles, ostentatious decorations that serve no functional purpose are derided as �tacky� and �unrefined.� If a noble in such company wishes not to be ridiculed, they must be sure that each decoration adds something to the room beyond the aesthetic. The aquarium lamp is the latest tool in this social arms race, and it�s already proven popular with its target market.");
            builder.Text(Guid.Parse("322381aa-f67d-4c55-a9be-617d80bb5dbd"), "When active, the aquarium lamp produces bright light in a 60-foot radius (and dim light for the next 60 feet). Each activation provides enough energy for 10 minutes of use, and the two feeding tanks combined carry enough prey animals for 50 activations before needing to be refilled, though electric eels usually need feeding only once per day, and won�t go after the prey if they�re all full. While electric eels are not aggressive to their aquarium keepers and will gradually learn to associate them with food, they can engage in violent social behavior, especially when they are young. This behavior leads to small fights involving tail slapping, biting, and discharged electricity, the last of which causes the lamp to illuminate without hitting the lever to release prey. The electric eels live around 15 years if kept well-fed.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("986e872b-549a-41e2-8479-200d35b65779"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("36361fc5-2a71-444f-872b-5b3550404ace"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("b97f774f-1fcf-4841-94ba-a386c43b5e91"), Traits.Instances.Light.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("961440ec-0acc-41db-a2ec-bee446375696"),
                Name = "Aquarium Lamp",
                Level = 8,
                Price = 150000,
                BulkId = Bulks.Instances.TwentyBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("69fd6f82-acdf-4a4e-8811-f586fdf704ee"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("a3efb4bc-16ea-4df8-896f-e42a6ddf7221"), "With the simple pull of a lever attached to either smaller tank, one of the prey animals is released into the eel tank. Within seconds, the eels converge on the hapless animal, using their electrical charges to stun their victims. When this happens, the salty seawater conducts the electrical energy into transfer coils hidden within the brass frame, which send the energy to the top-mounted electrical coils. The end result produces enough light to fully illuminate a room as though it were midday.");
                                effect.Text(Guid.Parse("9add32d5-48b6-4617-9ef4-138e4bf32427"), "When active, the aquarium lamp produces bright light in a 60-foot radius (and dim light for the next 60 feet). Each activation provides enough energy for 10 minutes of use, and the two feeding tanks combined carry enough prey animals for 50 activations before needing to be refilled, though electric eels usually need feeding only once per day, and won�t go after the prey if they�re all full.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6fb38d8-377e-47fd-8b67-6ae33c5c6f3e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 84
            };
        }
    }
}
