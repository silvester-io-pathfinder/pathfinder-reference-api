using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlindingFury : Template
    {
        public static readonly Guid ID = Guid.Parse("3cf65deb-73f3-4696-b6ef-f117c2c84297");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blinding Fury",
                Level = 6,
                Range = "60 feet.",
                Duration = "Varies.",
                Targets = "The triggering creature.",
                Trigger = "A creature damages you.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d528992-e963-42bf-bed9-a09903b64d67"), Type = TextBlockType.Text, Text = "You curse the target with your outrage at being attacked. The effect is determined by the target's Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("5bacd27a-8198-40b0-bc38-b183a2e7c0f4"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target can't observe you until the end of its turn, and if you're currently observed by it, you become hidden to it.",
                Failure = "As success, and for 1 minute, every time the target damages you, it can't observe you until the end of its turn.",
                CriticalFailure = "As success, and for an unlimited duration, the first time each round the target damages a creature, it can't observe that creature until the end of its turn. If it damages several creatures at once, the creature it can't perceive is chosen randomly among those creatures."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("47e31a5b-f95d-4591-8d99-f9ad6399e3fc"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("402747ae-138b-469d-b35d-37b07728b56d"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("520f4c3a-c4a8-4c14-8b10-1dbfd28b1af6"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("7d748b22-40d6-41e1-b78f-a8d2a39895f5"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("ee61e610-4090-414f-bb89-336aa1c98d15"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28580c4e-14be-44c3-905a-3c20ef82e16d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 216
            };
        }
    }
}