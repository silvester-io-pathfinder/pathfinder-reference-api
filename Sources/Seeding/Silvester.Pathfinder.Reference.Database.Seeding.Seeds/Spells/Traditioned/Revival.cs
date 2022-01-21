using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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
            yield return new TextBlock { Id = Guid.Parse("0fc930bf-d764-4996-96d0-e378ae188cf3"), Type = TextBlockType.Text, Text = "A burst of healing energy soothes living creatures and temporarily rouses those recently slain. All living targets regain 10d8+40 Hit Points. In addition, you return any number of dead targets to life temporarily, with the same effects and limitations as raise dead (page 362). The raised creatures have a number of temporary Hit Points equal to the Hit Points you gave living creatures, but no normal Hit Points. The raised creatures can't regain Hit Points or gain temporary Hit Points in other ways, and once revival's duration ends, they lose all temporary Hit Points and die. Revival can't resurrect creatures killed by disintegrate or a death effect. It has no effect on undead." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2d981887-e9a6-4e9e-9748-1ec84eb2ceb6"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("3c3f5f13-98e8-4616-8faf-6d7b4608eee8"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("c32e0682-1e2c-429b-bec6-3739b31d0d77"), Traits.Instances.Positive.ID);
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
