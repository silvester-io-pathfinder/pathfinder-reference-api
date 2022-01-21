using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CrushingDespair : Template
    {
        public static readonly Guid ID = Guid.Parse("2665ca32-131c-43cd-b30b-c763eb024a08");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Crushing Despair",
                Level = 5,
                Area ="30-foot cone.",
                Duration = "1 or more rounds.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6f718d20-6acf-4bcf-a4e1-efebf668f6d7"), Type = Utilities.Text.TextBlockType.Text, Text = "You inflict despair on creatures in the area. The effects for each creature are determined by its Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("48a3785a-a84b-4290-9316-b41d51744c0a"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "For 1 round, the creature can't use reactions and must attempt another save at the start of its turn; on a failure, it is slowed 1 for that turn as it sobs uncontrollably.",
                Failure = "As success, but the duration is 1 minute.",
                CriticalFailure = "As failure, and the creature is automatically slowed 1 for 1 minute."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("cecf2b46-be78-406a-ab01-b1bff4d3917a"), 
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("86662ee0-fcca-4c22-ba32-12225ae67d54"), Type = Utilities.Text.TextBlockType.Text, Text = "The area increases to a 60-foot cone." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("6d2d6218-61ec-4bdb-bdf4-199fbae71b7a"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("665ef3fb-e5a2-4f19-ae8b-6386c5c2ac94"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("e9efd254-5c68-4d75-b37c-82c76486ab70"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("950fca10-c4da-450d-ba4d-fa39420bee1f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 327
            };
        }
    }
}
