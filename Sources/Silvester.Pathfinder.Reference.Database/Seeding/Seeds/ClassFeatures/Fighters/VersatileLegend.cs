using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class VersatileLegend : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Versatile Legend", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You are nigh-unmatched with any weapon. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to legendary, and your proficiency rank for advanced weapons increases to master. Your proficiency rank for your fighter class DC increases to master." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new CombinedEffect
            {
                Id = Guid.Parse(""),
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 19
                        }
                    }
                },
                Entries = new []
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Legendary.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Simple.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Legendary.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Martial.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Legendary.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Unarmed.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponCategoryProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
                            WeaponCategoryId = WeaponCategories.Instances.Advanced.ID
                        }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificClassDcProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            ProficiencyId = Proficiencies.Instances.Master.ID,
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
                Page = 144
            };
        }
    }
}
