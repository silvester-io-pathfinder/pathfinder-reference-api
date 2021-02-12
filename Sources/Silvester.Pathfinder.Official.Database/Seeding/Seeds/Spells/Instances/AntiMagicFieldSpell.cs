using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AntiMagicFieldSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Three Actions";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("3e91401a-203c-4d1e-9a76-0012e2617cd8"),
                Name = "Anti-Magic Field",
                Description = "You repel all magic from the target area, preventing spells and other magic from functioning. Spells can’t penetrate the area, magic items cease to function within it, and no one inside can cast spells or use magic abilities. Likewise, spells— such as dispel magic—can’t affect the field itself unless they are of a higher level. Magic effects resume the moment they pass outside the field. For example, a ray fired from one side of the field could target a creature on the other side (as long as caster and target are both outside the field). A summoned creature winks out of existence but reappears if the field moves or ends. Invested magic items cease to function, but they remain invested and resume functioning when they exit the field; the ability boost from an apex item isn’t suppressed within the field. Spells of a higher level than the antimagic field overcome its effects, and can even be cast by a creature within the field. The field disrupts only magic, so a +3 longsword still functions as a longsword. Magically created creatures (such as golems) function normally within an antimagic field.",
                Level = 8,
                Area = "10-foot emanation, which affects you.",
                Duration = "1 minute."
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Divine";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Rare";
            yield return "Abjuration";
        }
    }
}
