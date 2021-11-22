using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ProliferatingEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("8cad0bb2-6619-40bf-8c06-72558ddbd652");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Proliferating Eyes",
                Level = 9,
                Range = "Touch.",
                Duration = "8 hours.",
                Targets = "1 creature (see text).",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bee4ef51-404a-4920-baa4-aec5be6f141d"), Type = TextBlockType.Text, Text = "You implant an invisible, magical eye sensor on the target�s body. The eye has sight and vision, but no other special senses. The eye is highly contagious�the first two times the target touches another creature during the duration, the spell buds off an additional eye that implants itself on that creature, which can then bud off two eyes of its own. This process can propagate up to four times from the original target, for a potential maximum of 31 eyes if each affected creature touches two new creatures." };
            yield return new TextBlock { Id = Guid.Parse("c2b609af-df1d-45c0-97d8-b6fa79cda384"), Type = TextBlockType.Text, Text = "You can switch between perceiving through your own senses or the vision of any of the eye sensors using a single action, which has the concentrate trait. You always know how many eyes there are and can tell which original eyes budded off to make which new eyes, though you gain no special insight into the identity of the new targets other than what you can glean from spying on them." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Scrying.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ada073b8-aba3-4d84-9ef7-8a3b5f85bd97"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 122
            };
        }
    }
}
