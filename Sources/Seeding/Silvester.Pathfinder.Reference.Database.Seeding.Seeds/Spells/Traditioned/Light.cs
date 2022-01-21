using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c1de119d-791c-4b38-91ab-ea5fafcd17b7"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("dd07e3e1-a5a5-47cb-a3c5-1a35a4f09308"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("c7e7a5c4-8ed7-445f-b5c6-0f4078461e8b"), Traits.Instances.Light.ID);
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
