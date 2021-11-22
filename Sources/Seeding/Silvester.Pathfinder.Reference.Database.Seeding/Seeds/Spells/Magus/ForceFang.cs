using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ForceFang : Template
    {
        public static readonly Guid ID = Guid.Parse("2915d5cc-f85c-4393-9a7a-9c5e9fec96ea");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Force Fang",
                Level = 1,
                Range = "Varies.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
                ClassId = Classes.Instances.Magus.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00326119-316c-48a8-b0bd-16974a436990"), Type = TextBlockType.Text, Text = "You briefly turn your attack into pure force to bypass your opponent�s defenses. Choose a target within your reach, or within the reach of a melee weapon you�re wielding. If you can use Spellstrike with a ranged weapon (with the starlit span hybrid study, for example), you can target a creature in the first range increment of your ranged weapon. For an instant, you transform your weapon or unarmed attack into a spike of pure force, replacing all its normal statistics and abilities. The force fang automatically deals 1d4+1 force damage to the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fb0ac348-7de2-4524-a5c7-627db4be704e"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("abbedec0-e5c0-4dfb-90bf-660723ab05e5"), Type = TextBlockType.Text, Text = "The damage increases by 1d4+1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Force.ID;
            yield return Traits.Instances.Magus.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba6d1c0a-2798-46f0-91d0-5104a733308a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 143
            };
        }
    }
}
