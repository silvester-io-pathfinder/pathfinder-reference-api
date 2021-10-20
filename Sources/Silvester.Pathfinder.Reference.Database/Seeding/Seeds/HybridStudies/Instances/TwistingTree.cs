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
    public class TwistingTree : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override HybridStudy GetHybridStudy()
        {
            return new HybridStudy
            {
                Id = ID, 
                Name = "Twisting Tree",
                ConfluxSpellId = Spells.Instances.SpinningStaff.ID,
                SeventhSpellId = Spells.Instances.MagicMouth.ID,
                EleventhSpellId = Spells.Instances.Slow.ID,
                ThirteenthSpellId = Spells.Instances.Blink.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The staff is perhaps one of the simplest of weapons, but this simplicity belies its elegance and versatility. To you, a staff is casting implement and martial weapon alike—the foundation of a fighting style." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While you wield a staff in one hand, the staff adjusts in shape and weight, gaining the agile trait and increasing its damage die size to 1d6. While you wield a staff in both hands, it lengthens, twists, and reshapes, gaining the parry, reach, and trip traits. While you're in Arcane Cascade stance, you can Interact or Release to change your grip on the weapon as a free action when you Strike with your staff, including Strikes made in a Spellstrike. This happens before you roll your attack roll. You can also Interact to change your grip on the staff as a free action triggered at the end of your turn. " };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //Add the conflux spell.
            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.SpinningStaff.ID
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
                        Effect = new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.MagicMouth.ID}
                    }
                }
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.Slow.ID,
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
                SpellId = Spells.Instances.Blink.ID,
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
                Page = 40
            };
        }
    }
}
