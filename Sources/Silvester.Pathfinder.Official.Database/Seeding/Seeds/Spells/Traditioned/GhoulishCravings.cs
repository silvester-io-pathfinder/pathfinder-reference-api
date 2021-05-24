using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class GhoulishCravings : Template
    {
        public static readonly Guid ID = Guid.Parse("a0084011-a907-40e8-bdc9-928161a4f95e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ghoulish Cravings",
                Level = 2,
                Range = "Touch.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5dfeb81a-e86d-43d5-a819-51e92f45af81"), Type = TextBlockType.Text, Text = "You touch the target to afflict it with ghoul fever, infesting it with hunger and a steadily decreasing connection to positive energy; the target must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("92cb1893-1442-4550-b81e-80f18be6e53e"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is afflicted with ghoul fever at stage 1.",
                Failure = "The target is afflicted with ghoul fever at stage 2.",
                CriticalFailure = "The target is afflicted with ghoul fever at stage 3."
            };
        }

        protected override StaggeredEffect GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("bcaa6f5f-e855-420c-8a65-2daff09a9ff4"),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "6",
                Onset = "Immediate",
                Level = 3,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("a7e19a33-d8e8-48d3-8a3a-b0d58e02a3fd"),
                        Duration = "1 day.",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse("6ad26797-0cc3-41e9-a54a-f148c65c8a96"), ConditionId = Conditions.Instances.Carrier.ID}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("a6b51ed4-5cad-4187-8870-104be33801dc"),
                        Duration = "1 day.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("91b204c0-34c4-4a93-96c7-4cff7287a58d"), Damage = "2d8", DamageTypeId = DamageTypes.Instances.Negative.ID },
                            new OtherEffect {Id = Guid.Parse("db711980-1845-4564-afad-a8c83ee3f44d"), Effect = "The creature regains half as many Hit Points from healing."},
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("c011dc5c-0dec-4bee-b663-fc26fae99fb6"),
                        Duration = "1 day.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("8df0ed44-c688-47ed-88f5-de4fbc96607e"), Damage = "2d8", DamageTypeId = DamageTypes.Instances.Negative.ID },
                            new OtherEffect {Id = Guid.Parse("66d0c08c-ed5d-47de-989b-b9ddecbfb0e7"), Effect = "The creature regains half as many Hit Points from healing."},
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("1cee9555-ea04-421d-a3e8-3a5041c3bb86"),
                        Duration = "1 day.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("cbaab1e7-0579-4a69-acf4-6cbc7546d6f3"), Damage = "3d8", DamageTypeId = DamageTypes.Instances.Negative.ID },
                            new OtherEffect {Id = Guid.Parse("dfc7c7e7-4677-4d1f-82b6-78f541a14449"), Effect = "The creature gains no benefit from healing."},
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("0787c627-4ae5-4c7f-b6d8-88e5154e6134"),
                        Duration = "1 day.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("8a0f425d-c974-4689-965a-14e9411a08f5"), Damage = "3d8", DamageTypeId = DamageTypes.Instances.Negative.ID },
                            new OtherEffect {Id = Guid.Parse("a097b8e7-2bde-4013-8b05-08c282b95bdb"), Effect = "The creature gains no benefit from healing."},
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("5630f286-9247-4972-b051-49ba06a5db6f"),
                        Duration = "1 day.",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse("871ffbd2-dd88-40e9-9cc4-f683e8283271"), ConditionId = Conditions.Instances.Dead.ID},
                            new OtherEffect { Id = Guid.Parse("c37a3a18-2255-4d87-b603-fccd80c782ba"), Effect = "The creature rises as a ghoul at the next midnight." }
                        }
                    },
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("197b3b0a-2696-4b98-83ee-90cfd1e90bb0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 341
            };
        }
    }
}
