using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HybridStudies.Instances
{
    public class StarlitSpan : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override HybridStudy GetHybridStudy()
        {
            return new HybridStudy
            {
                Id = ID, 
                Name = "Starlit Span",
                ConfluxSpellId = Spells.Instances.ShootingStar.ID,
                SeventhSpellId = Spells.Instances.Darkvision.ID,
                EleventhSpellId = Spells.Instances.WallOfWind.ID,
                ThirteenthSpellId = Spells.Instances.FreedomOfMovement.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "With magic, the sky's the limit, and you can't be bound by the confines of physical proximity. Your power reaches as far as your senses can perceive, transcending the space between you and your target even with spells that normally require direct physical contact." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you use Spellstrike, you can make a ranged weapon or ranged unarmed Strike, as long as the target is within the first range increment of your ranged weapon or ranged unarmed attack. You can deliver the spell even if its range is shorter than the range increment of your ranged attack." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //Add the conflux spell.
            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.ShootingStar.ID
            };

            //Add studious spell slots from level 7 up to and excluding to 11.
            yield return new GainSpecificSpellSlotEffect
            {
                Id = Guid.Parse(""),
                Amount = 2,
                Level = 2,
                IsSpendingPreventable = true,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 7 }
                    },
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.LessThan, RequiredLevel = 11 }
                    }
                }
            };

            //Add studious spell slots from level 11 up to and excluding to 13.
            yield return new GainSpecificSpellSlotEffect
            {
                Id = Guid.Parse(""),
                Amount = 2,
                Level = 3,
                IsSpendingPreventable = true,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11 }
                    },
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.LessThan, RequiredLevel = 13 }
                    }
                }
            };

            //Add studious spell slots from level 13 and beyond.
            yield return new GainSpecificSpellSlotEffect
            {
                Id = Guid.Parse(""),
                Amount = 2,
                Level = 4,
                IsSpendingPreventable = true,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 13 }
                    }
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 7 }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.SpiderClimb.ID}
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.TrueStrike.ID}
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.WaterBreathing.ID}
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Darkvision.ID}
                    }
                }
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.WallOfWind.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11 }
                    }
                }
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.FreedomOfMovement.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 13 }
                    }
                }
            };

            //TODO: Add the Arcane Cascade modification effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 39
            };
        }
    }
}
