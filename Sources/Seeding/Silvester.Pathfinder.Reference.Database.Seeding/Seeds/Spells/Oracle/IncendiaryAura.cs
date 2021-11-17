using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class IncendiaryAura : Template
    {
        public static readonly Guid ID = Guid.Parse("9dee4209-a50f-45fe-afb7-50a6119f1a1e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Incendiary Aura",
                Level = 1,
                Area = "10-foot emanation.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("01ccffb6-31fc-412a-b895-be3d609c976d"), Type = TextBlockType.Text, Text = "You surround yourself with a combustible aura. Each time a creature within the emanation takes fire damage, it catches on fire, taking 2d4 persistent fire damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d4b49b51-2eea-4198-9cfd-6634e951bd7b"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("02389678-ac08-4df0-ba6b-7014c3ff21d1"), Type = TextBlockType.Text, Text = "Increase the persistent damage by 1d4 and the radius of the emanation by 5 feet." }
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
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21613c6a-b90b-48c5-a5b6-fb7707f68232"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 232
            };
        }
    }
}
