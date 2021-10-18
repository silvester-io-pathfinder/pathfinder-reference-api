using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class WeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your rage helps you hit harder. You deal an additional 2 damage with weapons and unarmed attacks in which you have expert proficiency. This damage increases to 3 if you’re a master, and 4 if you’re legendary. You gain your instinct’s specialization ability." };
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
                            RequiredLevel = 7
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
                            RequiredLevel = 7
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
                            RequiredLevel = 7
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

            //TODO: Add instinct ability effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 85
            };
        }
    }
}
