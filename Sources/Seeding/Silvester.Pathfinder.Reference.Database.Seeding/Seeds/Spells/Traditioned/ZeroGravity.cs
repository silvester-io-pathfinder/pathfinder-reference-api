using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ZeroGravity : Template
    {
        public static readonly Guid ID = Guid.Parse("18ba0a6a-fa87-4ce5-b642-52bf6041eb4c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Zero Gravity",
                Level = 6,
                Range = "120 feet.",
                Duration = "Sustained up to 1 minute.",
                Area = "20-foot radius, 40-foot-tall cylinder.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3d34c7b7-ee1b-4453-b246-2b0c56a7bdd5"), Type = TextBlockType.Text, Text = "You negate gravity�s effects in the area. Creatures float in place unless they can Push Off a surface. Pushing Off is a single action which has the move trait, allowing the creature to move half its Speed in a straight line through the area. After Pushing Off a surface, the creature continues to move the same distance at the start of each of its turns until it leaves the area or Pushes Off against something else. A creature pushing against an untethered object of its size or smaller causes both the creature and the object to move at the same speed, but in opposite directions. Creatures who can levitate or fly can use those abilities to move around in the area without having to push off anything. Creatures who can�t levitate or fly are usually on the ground, giving them a surface from which to push off." };
            yield return new TextBlock { Id = Guid.Parse("7ce870a4-b923-418b-b75b-d6477816a89e"), Type = TextBlockType.Text, Text = "You can Dismiss this spell. When zero gravity ends, all creatures and objects in the area fall back down." };
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
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("391ca7c3-5f2a-40a6-b6e5-f6fe5dde2a49"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 141
            };
        }
    }
}
