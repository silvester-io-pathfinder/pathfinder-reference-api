using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Duskwalker : Template
    {
        public static readonly Guid ID = Guid.Parse("d40a90eb-140a-43b1-94f5-fb034f62d977");

        protected override Heritage GetHeritage()
        {
           return new Heritage 
           {
               Id = ID, 
               RarityId = Rarities.Instances.Uncommon.ID, 
               Name = "Duskwalker"
           };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e0dba5be-43d5-4cd4-acbb-3f902b0d809a"), Type = TextBlockType.Text, Text = "Thanks to an ancient bargain, your soul has been reborn as a duskwalker, a planar scion with a connection to psychopomps and the Boneyard. You gain the duskwalker trait in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. Neither your body nor your spirit can ever become undead. You can choose from duskwalker feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("a3329d1d-de72-490b-9a7e-33ac74e2a67c"), Traits.Instances.Duskwalker.ID);
            builder.AddOr(Guid.Parse("4483b67c-b7a3-4c3d-ab0f-2285fa5548a1"), or =>
            {
                builder.GainSpecificSense(Guid.Parse("bb021a62-5d60-45fc-81b4-d6beff6279bc"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                builder.GainSpecificSense(Guid.Parse("7e9f6f1e-7d08-45b3-80b1-1b4a654305eb"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse("4a0be089-0124-4cf6-abbd-ce113622b6ef"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse("46f6d8ff-89e7-4477-af9e-f834ec22bf75"), Senses.Instances.LowLightVision.ID);
                    });
            });
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("a279987b-3db4-47f0-b9f3-3775063a4730"), Traits.Instances.Duskwalker.ID);
            builder.Manual(Guid.Parse("d597f40a-c193-4588-9109-a59fb87d2787"), "Neither your body nor your spirit can ever become undead.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea43f94f-1a13-47ae-82ba-8f3aeae451cc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 38
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
            yield return Gnome.ID;
            yield return Goblin.ID;
            yield return Human.ID;
            yield return Tengu.ID;
            yield return Orc.ID;
            yield return Dwarf.ID;
            yield return Kobold.ID;
            yield return Ratfolk.ID;
            yield return Elf.ID;
            yield return Halfling.ID;
        }
    }
}
