using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ChillingDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("fc8ec088-6c8d-4d90-9293-9fc0720a3855");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Chilling Darkness",
                Level = 3,
                Range = "120 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2fa66aff-6516-439b-821c-a0e5aa52c2f5"), Type = Utilities.Text.TextBlockType.Text, Text = "You shoot an utterly cold ray of darkness tinged with unholy energy. Make a ranged spell attack against the target. You deal 5d6 cold damage, plus 5d6 evil damage if the target is a celestial." };
            yield return new TextBlock { Id = Guid.Parse("1ae42c07-60c6-4292-a8b6-b06568f97f97"), Type = Utilities.Text.TextBlockType.Text, Text = "If the ray passes through an area of magical light or targets a creature affected by magical light, chilling darkness attempts to counteract the light. If you need to determine whether the ray passes through an area of light, draw a line between yourself and the spell's target." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c067daf9-15b6-4f2a-9bac-303584f7f85d"),
                CriticalSuccess = "The target takes double damage.",
                Success = "The target takes full damage."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("4e928728-b53f-43e2-acbe-7b93732500e9"),
                Level = "+1", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("85866a6b-4934-4b35-b98e-0f99876fe455"), Type = Utilities.Text.TextBlockType.Text, Text = "The cold damage increases by 2d6, and the evil damage against celestials increases by 2d6." }
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
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("af891c90-4389-4f68-84ed-e9be15235a8b"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("9f29ff81-8765-4da4-b451-1b48a89992cf"), Traits.Instances.Cold.ID);
            builder.Add(Guid.Parse("aedaea55-6cef-4fe4-a30c-8db6a41412e1"), Traits.Instances.Darkness.ID);
            builder.Add(Guid.Parse("584ff373-e605-4b9f-a0c6-0dcc9827f058"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("630ae601-10b9-411d-bf75-ace7e3bef66a"), Traits.Instances.Evil.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5a52e1d-927e-415e-baef-9856fd9a19f8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 322
            };
        }
    }
}
