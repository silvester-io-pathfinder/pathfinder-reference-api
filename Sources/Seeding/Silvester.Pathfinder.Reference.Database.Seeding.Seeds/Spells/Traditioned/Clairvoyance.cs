using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Clairvoyance : Template
    {
        public static readonly Guid ID = Guid.Parse("af9903ec-8e9e-4752-bae4-042aca73f91a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Clairvoyance",
                Level = 4,
                Range = "500 feet.",
                CastTime = "1 minute.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe688355-a855-421f-bb33-20b2fd2b25d1"), Type = Utilities.Text.TextBlockType.Text, Text = "You create an invisible floating eye at a location within range (even if it's outside your line of sight or line of effect). The eye can't move, but you can see in all directions from that point as if using your normal visual senses." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("887c8b5c-c8ff-4845-b5a6-0c634e7a7b15"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("3d2e5f5b-68e6-413d-94d7-11fe66875709"), Traits.Instances.Scrying.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e496295-367f-4bd7-81ce-2a4b782536e7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 324
            };
        }
    }
}
