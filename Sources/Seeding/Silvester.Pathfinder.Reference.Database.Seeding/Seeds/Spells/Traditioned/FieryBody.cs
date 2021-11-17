using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FieryBody : Template
    {
        public static readonly Guid ID = Guid.Parse("625096f8-608a-4d87-9874-729312b0f9f4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "FieryBody",
                Level = 7,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d6460b5-2aad-452b-b9b5-3af92ec6e3c7"), Type = TextBlockType.Text, Text = "You become living flame, giving you fire immunity, resistance 10 to precision damage, and weakness 5 to cold and to water. Any creature that touches you or damages you with an unarmed attack or non-reach melee weapon takes 3d6 fire damage." };
            yield return new TextBlock { Id = Guid.Parse("7d57413c-6819-4db6-b579-84c09c41bcdc"), Type = TextBlockType.Text, Text = "Your unarmed attacks deal 1d4 additional fire damage, and your fire spells deal one additional die of fire damage (of the same damage die the spell uses). You can cast produce flame as an innate spell; the casting is reduced from 2 actions to 1." };
            yield return new TextBlock { Id = Guid.Parse("adefd748-7267-46aa-89dd-a206103d0f5c"), Type = TextBlockType.Text, Text = "In fire form, you have a fly Speed of 40 feet and don’t need to breathe." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("41fb5b31-9e4f-402d-a8fc-4e90b6e305bb"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d3e696fd-1f6a-44d0-8281-a7b57b0d0fe4"), Type = TextBlockType.Text, Text = "Creatures touching you take 4d6 fire damage instead of 3d6, your unarmed attacks deal 2d4 additional fire damage, and you have a fly Speed of 60 feet." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("736b453d-999d-4f73-8923-3667f06eec61"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 337
            };
        }
    }
}
