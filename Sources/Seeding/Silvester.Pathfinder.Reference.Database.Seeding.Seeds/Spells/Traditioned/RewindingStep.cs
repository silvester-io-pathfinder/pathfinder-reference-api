using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RewindingStep : Template
    {
        public static readonly Guid ID = Guid.Parse("6269c16e-a1c8-47b6-aa1e-de3994b36b0e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Rewinding Step",
                Level = 5,
                Duration = "10 minutes.",
                CastTime = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1408d047-670d-4db0-ae79-09f12f6b5b62"), Type = TextBlockType.Text, Text = "You anchor your location in time so that you can swiftly retrace your steps later with complex chronomancy. The space you're in when you cast the spell becomes your temporal anchor space. While you're within 500 feet of your temporal anchor space, you can spend a single action that has the concentrate trait to instantaneously return to that space (you don't need to have line of effect to the space). The spell then ends. You bring any items that are in your possession with you when you take the action to return." };
            yield return new TextBlock { Id = Guid.Parse("ce30f2c2-c8c8-463e-9fe6-22cd66b89d04"), Type = TextBlockType.Text, Text = "If the anchor space is occupied when you attempt to return to it or if this spell would bring another creature with you, the spell fails to transport you, then ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("85094e37-6c2a-44b4-ad53-fcaabf1c0b5b"),
                Level = "7th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("9b13556f-9084-4a03-8072-1752481603e7"), Type = TextBlockType.Text, Text = "You can return if you're within 1,000 feet of your anchor space." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("6afbb130-ed06-4a6f-96c5-ceaa1d0132e4"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("ae169388-d00d-4a22-8a1c-7945cf59c862"), Type = TextBlockType.Text, Text = "You can return if you're within 1 mile of your anchor space." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            builder.Add(Guid.Parse("bbd7e642-8db2-4568-80ba-9ad0a3dc10cb"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7e0c165-d0f0-4b2d-bdb4-7ba450bf4c49"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 126
            };
        }
    }
}
