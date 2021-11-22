using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RaiseDead : Template
    {
        public static readonly Guid ID = Guid.Parse("e7194559-f3b8-445a-83d6-5fca096668c8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Raise Dead",
                Level = 6,
                CastTime = "10 minutes",
                Cost = "Diamonds worth a total value of the target's level (minimum 1) x 200 gp.",
                Range = "10 feet.",
                Targets = "1 dead creature of 13th level or lower.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("78794f12-b6af-40f2-a60e-55168b03acce"), Type = TextBlockType.Text, Text = "You attempt to call forth the dead creature's soul, requiring the creature's body to be present and relatively intact. The creature must have died within the past 3 days. If Pharasma has decided that the creature's time has come (at the GM's discretion), or if the creature doesn't wish to return to life, this spell automatically fails, but the diamonds aren't consumed in the casting." };
            yield return new TextBlock { Id = Guid.Parse("16d7d4b6-39dc-407b-8270-4c9143b9e312"), Type = TextBlockType.Text, Text = "If the spell is successful, the creature returns to life with 1 Hit Point, no spells prepared or spell slots available, no points in any pools or any other daily resources, and still with any long-term debilitations of the old body. The time spent in the Boneyard leaves the target temporarily debilitated, making it clumsy 2, drained 2, and enfeebled 2 for 1 week; these conditions can't be removed or reduced by any means until the week has passed. The creature is also permanently changed by its time in the afterlife, such as a slight personality shift, a streak of white in the hair, or a strange new birthmark." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("8f508309-c02b-468b-b4fe-7275b1a4bc9a"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("44a5610f-9ff1-458a-b7e7-c211dfdf6726"), Type = TextBlockType.Text, Text = "The maximum level of the target increases to 15. The cost increases to the target's level (minimum 1) × 400 gp." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("48dfe5ba-dff9-41f9-b942-ca5aaf821bb1"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("001c124a-51d9-41aa-a472-40fe5e80d999"), Type = TextBlockType.Text, Text = "The maximum level of the target increases to 17. The cost increases to the target's level (minimum 1) × 800 gp." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("6a2c7c70-9e4f-49f4-8000-a5d727e1f998"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("234bd077-bb66-406b-9d03-919bf1c096aa"), Type = TextBlockType.Text, Text = "The maximum level of the target increases to 19. The cost increases to the target's level (minimum 1) × 1,600 gp." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("7fb12a6a-0b7c-471f-b768-98e9d38e2016"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("95a1dd3a-32a2-44dc-b7b6-4eb8ca66879d"), Type = TextBlockType.Text, Text = "The maximum level of the target increases to 21. The cost increases to the target's level (minimum 1) × 3,200 gp." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a66b432e-79d0-4e93-9425-9dc4b3fe591f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 362
            };
        }
    }
}
