using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
            yield return new TextBlock { Id = Guid.Parse("8180da6b-0c6f-4da5-a819-d11356e95cf4"), Type = TextBlockType.Text, Text = "Your ancestor protects you against those who would bend your will. You roll the triggering save twice and use the better result. If you're in an encounter when you cast this spell, you immediately roll to change your predominant ancestor." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d8a6ea2b-d0d3-449d-a902-22582d946c14"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e16e8778-6597-4e74-8b7c-1bf282b9362f"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("f2e2fd9a-d1fc-4c50-a921-8bb97a4f8991"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("df3f8c4f-8558-4966-bf21-2c12ff02a751"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("377c446f-05de-4ebd-84b5-66a3fa7f21b3"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("7fe28e1b-230f-4ad9-baf7-4440a4b4c33e"), Traits.Instances.Oracle.ID);
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
