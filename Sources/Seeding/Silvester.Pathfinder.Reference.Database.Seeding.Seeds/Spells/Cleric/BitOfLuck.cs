using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BitOfLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("3364c015-16b1-425d-986c-e93f5974a25e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Bit of Luck",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 willing creature.",
                DomainId = Domains.Instances.Luck.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b962b42-8441-47b4-b19d-7b5319df1f81"), Type = TextBlockType.Text, Text = "You tilt the scales of luck slightly to protect a creature from disaster. When the target would attempt a saving throw, it can roll twice and use the better result. Once it does this, the spell ends." };
            yield return new TextBlock { Id = Guid.Parse("2ace6c08-8e19-4ba3-8183-79aed4016fb8"), Type = TextBlockType.Text, Text = "If you cast bit of luck again, any previous bit of luck you cast that's still in effect ends. After a creature has been targeted with bit of luck, it becomes temporarily immune for 24 hours." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("6cc1c0ac-f086-4b77-a422-d2a5c48d72fd"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("5d06f1c4-bcc8-4ab3-9add-5103e75bb27a"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("8ac0f6d2-d896-411b-af67-d229697e2b1f"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("4d6dfe2a-7f48-4088-b264-0ee5ef83847e"), Traits.Instances.Fortune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0014e14-6839-4e61-8ccf-af5289c8530b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 389
            };
        }
    }
}
