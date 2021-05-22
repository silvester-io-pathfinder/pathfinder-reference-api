using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AcidSplash : Template
    {
        public static readonly Guid ID = Guid.Parse("e6dec1cf-3b35-4abc-9267-4a30e44df08c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Acid Splash",
                Targets = "1 creature.",
                Level = 1,
                Range = "30 feet.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f9a0898b-9cf0-41d2-ba7c-5706a7109e71"), Type = Utilities.Text.TextBlockType.Text, Text = "You splash a glob of acid that splatters your target and nearby creatures. Make a spell attack. If you hit, you deal 1d6 acid damage plus 1 splash acid damage. On a critical success, the target also takes 1 persistent acid damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9da22e21-d1e7-43d1-88e8-e95065c242db"),
                Level = "3rd", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("672a2316-1939-4b9f-9cfb-624830f43fce"), Type = Utilities.Text.TextBlockType.Text, Text = "The initial damage increases to 1d6 + your spellcasting ability modifier, and the persistent damage increases to 2." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("07445e05-eccc-4463-b72a-ab813e961d2e"), 
                Level = "5th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9a0f3e61-e70a-43d8-b9b8-83be2811e5a3"), Type = Utilities.Text.TextBlockType.Text, Text = "The initial damage increases to 2d6 + your spellcasting ability modifier, the persistent damage increases to 3, and the splash damage increases to 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("107e9a96-572d-40b9-87d9-bf36b2302260"),
                Level = "7th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cc25bc79-a18b-4e1e-81bc-e63aa1a91cfa"), Type = Utilities.Text.TextBlockType.Text, Text = "The initial damage increases to 3d6 + your spellcasting ability modifier, the persistent damage increases to 4, and the splash damage increases to 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("a7a384da-ca83-4941-969f-668d59f18cb5"),
                Level = "9th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("24b63a1a-f410-4c85-b5c4-a11feab9fde1"), Type = Utilities.Text.TextBlockType.Text, Text = "The initial damage increases to 4d6 + your spellcasting ability modifier, the persistent damage increases to 5, and the splash damage increases to 4." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Acid.ID;
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 316
            };
        }
    }
}
