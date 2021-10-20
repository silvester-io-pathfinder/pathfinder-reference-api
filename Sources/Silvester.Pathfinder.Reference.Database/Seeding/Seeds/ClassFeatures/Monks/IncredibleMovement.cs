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
    public class IncredibleMovement : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Incredible Movement", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You move like the wind. You gain a +10-foot status bonus to your Speed whenever you’re not wearing armor. The bonus increases by 5 feet for every 4 levels you have beyond 3rd." };
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
                        Prerequisite = new HaveCurrentArmorCategoryPrerequisite
                        {
                            Id = Guid.Parse(""),
                            ArmorCategoryId = ArmorCategories.Instances.Unarmored.ID
                        }
                    }
                },
                Entries = new[]
                { 
                    CreateSpeedModifierEffect(10, 3, new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), }),
                    CreateSpeedModifierEffect(5, 7 , new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), }),
                    CreateSpeedModifierEffect(5, 11, new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), }),
                    CreateSpeedModifierEffect(5, 15, new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), }),
                    CreateSpeedModifierEffect(5, 19, new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), }),
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }

        private static CombinedEffectBinding CreateSpeedModifierEffect(int modifier, int fromLevel, Guid[] ids)
        {
            return new CombinedEffectBinding
            {
                Id = ids[0],
                Effect = new ModifySpeedEffect
                {
                    Id = ids[1],
                    Modifier = modifier,
                    ModifierType = ModifierType.Add,
                    Prerequisites = new[]
                    {
                        new EffectPrerequisiteBinding
                        {
                            Id = ids[2],
                            Prerequisite = new HaveSpecificLevelPrerequisite
                            {
                                Id = ids[3],
                                Comparator = Comparator.GreaterThanOrEqualTo,
                                RequiredLevel = fromLevel
                            }
                        }
                    }
                }
            };
        }
    }
}
