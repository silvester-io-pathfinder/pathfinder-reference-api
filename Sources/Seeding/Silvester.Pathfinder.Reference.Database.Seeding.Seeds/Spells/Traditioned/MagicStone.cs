using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MagicStone : Template
    {
        public static readonly Guid ID = Guid.Parse("4b942432-9074-417e-863b-29f29b8f335d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Magic Stone",
                Level = 1,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 to 3 non-magical stones or sling bullets.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("15143952-1094-45b8-9407-40fc8db3216c"), Type = TextBlockType.Text, Text = "You pour positive energy into ordinary stones, granting them temporary magical properties. You can target 1 non-magical stone or sling bullet for every action you use Casting this Spell. The stones must be unattended or carried by you or a willing ally. The stones become +1 striking disrupting sling bullets. Each stone can be used only once, after which it crumbles to dust." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e06c61b5-31d6-48d8-a845-1f8b3dfc9d01"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("d0f4f881-a2cf-42a0-8667-4a3ce5cb6781"), Traits.Instances.Primal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27612e7e-02a9-4dbf-9472-d325184f95f3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 222
            };
        }
    }
}
