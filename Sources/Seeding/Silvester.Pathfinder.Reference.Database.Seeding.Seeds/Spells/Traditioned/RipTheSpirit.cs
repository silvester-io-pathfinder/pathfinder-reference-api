using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RipTheSpirit : Template
    {
        public static readonly Guid ID = Guid.Parse("d71e606f-601c-4e2f-9340-7d24bfebf82a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Rip the Spirit",
                Level = 5,
                Range = "30 feet.",
                Targets = "1 living creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9496d77b-f429-4783-9da1-44498883c327"), Type = TextBlockType.Text, Text = "You supernaturally rip the spirit from a living creature�s body, dooming the target to pain and death. The target takes 5d6 negative damage, depending on its basic Fortitude save, and is drained 1 if it fails its save. The spell�s effect is based on how many actions you spend when Casting the Spell." };
            yield return new TextBlock { Id = Guid.Parse("8354bf45-c2e1-4c33-a29b-67f260f4ef09"), Type = TextBlockType.Enumeration, Text = "[one-action] (somatic) The spell targets one living creature in range." };
            yield return new TextBlock { Id = Guid.Parse("66edb475-f628-458d-b188-a1d913ed90a5"), Type = TextBlockType.Enumeration, Text = "[two-actions] (somatic, verbal) The spell targets one living creature in range and the damage is 10d6 negative instead of 5d6." };
            yield return new TextBlock { Id = Guid.Parse("c0342439-162b-46f3-ae24-506bc281ebe6"), Type = TextBlockType.Enumeration, Text = "[three-actions] (material, somatic, verbal) The spell targets all living creatures in a 30-foot emanation." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9a33650b-5228-442e-be39-0853458bc28b"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("39254b99-1752-4961-aca0-8870b1775d26"), Type = TextBlockType.Text, Text = "The amount of damage increases by 1d6, or by 2d6 for the 2 - action version." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9dcbd1ce-98d3-4fa5-809d-d7e603254591"), Traits.Instances.Death.ID);
            builder.Add(Guid.Parse("15b7a01e-dad4-477e-8858-5b6d4ae61f5c"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("811f7c70-7a5e-465a-9885-34634366e136"), Traits.Instances.Negative.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd6955d8-0654-4914-942a-e108736f99a2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 126
            };
        }
    }
}
