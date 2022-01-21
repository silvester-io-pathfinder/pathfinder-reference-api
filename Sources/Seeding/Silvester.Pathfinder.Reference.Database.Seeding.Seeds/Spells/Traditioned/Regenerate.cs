using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Regenerate : Template
    {
        public static readonly Guid ID = Guid.Parse("becd7da8-c65e-479a-92c2-788a9c863662");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Regenerate",
                Level = 7,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 willing living creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1393166-031e-4f6a-8254-1b23b118228a"), Type = TextBlockType.Text, Text = "An infusion of positive energy grants a creature continuous healing. The target temporarily gains regeneration 15, which restores 15 Hit Points to it at the start of each of its turns. While it has regeneration, the target can't die from damage and its dying condition can't increase to a value that would kill it (this stops most creatures from going beyond dying 3), though if its wounded value becomes 4 or higher, it stays unconscious until its wounds are treated. If the target takes acid or fire damage, its regeneration deactivates until after the end of its next turn." };
            yield return new TextBlock { Id = Guid.Parse("f7d901be-ad0b-4d23-be85-e72e431d96eb"), Type = TextBlockType.Text, Text = "Each time the creature regains Hit Points from regeneration, it also regrows one damaged or ruined organ (if any). During the spell's duration, the creature can also reattach severed body parts by spending an Interact action to hold the body part to the area it was severed from." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b5e567f4-b9e7-4c09-8aa5-4d3d5cd8a01a"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("202cd1ae-eec2-449d-901f-8b49966cf6c2"), Type = TextBlockType.Text, Text = "The regeneration increases to 20." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("6964e796-eb3b-46e5-a4a9-ef07592f7696"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("93bb17f4-a9ba-4b6d-9e7d-5b7be41e02d7"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("5ea2d214-c0df-4b5b-a9ac-44458d254c3d"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d593c706-1092-4a0e-b8ee-bf44fcf9beda"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 363
            };
        }
    }
}
