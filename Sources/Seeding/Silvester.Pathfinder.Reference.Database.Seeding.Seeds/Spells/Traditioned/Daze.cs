using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Daze : Template
    {
        public static readonly Guid ID = Guid.Parse("2d8be059-3a79-4d4d-a7e8-31dee66680cc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Daze",
                Level = 1,
                Range = "60 feet.",
                Targets = "1 creature.",
                Duration = "1 round.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47e75e5c-6ee0-4c24-bb1e-b51bad67e26a"), Type = Utilities.Text.TextBlockType.Text, Text = "You cloud the target's mind and daze it with a mental jolt. The jolt deals mental damage equal to your spellcasting ability modifier; the target must attempt a basic Will save. If the target critically fails the save, it is also stunned 1." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("aa381ca0-7a43-4e1b-9d5d-2ad73be5255d"), 
                Level = "+2", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ef8617df-09c3-4aca-b07d-4e61bd26ed06"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0caeb6e4-e14b-4f3c-9ff3-594e7597149a"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("ea90979e-3884-47b0-9a5b-e380e4493d7d"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("9f910e76-5695-4722-b942-df1418c64c63"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("5a873c19-67ca-4a3e-946b-02c9c6caf198"), Traits.Instances.Nonlethal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a42e4ae9-dd85-4a7c-bb84-5812c9871ddb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 327
            };
        }
    }
}
