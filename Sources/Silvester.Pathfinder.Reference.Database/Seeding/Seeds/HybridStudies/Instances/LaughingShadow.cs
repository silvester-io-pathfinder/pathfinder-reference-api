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
    public class LaughingShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override HybridStudy GetHybridStudy()
        {
            return new HybridStudy
            {
                Id = ID, 
                Name = "Laughing Shadow",
                ConfluxSpellId = Spells.Instances.DimensionalAssault.ID,
                SeventhSpellId = Spells.Instances.MirrorImage.ID,
                EleventhSpellId = Spells.Instances.ShiftBlame.ID,
                ThirteenthSpellId = Spells.Instances.DimensionDoor.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Magic is freeing, a means to your ends, and you can use it to go where you want, do as you please, and avoid the consequences. You are a laughing shadow of spell and blade, always one step ahead of your foes, always with a trick up your sleeve." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While in Arcane Cascade stance, you gain a +5-foot status bonus to your Speeds, or a +10-foot bonus if you're unarmored. If you have a free hand while in the stance and are attacking a flat-footed creature, you increase the extra damage to 3, to 5 if you have weapon specialization, or to 7 if you have greater weapon specialization. You must have your other hand completely free; the extra damage doesn't apply if you have a free-hand weapon or other item in that hand, even if you would normally be able to use the hand for other things." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //Add the conflux spell.
            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.DimensionalAssault.ID
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
                        Effect = new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.MirrorImage.ID}
                    }
                }
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.ShiftBlame.ID,
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
                SpellId = Spells.Instances.DimensionDoor.ID,
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
