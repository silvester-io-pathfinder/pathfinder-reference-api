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
    public class SparklingTarge : Template
    {
        public static readonly Guid ID = Guid.Parse("d72b6daf-bf55-4a02-afcc-5e5675c451c2");
        
        protected override HybridStudy GetHybridStudy()
        {
            return new HybridStudy
            {
                Id = ID, 
                Name = "Sparkling Targe",
                ConfluxSpellId = Spells.Instances.ShieldingStrike.ID,
                SeventhSpellId = Spells.Instances.ResistEnergy.ID,
                EleventhSpellId = Spells.Instances.WardingAggression.ID,
                ThirteenthSpellId = Spells.Instances.Stoneskin.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9d9354c1-6061-4d34-8bc9-756fd27332f5"), Type = TextBlockType.Text, Text = "You've studied the applications of magic, training yourself to perform not just offensive maneuvers but defensive tactics as well. When magic flows through you, your shield can block impossible things, even a dragon's breath or a magic missile." };
            yield return new TextBlock { Id = Guid.Parse("d59766ee-76ec-4b1c-ad70-4017dda313b3"), Type = TextBlockType.Text, Text = "You gain the Shield Block general feat." };
            yield return new TextBlock { Id = Guid.Parse("7099c907-f07a-4de1-9b28-ebbf4c862b4a"), Type = TextBlockType.Text, Text = "When you're in Arcane Cascade stance with your shield raised, your circumstance bonus to AC from your shield also applies to your saves against spells and other magical effects. In addition, damage you take as a result of a spell or magical effect while you're in Arcane Cascade can trigger your Shield Block reaction, even if the damage isn't physical. When blocking damage in this way, increase your shield's Hardness by an amount equal to the extra damage from Arcane Cascade (typically 1, but 2 if you have weapon specialization, or 3 if you have greater weapon specialization). These benefits apply whether you're using an actual shield, the shield spell, or something else that works like a shield (such as a raised tome if you have the Raise a Tome feat)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Add the conflux spell.
            builder.GainSpecificSpell(Guid.Parse("7f1c809b-ac4d-4e7d-a12a-4f9b9ee46bdc"), Spells.Instances.ShieldingStrike.ID);

            //Add studious spell slots from level 7 up to and excluding to 11.
            builder.GainSpecificSpellSlot(Guid.Parse("87dd9d25-d8c6-4cd9-aa20-a010fd7dad62"), amount: 2, spellSlotLevel: 2, isSpendingPreventable: true)
               .AddPrerequisites(Guid.Parse("8ec116dc-2bfb-4961-9043-869020b68a74"), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse("dffa7c67-4117-4956-94c2-733a8c29dc0b"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                   prerequisites.HaveSpecificLevel(Guid.Parse("a23f87ee-42b9-4204-b6ad-f2c95b302b58"), Comparator.LessThan, requiredLevel: 11);
               });

            //Add studious spell slots from level 11 up to and excluding to 13.
            builder.GainSpecificSpellSlot(Guid.Parse("0939e558-9463-4085-b742-d2ba0d952c8d"), amount: 2, spellSlotLevel: 3, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("ec916baa-44fc-452a-8c57-a1fdec573a55"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("c6f56d41-b0e0-44d6-bad3-ca8f5a0f3832"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                    prerequisites.HaveSpecificLevel(Guid.Parse("a9f8ddbf-86f7-4161-b62d-17f37494c29d"), Comparator.LessThan, requiredLevel: 13);
                });

            //Add studious spell slots from level 13 and beyond.
            builder.GainSpecificSpellSlot(Guid.Parse("811d8b74-7a3a-4fe9-9b6a-2e1dbf08f43c"), amount: 2, spellSlotLevel: 4, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("c3f4e042-352f-43bb-8e96-b5524a22a0b6"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("42d76e75-a7e7-4398-be7e-f5154d800d6e"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            builder.AddAnd(Guid.Parse("8baf2a96-8198-4e78-8488-edc6f0048d72"), and =>
            {
                and.AddPrerequisites(Guid.Parse("2ff58d0c-0ca0-4c99-86c5-d60eb5726f30"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("4c5151f9-0d84-4aed-8696-6cbf3b6c093e"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                });
                and.GainSpecificSpell(Guid.Parse("007f6a1b-b60a-467b-b893-6d8c6719ec60"), Spells.Instances.SpiderClimb.ID);
                and.GainSpecificSpell(Guid.Parse("9182a228-6370-4416-b9a3-5a5782c0e53c"), Spells.Instances.TrueStrike.ID);
                and.GainSpecificSpell(Guid.Parse("2179a1be-efe7-425a-aafe-6d42f79fb41f"), Spells.Instances.WaterBreathing.ID);
                and.GainSpecificSpell(Guid.Parse("5fa88320-db51-408f-ac37-bcd02ba46c12"), Spells.Instances.ResistEnergy.ID);
            });
          
            builder
              .GainSpecificSpell(Guid.Parse("6b69e681-01d5-4305-85c0-2d270fb248a2"), Spells.Instances.WardingAggression.ID)
              .AddPrerequisites(Guid.Parse("ef3f6a2a-29e6-487a-a95c-a175e4963508"), prerequisites =>
              {
                  prerequisites.HaveSpecificLevel(Guid.Parse("14c034dd-ba24-490c-a313-a75a08b17d13"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
              });

            builder
                .GainSpecificSpell(Guid.Parse("faf09bd7-0aa9-4b10-8ca7-4ecbe447e665"), Spells.Instances.Stoneskin.ID)
                .AddPrerequisites(Guid.Parse("e82bd91f-4039-4fec-ad73-43eba544b14f"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("4f11c97c-c683-4b1c-92de-e064f5cd00c8"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            //TODO: Add the Arcane Cascade modification effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f08a139f-8c93-49cc-8450-fe5848b2aa8f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 39
            };
        }
    }
}
