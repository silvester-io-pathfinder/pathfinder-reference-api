using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DiscernLocation : Template
    {
        public static readonly Guid ID = Guid.Parse("31f6e676-dbee-4c8f-9f17-a842afab35e3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Discern Location",
                Level = 4,
                CastTime = "10 minutes.",
                Targets = "1 creature or object",
                Duration = "1 minute",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("621e7e81-5364-4a90-9ed2-085bd438af31"), Type = Utilities.Text.TextBlockType.Text, Text = "You learn the name of the target's exact location (including the building, community, and country) and plane of existence." };
            yield return new TextBlock { Id = Guid.Parse("3f43ac0e-e9bf-431b-adad-1e38650be56e"), Text = "You can target a creature only if you've seen it in person, have one of its significant belongings, or have a piece of its body. To target an object, you must have touched it or have a fragment of it. Discern location automatically overcomes protections against detection and divination of lower level than this spell, even if they would normally have a chance to block it." };
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("eff4cb71-0632-4688-ad51-afc6c3d38c91"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("8cf402bf-dd05-488d-8426-bdb8939d91f5"), Traits.Instances.Detection.ID);
            builder.Add(Guid.Parse("c7d25cf1-62a6-47b2-a545-cf7fccfafe0d"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("940cd471-bc28-46b4-94c3-9d4d56418742"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 330
            };
        }
    }
}
