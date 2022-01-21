using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShadowIllusion : Template
    {
        public static readonly Guid ID = Guid.Parse("2b0bf2a9-c4fe-45da-b37f-3fa8269d0160");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shadow Illusion",
                Level = 6,
                Range = "500 feet.",
                Duration = "Sustained.",
                Area = "",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42c6c551-dcab-4c09-bf5e-433bae6ee98f"), Type = TextBlockType.Text, Text = "You create a shadowy illusion of a creature or a stationary object, but the illusion can exist only in an area of dim light or darkness. The spell ends if the illusion is ever out of an area of dim light or darkness. If the illusion is an object, it must fit within a 20-foot burst, and the creature can be of any size up to Gargantuan, filling a 20-foot-by-20-foot space." };
            yield return new TextBlock { Id = Guid.Parse("ccc9d39d-cb76-4226-996e-d2e7fd8691fc"), Type = TextBlockType.Text, Text = "The object or creature appears to animate naturally; it even generates the appropriate sounds and smells, and feels believable to the touch, though its coloring is always muted." };
            yield return new TextBlock { Id = Guid.Parse("836e8748-e108-41b5-ae39-e220684d1670"), Type = TextBlockType.Text, Text = "If the illusion is a creature, shadow illusion has the effects of an illusory creature spell of the same level, except it deals 2d8 damage plus your spellcasting ability modifier, instead of the amount listed in illusory creature." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0f9f1d0e-538e-4bea-8044-c7d62b3d41f0"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("7595a9dd-094c-4eda-9844-8b85dc78f545"), Type = TextBlockType.Text, Text = "The area that an illusory object can fit in increases by 10 feet. The damage of the illusory creature�s Strike increases by 1d8." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("79369fc3-71ae-44a4-8be2-400dfa78bf8e"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("3a355310-f62d-406d-8c9f-9091e2c21ecb"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("96b96280-4aa1-43d9-98c0-875f471017fd"), Traits.Instances.Shadow.ID);
            builder.Add(Guid.Parse("68516435-1534-411b-a6c3-47fc48d245bc"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fdd2e37-fc75-426a-a46e-ff654dfb87e8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 193
            };
        }
    }
}
