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
    public class Dhampir : Template
    {
        public static readonly Guid ID = Guid.Parse("36db9153-1a83-46b1-b303-47a5f4665704");

        protected override Heritage GetHeritage()
        {
           return new Heritage 
           {
               Id = ID, 
               RarityId = Rarities.Instances.Uncommon.ID, 
               Name = "Dhampir"
           };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8a5873a5-32fe-4e43-a845-2ea4d7b34a7e"), Type = TextBlockType.Text, Text = "You are the scion of a vampire, half living and half undead, gifted with uncanny charm and grace, a bloodless pallor, and elongated incisors. You gain the dhampir trait, in addition to the traits from your ancestry. You have the negative healing ability, which means you are harmed by positive damage and healed by negative effects as if you were undead. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from dhampir feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("3d61020c-ccf4-48f3-9c38-6b8c0a0d2cd6"), Traits.Instances.Dhampir.ID);
            builder.GainSpecificAbility(Guid.Parse("8f29f233-9714-4732-a611-e02232640f24"), Abilities.Instances.NegativeHealing.ID);
            builder.AddOr(Guid.Parse("82d1ea42-d823-44c6-be72-e5589404ea64"), or =>
            {
                builder.GainSpecificSense(Guid.Parse("7f6de448-0af1-47ad-bf2b-89e100ee8ae4"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                builder.GainSpecificSense(Guid.Parse("0267d21e-8e5b-4424-ba7d-bd534c626bb5"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse("74572d4d-1491-4d51-887d-a583fb371c0f"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse("1d1a95be-32e0-4260-afbb-b3049ccdc6a3"), Senses.Instances.LowLightVision.ID);
                    });
            });
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("629e68bf-d4a6-4ac3-a695-376eff1595f5"), Traits.Instances.Dhampir.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e42ca116-dd15-4f51-85ab-4922bdc8a31f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 32
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
