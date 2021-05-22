using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class UnfathomableSong : Template
    {
        public static readonly Guid ID = Guid.Parse("31a373a3-8dfb-4e2b-8678-9570a5513574");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unfathomable Song",
                Level = 9,
                Range = "120 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                Targets = "Up to 5 creatures.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82bb24ed-5b4c-4b1e-9d24-31ec4328e741"), Type = TextBlockType.Text, Text = "Fleeting notes of a strange and unnatural song fill the air, overtaking the mind. Each target must attempt a Will save when you cast the spell, and again the first time you Sustain the Spell each round. A creature needs to attempt only one save against the song each round, and you have to keep the same targets when you Sustain the Spell." };
            yield return new TextBlock { Id = Guid.Parse("b0a44d32-d5fb-4e2e-b3db-50e4d3adc05d"), Type = TextBlockType.Text, Text = "If a target creature fails or critically fails their saving throw, the table below can be referenced for the result of the 1d4 roll." };
        }

        protected override Table? GetTable(TableBuilder builder)
        {
            builder
                .AddColumn("2792cdda-3eb4-4bd3-b9d6-d81ea492587d", "Result")
                .AddColumn("3d4b05ba-6fa1-425e-8a32-f72757cd9df7", "Effect")
                .AddRow("d21314e9-e1df-4368-81ff-81397f602489", row =>
                {
                    row.AddCell("8bc2c85f-a0e9-43ed-a684-441e4dabe1f1", "1");
                    row.AddCell("e0b13351-856c-4769-a24b-68aec7a802db", "The target is frightened 2.");
                })
                .AddRow("81324bdf-1fd9-4cd8-abf5-97ea41a80e81", row =>
                {
                    row.AddCell("ff6ec7bf-6641-4994-9244-b0d18f10008f", "2");
                    row.AddCell("1b7b0f66-5aef-4a03-b5ae-f908f6fe64a7", "The target is confused for 1 round.");
                })
                .AddRow("741c39a8-e338-4c7b-8f9d-4aca84862679", row =>
                {
                    row.AddCell("9011d053-b0f6-4183-a9ee-3668646bc7bb", "3"); 
                    row.AddCell("bad7459a-c2a6-48c1-b6d8-e776507d88c2", "The target is stupefied 4 for 1 round.");
                })
                .AddRow("1aa818a0-793e-41d3-9aba-86f5f93efa8c", row =>
                {
                    row.AddCell("549c84f9-a3f4-498f-a361-7d0d4f4d9000", "4"); 
                    row.AddCell("1dc82c7f-9268-414e-bcef-8d65547a5659", "The target is blinded for 1 round.");
                })
                .AddRow("07585243-10f2-4903-bac5-bf75e3482bb2", row =>
                {
                    row.AddCell("5b9d0d2e-8dc0-48c9-95e6-8fbbd0109a47", "5"); 
                    row.AddCell("b96d7dd3-615d-4b1b-ab03-dbce5c17da00", "The target is stunned for 1 round and stupefied 1 for an unlimited duration.");
                });

            return builder.Build("d432fce3-02e6-4b1a-a9da-0b6ccdd97301");
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d5c58535-aa40-4dca-a7d0-12328689842d"),
                CriticalSuccess = "The target is unaffected, can’t be affected on subsequent rounds, and is temporarily immune for 1 minute.",
                Success = "The target is unaffected this round, but it can be affected on subsequent rounds.",
                Failure = "Roll 1d4 on the table above.",
                CriticalFailure = "Roll 1d4+1 on the table above."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39e6195b-6cda-4ba4-828b-fdb79dcea1d3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
