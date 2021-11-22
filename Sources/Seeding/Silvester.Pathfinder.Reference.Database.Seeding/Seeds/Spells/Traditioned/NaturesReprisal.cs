using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class NaturesReprisal : Template
    {
        public static readonly Guid ID = Guid.Parse("efd93a26-5c56-4d90-bf95-36ea52d63286");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nature's Reprisal",
                Level = 6,
                Range = "120 feet.",
                Duration = "1 minute.",
                Area = "All squares on the ground that contain plants in an 80-foot burst.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8ad4d8e-7275-4729-a754-af8e20cc6e10"), Type = TextBlockType.Text, Text = "The plant life within the area begins to writhe and lash out against your enemies as you call upon nature to impede your foes. To your enemies, the area becomes difficult terrain, and areas that were naturally difficult terrain due to plants become greater difficult terrain as well as hazardous terrain, dealing 6 poison damage to an enemy each time it enters an affected square." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c4d85de2-f1ad-4e9d-b2b7-73c458b1af32"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("caab6285-440e-4e4d-8f00-f20e71e7dacc"), Type = TextBlockType.Text, Text = "The poison damage of the hazardous terrain increases by 1." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Plant.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75517a99-5269-44bb-91b2-223e1677571d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 117
            };
        }
    }
}
