using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Teleport : Template
    {
        public static readonly Guid ID = Guid.Parse("d32fdf82-8fc3-48e4-98f2-708402cb0409");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Teleport",
                Level = 6,
                CastTime = "10 minutes.",
                Range = "100 miles.",
                Targets = "You and up to 4 targets touched, either willing creatures or objects roughly the size of a creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8669b621-a19b-4b74-8b99-57beba49e92d"), Type = TextBlockType.Text, Text = "You and the targets are instantly transported to any location within range, as long as you can identify the location precisely both by its position relative to your starting position and by its appearance (or other identifying features). Incorrect knowledge of the location’s appearance usually causes the spell to fail, but it could instead lead to teleporting to an unwanted location or some other unusual mishap determined by the GM. Teleport is not precise over great distances. The targets appear at a distance from the intended destination equal to roughly 1 percent of the total distance traveled, in a direction determined by the GM. For short journeys, this lack of precision is irrelevant, but for long distances this could be up to 1 mile." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("61c05b7d-93cd-4355-9118-32200582ed87"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8fd089c4-b4c4-4671-b453-2e35741375af"), Type = TextBlockType.Text, Text = "You and the other targets can travel to any location within 1,000 miles." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("6b51e568-c713-481c-b360-659cd51d311a"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b4321e58-bedd-4c6f-993b-2e0da8b78898"), Type = TextBlockType.Text, Text = "You and the other targets can travel to any location on the same planet. If you travel more than 1,000 miles, you arrive only 10 miles off target." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("7d0cb64b-e663-44ba-8ea6-58f869fad391"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("088eaa01-7a50-417b-8fce-5daa5083dc3e"), Type = TextBlockType.Text, Text = "You and the other targets can travel to any location on another planet within the same solar system. Assuming you have accurate knowledge of the location’s position and appearance, you arrive on the new planet 100 miles off target." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("44bb8865-4dc9-4135-a111-a346e7dcb959"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("50076f54-078d-43c5-989a-c84c6d49091e"), Type = TextBlockType.Text, Text = "As the 9th-level version, but you and the other targets can travel to any planet within the same galaxy." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ec95c63-00e2-4df3-b889-00311da6a69e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 378
            };
        }
    }
}
