using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class ExpertStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Expert Strikes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’ve practiced martial arts and have now surpassed your former skill. Your proficiency ranks for unarmed attacks and simple weapons increase to expert." };
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
                            RequiredLevel = 5
                        }
                    }
                },
                Entries = new[]
                {
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponCategoryProficiencyEffect { Id = Guid.Parse(""), ProficiencyId = Proficiencies.Instances.Expert.ID, WeaponCategoryId = WeaponCategories.Instances.Unarmed.ID }
                    },
                    new CombinedEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificWeaponCategoryProficiencyEffect { Id = Guid.Parse(""), ProficiencyId = Proficiencies.Instances.Expert.ID, WeaponCategoryId = WeaponCategories.Instances.Simple.ID }
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
                Page = 157
            };
        }
    }
}
