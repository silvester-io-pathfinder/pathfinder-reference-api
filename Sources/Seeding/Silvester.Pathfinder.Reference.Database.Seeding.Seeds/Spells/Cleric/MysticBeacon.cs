using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MysticBeacon : Template
    {
        public static readonly Guid ID = Guid.Parse("60c7b403-9464-4305-921f-0fd8445f1fe0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mystic Beacon",
                Level = 4,
                Range = "30 feet.",
                Duration = "Until the start of your next turn.",
                Targets = "1 willing creature.",
                DomainId = Domains.Instances.Magic.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8dbc8a0b-889d-45cc-9166-8160d5b4fa89"), Type = TextBlockType.Text, Text = "The next damaging or healing spell the target casts before the start of your next turn deals damage or restores Hit Points as if the spell were heightened 1 level higher than its actual level. The spell otherwise functions at its actual level. Once the target casts the spell, mystic beacon ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ec4414a8-833e-4026-a9bf-0adc7d4596b2"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("598d1479-a720-4bbd-af06-204dd4141e7d"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("84b606e1-517c-4465-b2c2-190fc3ac4770"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("944c1de6-ac9a-4ea3-bf19-6cbcca05627d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 394
            };
        }
    }
}
