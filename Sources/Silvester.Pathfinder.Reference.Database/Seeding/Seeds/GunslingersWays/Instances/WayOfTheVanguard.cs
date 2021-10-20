using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.GunslingersWays.Instances
{
    public class WayOfTheVanguard : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override GunslingersWay GetGunslingersWay()
        {
            return new GunslingersWay
            {
                Id = ID, 
                Name = "Way of the Vanguard",
                InitialDeedId = Feats.Instances.LivingFortification.ID,
                AdvancedDeedId = Feats.Instances.SpinningCrush.ID,
                GreaterDeedId = Feats.Instances.GreaterSiegebreaker.ID,
                SlingersReloadId = Feats.Instances.ClearAPath.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You practice a unique combat style originated by dwarven siege engineers, using heavy weapons with wide attack areas to blast holes through enemy lines, clear an opening for your allies, and defend the conquered territory." };
        }

        protected override IEnumerable<Guid> GetWaySkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.LivingFortification.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.SpinningCrush.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 9
                        }
                    }
                }
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.GreaterSiegebreaker.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificLevelPrerequisite
                        {
                            Id = Guid.Parse(""),
                            Comparator = Comparator.GreaterThanOrEqualTo,
                            RequiredLevel = 15
                        }
                    }
                }
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.ClearAPath.ID
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse(""),
                SkillId = Skills.Instances.Athletics.ID,
                ProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 110
            };
        }
    }
}
