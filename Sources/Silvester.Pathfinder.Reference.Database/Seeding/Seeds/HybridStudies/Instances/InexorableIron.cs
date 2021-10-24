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
    public class InexorableIron : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override HybridStudy GetHybridStudy()
        {
            return new HybridStudy
            {
                Id = ID, 
                Name = "Inexorable Iron",
                ConfluxSpellId = Spells.Instances.ThunderousStrike.ID,
                SeventhSpellId = Spells.Instances.Enlarge.ID,
                EleventhSpellId = Spells.Instances.Earthbind.ID,
                ThirteenthSpellId = Spells.Instances.DimensionalAnchor.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Once you begin along a path, nothing can stop you from reaching its end. You transform the mass of a greataxe, greatsword, or polearm into an unstoppable force to augment your own striking power or keep you standing on the battlefield." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you enter Arcane Cascade stance and at the start of each of your turns while you're in that stance, if you're wielding a melee weapon in two hands, you gain temporary Hit Points equal to half your level (minimum 1 temporary HP)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Add the conflux spell.
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ThunderousStrike.ID);

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
                and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enlarge.ID);
            });

            builder
                .GainSpecificSpell(Guid.Parse(""), Spells.Instances.Earthbind.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                });

            builder
               .GainSpecificSpell(Guid.Parse(""), Spells.Instances.DimensionalAnchor.ID)
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
