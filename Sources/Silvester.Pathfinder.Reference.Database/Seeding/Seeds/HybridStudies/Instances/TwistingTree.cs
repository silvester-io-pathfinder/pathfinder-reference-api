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
        public static readonly Guid ID = Guid.Parse("");
        
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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The staff is perhaps one of the simplest of weapons, but this simplicity belies its elegance and versatility. To you, a staff is casting implement and martial weapon alike—the foundation of a fighting style." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While you wield a staff in one hand, the staff adjusts in shape and weight, gaining the agile trait and increasing its damage die size to 1d6. While you wield a staff in both hands, it lengthens, twists, and reshapes, gaining the parry, reach, and trip traits. While you're in Arcane Cascade stance, you can Interact or Release to change your grip on the weapon as a free action when you Strike with your staff, including Strikes made in a Spellstrike. This happens before you roll your attack roll. You can also Interact to change your grip on the staff as a free action triggered at the end of your turn. " };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Add the conflux spell.
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SpinningStaff.ID);

            //Add studious spell slots from level 7 up to and excluding to 11.
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 2, spellSlotLevel: 2, isSpendingPreventable: true)
               .AddPrerequisites(Guid.Parse(""), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                   prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.LessThan, requiredLevel: 11);
               });

            //Add studious spell slots from level 11 up to and excluding to 13.
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 2, spellSlotLevel: 3, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.LessThan, requiredLevel: 13);
                });

            //Add studious spell slots from level 13 and beyond.
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 2, spellSlotLevel: 4, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                });
                and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SpiderClimb.ID);
                and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueStrike.ID);
                and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WaterBreathing.ID);
                and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MagicMouth.ID);
            });

            builder
                .GainSpecificSpell(Guid.Parse(""), Spells.Instances.Slow.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                });

            builder
                .GainSpecificSpell(Guid.Parse(""), Spells.Instances.Blink.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            //TODO: Add the Arcane Cascade modification effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
