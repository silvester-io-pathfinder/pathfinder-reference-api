using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Doctrines.Instances
{
    public class CloisteredCleric : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Doctrine GetDoctrine()
        {
            return new Doctrine
            {
                Id = ID,
                Name = "Cloistered Cleric",
                Description = "You are a cleric of the cloth, focusing on divine magic and your connection to your deity’s domains."
            };
        }

        public override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificFeatEffect 
            {
                Id = Guid.Parse(""), 
                Name = "First Doctrine",
                FeatId = Feats.Instances.DomainInitiate.ID
            };

            yield return new GainSpecificSavingThrowProficiencyEffect
            {
                Id = Guid.Parse(""),
                Name = "Second Doctrine",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ProficiencyId = Proficiencies.Instances.Expert.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 3 }
                    }
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Name = "Third Doctrine",
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
                        Effect = new GainSpecificSpellAttackProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellDcProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                        }
                    }
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Name = "Fourth Doctrine",
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11 }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainDeityFavoredWeaponProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Expert.ID,
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainDeityFavoredWeaponSpecializationEffect
                        {
                            Id = Guid.Parse("")
                        }
                    }
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Name = "Fifth Doctrine",
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 15 }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellAttackProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellDcProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                        }
                    }
                }
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Name = "Final Doctrine",
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 19 }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellAttackProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Legendary.ID,
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSpellDcProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Legendary.ID,
                        }
                    }
                }
            };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 119
            };
        }
    }
}
