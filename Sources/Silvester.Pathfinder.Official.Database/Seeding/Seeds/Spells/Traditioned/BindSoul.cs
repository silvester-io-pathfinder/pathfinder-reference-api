using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BindSoul : Template
    {
        public static readonly Guid ID = Guid.Parse("a0dc825d-78c6-4464-a62e-17d7001c258e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Bind Soul",
                Level = 2,
                Range = "30 feet.",
                Targets = "1 creature that died within the last minute.",
                Requirements = "Black Sapphire with a gp value of at least the target's level x100.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc567753-dd14-46d2-969e-2fb187ae0fbb"), Type = Utilities.Text.TextBlockType.Text, Text = "You wrench the target’s soul away before it can pass on to the afterlife and imprison it in a black sapphire." };
            yield return new TextBlock { Id = Guid.Parse("53346ab9-5ab3-45e8-8692-1d8f9b1249e0"), Type = Utilities.Text.TextBlockType.Text, Text = "While the soul is in the gem, the target can’t be returned to life through any means, even powerful magic such as wish. If the gem is destroyed or bind soul is counteracted on the gem, the soul is freed. The gem has AC 16 and Hardness 10. A gem can’t hold more than one soul, and any attempt wastes the spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a455573-c3a1-442b-829d-fbbab087cb4b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 320
            };
        }
    }
}
