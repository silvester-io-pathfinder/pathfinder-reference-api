using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Status : Template
    {
        public static readonly Guid ID = Guid.Parse("f66871da-39f0-4faf-9d75-04cbddbe301e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Status",
                Level = 2,
                Range = "Touch.",
                Duration = "1 day.",
                Targets = "1 willing living creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
             yield return new TextBlock { Id = Guid.Parse("7d2779d2-610e-4afc-888a-14d72eb1bbcb"), Type = TextBlockType.Text, Text = "As long as you and the target are on the same plane ofexistence and both alive, you remain aware of its present state. You know the target's direction from you, distance from you, and any conditions affecting it." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e5484736-47fe-4689-ae21-40e5aa293950"), 
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6d0b88df-9b5d-4d5e-a9ab-999f66afc708"), Type = TextBlockType.Text, Text = "The spell's range increases to 30 feet, and you can target up to 10 creatures." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("df60af44-31d5-4085-955b-76086bb46cad"), Traits.Instances.Detection.ID);
            builder.Add(Guid.Parse("0cc6f150-5404-4d6c-9fe3-5e833dcae5e0"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d1d637b-68e4-4502-98e1-c98bdd4aae58"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 373
            };
        }
    }
}
