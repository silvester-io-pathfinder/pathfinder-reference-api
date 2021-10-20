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
    public class WayOfTheDrifter : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override GunslingersWay GetGunslingersWay()
        {
            return new GunslingersWay
            {
                Id = ID, 
                Name = "Way of the Drifter",
                InitialDeedId = Feats.Instances.IntoTheFray.ID,
                AdvancedDeedId = Feats.Instances.FinishTheJob.ID,
                GreaterDeedId = Feats.Instances.DriftersWake.ID,
                SlingersReloadId = Feats.Instances.ReloadingStrike.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You're a wanderer traveling from land to land with your gun and a melee weapon as company. Maybe you learned to fight with blade and pistol as a Shackles pirate, mastered the hand cannon and katana in Minkai, or practiced with a hatchet and clan pistol in Dongun Hold. You win battles by relying on mobility and flexible use of your weapons." };
        }

        protected override IEnumerable<Guid> GetWaySkills()
        {
            yield return Skills.Instances.Acrobatics.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.ReloadingStrike.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.IntoTheFray.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.FinishTheJob.ID,
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
                FeatId = Feats.Instances.DriftersWake.ID,
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

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse(""),
                SkillId = Skills.Instances.Acrobatics.ID,
                ProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 108
            };
        }
    }
}
