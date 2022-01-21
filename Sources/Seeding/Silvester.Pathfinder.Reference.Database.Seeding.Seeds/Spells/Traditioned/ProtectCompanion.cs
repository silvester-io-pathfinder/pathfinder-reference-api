using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ProtectCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("07655448-b12a-4a37-8f39-5dd90515da57");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Protect Companion",
                Level = 1,
                Range = "30 feet.",
                Duration = "Until the start of your next turn.",
                Targets = "Your eidolon, or a creature with the minion trait under your control.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84a632f9-0b45-44e2-bffa-c823e1133d55"), Type = TextBlockType.Text, Text = "You extend your aura, as a magical shield that protects your eidolon or minion. The target gains a +1 circumstance bonus to AC until the start of your next turn. You gain the following reaction; after using the reaction, the spell ends and you can�t cast protect companion again for 10 minutes." };
        }

        protected override IEnumerable<InlineAction> GetInlineActions()
        {
            yield return new InlineAction
            {
                Id = Guid.Parse("35fb0751-eb26-4e6b-b05d-1a60daa6c207"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Life Block",
                Trigger = "The spell's target would take damage.",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("f93560ec-bc83-4969-90d1-62058dd26c5f"), Type = TextBlockType.Text, Text = "Reduce the triggering damage by 10, but you lose 5 Hit Points. Even if this reduces the damage to 0, the target still takes any effects that would come with the damage, such as the poison on a viper�s fangs Strike." }
                }
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("69d8d893-47b7-4e5b-99ed-b04a0e2fc804"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("3ff40ea9-2c90-4388-a677-b043acce6abe"), Type = TextBlockType.Text, Text = "The reaction reduces the damage by another 10, and you lose 5 more Hit Points. If you want to lose fewer Hit Points, you can choose to lower the damage reduction and HP lost to what any lower-level version of the spell could do without lowering the spell�s actual level." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1c034550-6598-4395-9fce-b5f6e4ef143a"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e114850-dc39-41be-9057-8dc3016ab964"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 123
            };
        }
    }
}
