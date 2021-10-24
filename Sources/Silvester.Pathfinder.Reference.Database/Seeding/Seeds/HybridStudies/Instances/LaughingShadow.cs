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
    public class LaughingShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override HybridStudy GetHybridStudy()
        {
            return new HybridStudy
            {
                Id = ID, 
                Name = "Laughing Shadow",
                ConfluxSpellId = Spells.Instances.DimensionalAssault.ID,
                SeventhSpellId = Spells.Instances.MirrorImage.ID,
                EleventhSpellId = Spells.Instances.ShiftBlame.ID,
                ThirteenthSpellId = Spells.Instances.DimensionDoor.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Magic is freeing, a means to your ends, and you can use it to go where you want, do as you please, and avoid the consequences. You are a laughing shadow of spell and blade, always one step ahead of your foes, always with a trick up your sleeve." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While in Arcane Cascade stance, you gain a +5-foot status bonus to your Speeds, or a +10-foot bonus if you're unarmored. If you have a free hand while in the stance and are attacking a flat-footed creature, you increase the extra damage to 3, to 5 if you have weapon specialization, or to 7 if you have greater weapon specialization. You must have your other hand completely free; the extra damage doesn't apply if you have a free-hand weapon or other item in that hand, even if you would normally be able to use the hand for other things." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Add the conflux spell.
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DimensionalAssault.ID);

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
                and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MirrorImage.ID);
            });

            builder
              .GainSpecificSpell(Guid.Parse(""), Spells.Instances.ShiftBlame.ID)
              .AddPrerequisites(Guid.Parse(""), prerequisites =>
              {
                  prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
              });

            builder
                .GainSpecificSpell(Guid.Parse(""), Spells.Instances.DimensionDoor.ID)
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
                Page = 39
            };
        }
    }
}
