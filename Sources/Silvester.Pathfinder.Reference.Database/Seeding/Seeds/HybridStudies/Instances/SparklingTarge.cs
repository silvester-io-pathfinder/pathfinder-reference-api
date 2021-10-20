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
    public class SparklingTarge : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override HybridStudy GetHybridStudy()
        {
            return new HybridStudy
            {
                Id = ID, 
                Name = "Sparkling Targe",
                ConfluxSpellId = Spells.Instances.ShieldingStrike.ID,
                SeventhSpellId = Spells.Instances.ResistEnergy.ID,
                EleventhSpellId = Spells.Instances.WardingAggression.ID,
                ThirteenthSpellId = Spells.Instances.Stoneskin.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You've studied the applications of magic, training yourself to perform not just offensive maneuvers but defensive tactics as well. When magic flows through you, your shield can block impossible things, even a dragon's breath or a magic missile." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You gain the Shield Block general feat." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you're in Arcane Cascade stance with your shield raised, your circumstance bonus to AC from your shield also applies to your saves against spells and other magical effects. In addition, damage you take as a result of a spell or magical effect while you're in Arcane Cascade can trigger your Shield Block reaction, even if the damage isn't physical. When blocking damage in this way, increase your shield's Hardness by an amount equal to the extra damage from Arcane Cascade (typically 1, but 2 if you have weapon specialization, or 3 if you have greater weapon specialization). These benefits apply whether you're using an actual shield, the shield spell, or something else that works like a shield (such as a raised tome if you have the Raise a Tome feat)." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //Add the conflux spell.
            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.ShieldingStrike.ID
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
                        Effect = new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ResistEnergy.ID}
                    }
                }
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.WardingAggression.ID,
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
                SpellId = Spells.Instances.Stoneskin.ID,
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
