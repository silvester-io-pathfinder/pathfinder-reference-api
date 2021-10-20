using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Weapon Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’ve learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 damage if you’re a master, and 4 damage if you’re legendary." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new ModifyWeaponDamageEffect
            {
                Id = Guid.Parse(""),
                Modifier = 2,
                ModifierType = ModifierType.Add,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 13
                        }
                    },
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveCurrentWeaponProficiencyPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.EqualTo,
                            RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                        }
                    }
                }
            };

            yield return new ModifyWeaponDamageEffect
            {
                Id = Guid.Parse(""),
                Modifier = 3,
                ModifierType = ModifierType.Add,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 13
                        }
                    },
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveCurrentWeaponProficiencyPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.EqualTo,
                            RequiredProficiencyId = Proficiencies.Instances.Master.ID,
                        }
                    }
                }
            };

            yield return new ModifyWeaponDamageEffect
            {
                Id = Guid.Parse(""),
                Modifier = 4,
                ModifierType = ModifierType.Add,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 13
                        }
                    },
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveCurrentWeaponProficiencyPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.EqualTo,
                            RequiredProficiencyId = Proficiencies.Instances.Legendary.ID,
                        }
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 133
            };
        }
    }
}
