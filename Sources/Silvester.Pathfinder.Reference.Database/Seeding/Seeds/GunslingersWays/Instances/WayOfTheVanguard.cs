using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

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
                GreaterDeedId = Feats.Instances.Siegebreaker.ID,
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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.LivingFortification.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ClearAPath.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.SpinningCrush.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 9);
                });

            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Siegebreaker.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
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
