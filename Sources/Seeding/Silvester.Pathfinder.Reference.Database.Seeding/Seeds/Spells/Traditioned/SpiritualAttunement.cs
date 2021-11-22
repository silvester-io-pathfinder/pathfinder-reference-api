using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritualAttunement : Template
    {
        public static readonly Guid ID = Guid.Parse("e60b7fc1-43d6-4b88-b98f-1b1f71fbffd9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spiritual Attunement",
                Level = 4,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dde58457-5fa8-489c-b574-c083b8ef4add"), Type = TextBlockType.Text, Text = "You attune yourself to a spiritual plane of the Outer Sphere (see sidebar on page 131), connecting your spirit without fully transporting to it. Your Strikes and spells gain the alignment traits of the plane you chose, which deals additional damage to creatures with a weakness to either of those alignment traits. Furthermore, the plane protects you from energy of the alignments that oppose the plane. You gain resistance 5 to damage of the alignments that oppose those of your chosen plane. For example, if you chose Heaven, your Strikes would gain the good and lawful traits, and you would gain resistance to chaotic and evil. If you choose the Boneyard, the resistance is to negative and positive damage instead." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2b4ef28b-8a29-42d3-b465-e29b923a1c17"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("2f86e560-7ae5-4b2e-9dfb-8b2561a37aa3"), Type = TextBlockType.Text, Text = "The resistance increases by 5." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db774742-a9f2-4350-b447-a372c8d1dd6b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 130
            };
        }
    }
}
