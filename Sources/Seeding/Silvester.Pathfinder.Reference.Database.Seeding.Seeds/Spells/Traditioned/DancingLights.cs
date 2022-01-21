using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DancingLights : Template
    {
        public static readonly Guid ID = Guid.Parse("7b0f3283-1f79-4a64-a697-eb842bb776b2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dancing Lights",
                Level = 1,
                Range = "120 feet.",
                Duration = "Sustained.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b68ff7f1-51e6-44b8-b9c3-0af52ed1082c"), Type = Utilities.Text.TextBlockType.Text, Text = "You create up to four floating lights, no two of which are more than 10 feet apart. Each sheds light like a torch. When you Sustain the Spell, you can move any number of lights up to 60 feet. Each light must remain within 120 feet of you and within 10 feet of all others, or it winks out." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("bee33cc9-c38c-44f6-81ad-3e0d5d0019c2"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("eb9d2764-22b9-48d7-af6e-5a5f63ff7265"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("2804c8ce-5a99-49b1-8f48-3f357758fb9b"), Traits.Instances.Light.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67bdc0e1-e548-4ae6-b104-b7a04b764644"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 327
            };
        }
    }
}
