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
        public static readonly Guid ID = Guid.Parse("406ff95d-460c-4b7e-9865-0898ac22192f");
        
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
            yield return new TextBlock { Id = Guid.Parse("64a5625a-579d-4348-a88b-c610cdbebcf7"), Type = TextBlockType.Text, Text = "Magic is freeing, a means to your ends, and you can use it to go where you want, do as you please, and avoid the consequences. You are a laughing shadow of spell and blade, always one step ahead of your foes, always with a trick up your sleeve." };
            yield return new TextBlock { Id = Guid.Parse("18140af6-73db-41bc-9f2e-8fa756f74471"), Type = TextBlockType.Text, Text = "While in Arcane Cascade stance, you gain a +5-foot status bonus to your Speeds, or a +10-foot bonus if you're unarmored. If you have a free hand while in the stance and are attacking a flat-footed creature, you increase the extra damage to 3, to 5 if you have weapon specialization, or to 7 if you have greater weapon specialization. You must have your other hand completely free; the extra damage doesn't apply if you have a free-hand weapon or other item in that hand, even if you would normally be able to use the hand for other things." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Add the conflux spell.
            builder.GainSpecificSpell(Guid.Parse("28a7c77c-68a0-4f00-96f4-2f9b11b29321"), Spells.Instances.DimensionalAssault.ID);

            //Add studious spell slots from level 7 up to and excluding to 11.
            builder.GainSpecificSpellSlot(Guid.Parse("7d75dcc5-9cd4-465e-9811-aa57590e4a10"), amount: 2, spellSlotLevel: 2, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("a039aa05-5ec9-404a-8adc-0a2125c2f47b"), prerequisites =>
                 {
                     prerequisites.HaveSpecificLevel(Guid.Parse("d83a20a0-3bde-4af8-a9ba-fae409aa07a8"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                     prerequisites.HaveSpecificLevel(Guid.Parse("0b34d663-39a8-4bc9-9013-dbb32184179d"), Comparator.LessThan, requiredLevel: 11);
                 });

            //Add studious spell slots from level 11 up to and excluding to 13.
            builder.GainSpecificSpellSlot(Guid.Parse("081efba8-c929-4dc1-b0b7-4b6af8253bc5"), amount: 2, spellSlotLevel: 3, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("1737ff37-25f4-4616-ad72-1d7d5d709d9f"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("474a4c60-0797-4f36-b0e4-1ff01b06532c"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                    prerequisites.HaveSpecificLevel(Guid.Parse("ee43aa4e-48b5-4957-a65a-e0f2d71a8b4c"), Comparator.LessThan, requiredLevel: 13);
                });

            //Add studious spell slots from level 13 and beyond.
            builder.GainSpecificSpellSlot(Guid.Parse("6bc1e0b8-bfb7-4ad5-911b-5efabc7b42f0"), amount: 2, spellSlotLevel: 4, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("a206eded-d1ee-4429-a047-74ee1b0feb1e"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("c485af5a-315a-4661-95fc-bde86f4a1cdd"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            builder.AddAnd(Guid.Parse("3b711b57-547b-4a59-b642-b471cc8d9642"), and =>
            {
                and.AddPrerequisites(Guid.Parse("e3d36bbf-492d-4896-90ae-9c27a66eab8c"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("154884d3-4939-45bf-b122-0d33f99baaaa"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                });
                and.GainSpecificSpell(Guid.Parse("ed11fb5d-fe13-462a-8a7e-0af4f3e5afa2"), Spells.Instances.SpiderClimb.ID);
                and.GainSpecificSpell(Guid.Parse("529b5b6b-055d-4ec6-b33c-b242414cae25"), Spells.Instances.TrueStrike.ID);
                and.GainSpecificSpell(Guid.Parse("f8fd55c1-940d-412b-83fb-37debe49b1aa"), Spells.Instances.WaterBreathing.ID);
                and.GainSpecificSpell(Guid.Parse("3486d588-5c6e-4459-bce8-c908d3bcfd14"), Spells.Instances.MirrorImage.ID);
            });

            builder
              .GainSpecificSpell(Guid.Parse("7f47d8cb-5a85-4a5e-95ba-bf94c4ca4098"), Spells.Instances.ShiftBlame.ID)
              .AddPrerequisites(Guid.Parse("e54cb169-7c9c-4128-afac-724cf29228a3"), prerequisites =>
              {
                  prerequisites.HaveSpecificLevel(Guid.Parse("ec3ca17d-d3b9-451d-91ce-f145df8cbe79"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
              });

            builder
                .GainSpecificSpell(Guid.Parse("5e44ada2-3574-485e-bf14-d9d59aedcbf4"), Spells.Instances.DimensionDoor.ID)
                .AddPrerequisites(Guid.Parse("68be5ce7-544b-41b2-801a-8714da1bb6f1"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("3ec259fe-9019-4b37-ab9c-92f3e8cfa039"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
                });

            //TODO: Add the Arcane Cascade modification effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fc795bf-ddf2-46d4-a2ee-28e97121de31"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 39
            };
        }
    }
}
