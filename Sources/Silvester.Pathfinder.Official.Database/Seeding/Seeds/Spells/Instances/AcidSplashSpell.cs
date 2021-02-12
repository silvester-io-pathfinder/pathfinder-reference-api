using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AcidSplashSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Cantrip";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("e6dec1cf-3b35-4abc-9267-4a30e44df08c"),
                Name = "Acid Splash",
                Description = "You splash a glob of acid that splatters your target and nearby creatures. Make a spell attack. If you hit, you deal 1d6 acid damage plus 1 splash acid damage. On a critical success, the target also takes 1 persistent acid damage.",
                Targets = "1 creature.",
                Level = 1,
                Range = 30
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("9da22e21-d1e7-43d1-88e8-e95065c242db"), Level = 3, Description = "The initial damage increases to 1d6 + your spellcasting ability modifier, and the persistent damage increases to 2." };
            yield return new SpellHeightening { Id = Guid.Parse("07445e05-eccc-4463-b72a-ab813e961d2e"), Level = 5, Description = "The initial damage increases to 2d6 + your spellcasting ability modifier, the persistent damage increases to 3, and the splash damage increases to 2." };
            yield return new SpellHeightening { Id = Guid.Parse("107e9a96-572d-40b9-87d9-bf36b2302260"), Level = 7, Description = "The initial damage increases to 3d6 + your spellcasting ability modifier, the persistent damage increases to 4, and the splash damage increases to 3." };
            yield return new SpellHeightening { Id = Guid.Parse("a7a384da-ca83-4941-969f-668d59f18cb5"), Level = 9, Description = "The initial damage increases to 4d6 + your spellcasting ability modifier, the persistent damage increases to 5, and the splash damage increases to 4." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Acid";
            yield return "Attack";
            yield return "Evocation";
        }
    }
}
