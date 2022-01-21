using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WanderersGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("81b02bc3-d60d-48f0-9f1c-4f4f8de06254");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wanderer's Guide",
                Level = 3,
                CastTime = "1 minute.",
                Duration = "Until your next daily preparations.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48113ea8-b072-49f0-92b2-ada6a7733c11"), Type = TextBlockType.Text, Text = "You call upon the beyond to guide your route. When you Cast this Spell, choose a destination; you receive an inspired route to that destination, allowing you and allies who travel overland with you to reduce the movement penalty from difficult terrain by half for the duration, as long as you don't deviate from the inspired route. This doesn't have any effect on movement during encounters. If you use this ability again before the duration is over, this effect ends and is replaced by that of the new route." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("19e8e4b3-8dc5-40e2-bc5b-afe887b9d161"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d66ecb1-6fcd-409c-a74b-546d4f58cc82"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 383
            };
        }
    }
}
