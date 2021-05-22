using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Light : Template
    {
        public static readonly Guid ID = Guid.Parse("87a6b8cf-e243-435c-a31e-ba70f8d73c70");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Light",
                Level = 1,
                Range = "Touch.",
                Duration = "Until the next time you make your daily preparations.",
                Targets = "1 object of 1 Bulk or less, either unattended or possessed by you or a willing ally.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c62508b2-21cf-4c6e-ab23-14d66976d6ca"), Type = TextBlockType.Text, Text = "The object glows, casting bright light in a 20-foot radius (and dim light for the next 20 feet) like a torch. If you cast this spell again on a second object, the light spell on the first object ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9fbaeecf-c152-42d7-8368-784ce9dbcbd1"), 
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0b011356-b33f-4625-a8ba-0005b262f4c6"), Type = TextBlockType.Text, Text = "The object sheds bright light in a 60-foot radius (and dim light for the next 60 feet)." }
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Light.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("731e9547-5a63-40c8-927e-7f5c2d1adb47"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 348
            };
        }
    }
}
