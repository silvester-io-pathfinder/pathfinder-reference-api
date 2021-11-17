using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AncestralDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("f9448ab0-82fe-4cd1-a2d7-91ae71b6ed5a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ancestral Defense",
                Level = 3,
                Trigger = "You are about to attempt a Will save.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8180da6b-0c6f-4da5-a819-d11356e95cf4"), Type = TextBlockType.Text, Text = "Your ancestor protects you against those who would bend your will. You roll the triggering save twice and use the better result. If you’re in an encounter when you cast this spell, you immediately roll to change your predominant ancestor." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Fortune.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2d4d134-394b-4321-8b4e-fe11daab605a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 230
            };
        }
    }
}
