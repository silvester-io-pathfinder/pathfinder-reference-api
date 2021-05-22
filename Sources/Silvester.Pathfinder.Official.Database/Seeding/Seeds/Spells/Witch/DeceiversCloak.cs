using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DeceiversCloak : Template
    {
        public static readonly Guid ID = Guid.Parse("ceb2a6f9-e34a-4de8-9d90-eaee6b17ff98");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Deceiver's Cloak",
                Level = 3,
                IsDismissable = true,
                Duration = "Sustained.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ceb2a6f9-e34a-4de8-9d90-eaee6b17ff98"), Type = TextBlockType.Text, Text = "You wrap yourself in a cloak of illusion, appearing as another creature of the same body shape with roughly similar height and weight as yourself. This has the effects of a 3rd-level illusory disguise." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ceb2a6f9-e34a-4de8-9d90-eaee6b17ff98"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ceb2a6f9-e34a-4de8-9d90-eaee6b17ff98"), Type = TextBlockType.Text, Text = "You can appear as any creature of the same size, even with a completely different body shape." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ceb2a6f9-e34a-4de8-9d90-eaee6b17ff98"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
