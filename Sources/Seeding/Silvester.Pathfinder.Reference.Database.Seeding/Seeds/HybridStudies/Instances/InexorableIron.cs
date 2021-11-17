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
        public static readonly Guid ID = Guid.Parse("12e03378-2983-4faf-a14e-3f634df4acce");
        
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
            yield return new TextBlock { Id = Guid.Parse("68ad336e-8d34-422b-8dba-f9223794ebf9"), Type = TextBlockType.Text, Text = "Once you begin along a path, nothing can stop you from reaching its end. You transform the mass of a greataxe, greatsword, or polearm into an unstoppable force to augment your own striking power or keep you standing on the battlefield." };
            yield return new TextBlock { Id = Guid.Parse("fd6e3085-28d5-4784-b868-ab2fc83c0567"), Type = TextBlockType.Text, Text = "When you enter Arcane Cascade stance and at the start of each of your turns while you're in that stance, if you're wielding a melee weapon in two hands, you gain temporary Hit Points equal to half your level (minimum 1 temporary HP)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Add the conflux spell.
            builder.GainSpecificSpell(Guid.Parse("24d9419c-2ff9-4b29-8a50-928debd1c75d"), Spells.Instances.ThunderousStrike.ID);

            //Add studious spell slots from level 7 up to and excluding to 11.
            builder.GainSpecificSpellSlot(Guid.Parse("b9003059-9217-4cf1-a11e-7ec9d6affb9d"), amount: 2, spellSlotLevel: 2, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("d9478088-faa5-4df9-b4a4-8ae002a72283"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("c9c2de6b-c5db-4b49-874b-852967af8ce9"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                    prerequisites.HaveSpecificLevel(Guid.Parse("77246eae-7e74-4872-b1ef-d7f3f582ddb2"), Comparator.LessThan, requiredLevel: 11);
                });

            //Add studious spell slots from level 11 up to and excluding to 13.
            builder.GainSpecificSpellSlot(Guid.Parse("35ad1c2d-2405-465f-892a-6aec7b874c23"), amount: 2, spellSlotLevel: 3, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("6f2c340e-570e-4fb5-a63d-aa7ea9ec3398"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("61c53c46-326d-4a3e-bc0c-c4eaa253fdc4"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                    prerequisites.HaveSpecificLevel(Guid.Parse("42e9c2f5-f227-4b66-b377-622034af7e1c"), Comparator.LessThan, requiredLevel: 13);
                });

            //Add studious spell slots from level 13 and beyond.
            builder.GainSpecificSpellSlot(Guid.Parse("e0634560-7218-4b06-9c31-f6c772fe3cf9"), amount: 2, spellSlotLevel: 4, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("c35c074f-117c-4ced-9124-224445499f12"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("8e22bc7a-afaf-4118-9769-a150098ac02d"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            builder.AddAnd(Guid.Parse("baf46ae0-0629-4ffa-a72d-bf7522f42db1"), and => 
            {
                and.AddPrerequisites(Guid.Parse("658172bb-47c7-4f65-ac34-4e8e5274d431"), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("df9bd44e-33d5-4c06-9e50-e161036632b0"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                }); 
                and.GainSpecificSpell(Guid.Parse("f77dcdc7-f166-4c4d-9f3a-5050a4c961db"), Spells.Instances.SpiderClimb.ID);
                and.GainSpecificSpell(Guid.Parse("19b32faa-8e02-4c2c-9f25-6b9c2c255b34"), Spells.Instances.TrueStrike.ID);
                and.GainSpecificSpell(Guid.Parse("9629f2b8-d86e-4924-8a31-c694481710c7"), Spells.Instances.WaterBreathing.ID);
                and.GainSpecificSpell(Guid.Parse("a56fc568-131e-4caf-b6ac-61c386bb8b69"), Spells.Instances.Enlarge.ID);
            });

            builder
                .GainSpecificSpell(Guid.Parse("b078c713-8401-41b3-87bd-96e472620f5d"), Spells.Instances.Earthbind.ID)
                .AddPrerequisites(Guid.Parse("af4f85ab-7651-4ffe-855a-f3eaf4942b5f"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("6596b20d-afcc-483d-9be5-4df4b4c8a62a"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                });

            builder
               .GainSpecificSpell(Guid.Parse("c4e41d9a-c958-4436-83d3-6944fc95f03d"), Spells.Instances.DimensionalAnchor.ID)
               .AddPrerequisites(Guid.Parse("c30f8919-00ff-402a-b3e2-7c1b9f0d011e"), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse("075bdb46-4f9b-4dab-9c5c-5607afa61076"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
               });

            //TODO: Add the Arcane Cascade modification effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("616eb8b5-65fb-4445-a788-42f137242bfa"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 39
            };
        }
    }
}
