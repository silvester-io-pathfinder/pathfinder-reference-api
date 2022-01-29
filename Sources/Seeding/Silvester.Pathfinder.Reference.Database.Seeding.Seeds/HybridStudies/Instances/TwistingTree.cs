using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HybridStudies.Instances
{
    public class TwistingTree : Template
    {
        public static readonly Guid ID = Guid.Parse("6f5457dc-b661-43e5-bc99-a2dc14c22598");
        
        protected override HybridStudy GetHybridStudy()
        {
            return new HybridStudy
            {
                Id = ID, 
                Name = "Twisting Tree",
                ConfluxSpellId = Spells.Instances.SpinningStaff.ID,
                SeventhSpellId = Spells.Instances.MagicMouth.ID,
                EleventhSpellId = Spells.Instances.Slow.ID,
                ThirteenthSpellId = Spells.Instances.Blink.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fbe8d5f6-b4dc-4401-a70a-d6e40e9ebbfb"), Type = TextBlockType.Text, Text = "The staff is perhaps one of the simplest of weapons, but this simplicity belies its elegance and versatility. To you, a staff is casting implement and martial weapon alike - the foundation of a fighting style." };
            yield return new TextBlock { Id = Guid.Parse("4f6f59f6-9202-4beb-8129-944c89d910b4"), Type = TextBlockType.Text, Text = "While you wield a staff in one hand, the staff adjusts in shape and weight, gaining the agile trait and increasing its damage die size to 1d6. While you wield a staff in both hands, it lengthens, twists, and reshapes, gaining the parry, reach, and trip traits. While you're in Arcane Cascade stance, you can Interact or Release to change your grip on the weapon as a free action when you Strike with your staff, including Strikes made in a Spellstrike. This happens before you roll your attack roll. You can also Interact to change your grip on the staff as a free action triggered at the end of your turn. " };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Add the conflux spell.
            builder.GainSpecificSpell(Guid.Parse("1020533d-031c-4eaf-9ae2-9cf366fb61cb"), Spells.Instances.SpinningStaff.ID);

            //Add studious spell slots from level 7 up to and excluding to 11.
            builder.GainSpecificSpellSlot(Guid.Parse("d4e257b0-2409-4352-9fe6-b2b38d282f0d"), amount: 2, spellSlotLevel: 2, isSpendingPreventable: true)
               .AddPrerequisites(Guid.Parse("ed24799b-9181-44a8-b586-f1935729ec26"), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse("12665c80-2438-4eee-9cc2-98f8699828d5"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                   prerequisites.HaveSpecificLevel(Guid.Parse("019c876d-af24-45e5-98e4-63aa0194c049"), Comparator.LessThan, requiredLevel: 11);
               });

            //Add studious spell slots from level 11 up to and excluding to 13.
            builder.GainSpecificSpellSlot(Guid.Parse("6e71f380-457b-4476-a5d3-fde323c561c9"), amount: 2, spellSlotLevel: 3, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("9dd51d17-453c-4358-84a0-0f971bb94b27"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("6dda208f-8d71-47c0-959e-a386da435012"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                    prerequisites.HaveSpecificLevel(Guid.Parse("b30e48a9-80ce-459c-9b86-38eb1f783fb4"), Comparator.LessThan, requiredLevel: 13);
                });

            //Add studious spell slots from level 13 and beyond.
            builder.GainSpecificSpellSlot(Guid.Parse("eeba8b40-7e6c-40bc-9e53-45e63368c251"), amount: 2, spellSlotLevel: 4, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("ea80589b-8eaf-4475-8871-ea9a89d5c3b4"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("a914456c-d137-44b9-b5a7-74fa178b6bbd"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            builder.AddAnd(Guid.Parse("889722a5-1c13-4ac1-8a6d-b7df7352cd82"), and =>
            {
                and.AddPrerequisites(Guid.Parse("9a08774b-06c9-49b5-8325-454e1793410c"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("794f2392-09db-4331-912c-0c3c58ab8c2e"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                });
                and.GainSpecificSpell(Guid.Parse("1a87330c-f512-44e0-aa8f-30abf4514dd4"), Spells.Instances.SpiderClimb.ID);
                and.GainSpecificSpell(Guid.Parse("43f8fa7d-fe23-4d45-a1ca-e26cf8c0c0c6"), Spells.Instances.TrueStrike.ID);
                and.GainSpecificSpell(Guid.Parse("f62d2ef8-5b43-495b-9b37-4d39515a76db"), Spells.Instances.WaterBreathing.ID);
                and.GainSpecificSpell(Guid.Parse("0a81a457-4dcb-4627-bf0f-17ed0ccb676d"), Spells.Instances.MagicMouth.ID);
            });

            builder
                .GainSpecificSpell(Guid.Parse("2361e276-7b1d-402d-bd26-653812ca2be3"), Spells.Instances.Slow.ID)
                .AddPrerequisites(Guid.Parse("55837350-bfe4-4ef2-90ed-df20d87b1e19"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("68a0bb24-cf6d-4e85-99ac-5796bb9f4035"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                });

            builder
                .GainSpecificSpell(Guid.Parse("35aef695-977f-495a-9c70-026730142506"), Spells.Instances.Blink.ID)
                .AddPrerequisites(Guid.Parse("36544c73-2393-4f45-bc47-ada045ccd0e5"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("1a75302e-a708-4386-acfc-05b7f59f301c"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            //TODO: Add the Arcane Cascade modification effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eedbf7a2-6e65-435c-a189-d3ba02eba32f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
