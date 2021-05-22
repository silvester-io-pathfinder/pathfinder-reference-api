using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Revival : Template
    {
        public static readonly Guid ID = Guid.Parse("44f0f796-c02f-467c-973a-e328f284bfe1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Revival",
                Level = 10,
                Range = "30 feet.",
                Duration = "Sustained up to 1 minute.",
                Targets = "Dead creatures and living creatures of your choice within range.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fc930bf-d764-4996-96d0-e378ae188cf3"), Type = TextBlockType.Text, Text = "A burst of healing energy soothes living creatures and temporarily rouses those recently slain. All living targets regain 10d8+40 Hit Points. In addition, you return any number of dead targets to life temporarily, with the same effects and limitations as raise dead (page 362). The raised creatures have a number of temporary Hit Points equal to the Hit Points you gave living creatures, but no normal Hit Points. The raised creatures can’t regain Hit Points or gain temporary Hit Points in other ways, and once revival’s duration ends, they lose all temporary Hit Points and die. Revival can’t resurrect creatures killed by disintegrate or a death effect. It has no effect on undead." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f4f282c-b59f-4224-8fda-80c891043965"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 366
            };
        }
    }
}
