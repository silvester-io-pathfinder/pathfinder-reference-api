using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShadowSiphon : Template
    {
        public static readonly Guid ID = Guid.Parse("b6e4013e-d7c1-40b2-8a8a-c16ce0eff337");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shadow Siphon",
                Level = 5,
                Range = "60 feet.",
                Targets = "The triggering spell.",
                Trigger = "A spell or magic effect deals damage.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d45fd659-908e-480c-8e5a-c430c0d83f78"), Type = TextBlockType.Text, Text = "Exchanging material energy with that of the Shadow Plane, you transform the triggering spell into a partially illusory version of itself. Attempt to counteract the target spell. If the attempt is successful, any creatures that would be damaged by the spell instead take only half as much damage, but the spell otherwise works as normal. Treat shadow siphon's counteract level as 2 higher for this attempt." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Shadow.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0de43601-8460-43a8-8638-381c71a71003"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 368
            };
        }
    }
}
