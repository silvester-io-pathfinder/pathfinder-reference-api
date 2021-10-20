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
    public class InexorableIron : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override HybridStudy GetHybridStudy()
        {
            return new HybridStudy
            {
                Id = ID, 
                Name = "Inexorable Iron",
                ConfluxSpellId = Spells.Instances.ThunderousStrike.ID,
                SeventhSpellId = Spells.Instances.Enlarge.ID,
                EleventhSpellId = Spells.Instances.Earthbind.ID,
                ThirteenthSpellId = Spells.Instances.DimensionalAnchor.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Once you begin along a path, nothing can stop you from reaching its end. You transform the mass of a greataxe, greatsword, or polearm into an unstoppable force to augment your own striking power or keep you standing on the battlefield." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you enter Arcane Cascade stance and at the start of each of your turns while you're in that stance, if you're wielding a melee weapon in two hands, you gain temporary Hit Points equal to half your level (minimum 1 temporary HP)." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //Add the conflux spell.
            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.ThunderousStrike.ID
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
                Entries = new []
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
                        Effect = new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Enlarge.ID}
                    }
                }
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.Earthbind.ID,
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
                SpellId = Spells.Instances.DimensionalAnchor.ID,
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
