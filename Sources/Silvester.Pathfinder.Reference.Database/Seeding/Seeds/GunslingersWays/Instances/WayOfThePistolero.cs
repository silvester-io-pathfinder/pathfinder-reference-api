using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.GunslingersWays.Instances
{
    public class WayOfThePistolero : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override GunslingersWay GetGunslingersWay()
        {
            return new GunslingersWay
            {
                Id = ID, 
                Name = "Way of the Pistolero",
                InitialDeedId = Feats.Instances.TenPaces.ID,
                AdvancedDeedId = Feats.Instances.PistolerosRetort.ID,
                GreaterDeedId = Feats.Instances.GrimSwagger.ID,
                SlingersReloadId = Feats.Instances.RaconteursReload.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Whether you're a professional duelist or a pistol-twirling entertainer, you have quick feet and quicker hands that never seem to let you down, and an equally sharp wit and tongue that jab your foes. You might leave a hand free or cultivate the ambidexterity for twin weapons. Either way, you stay close enough to your enemies to leverage your superior reflexes while leaving enough space to safely fire." };
        }

        protected override IEnumerable<Guid> GetWaySkills()
        {
            yield return Skills.Instances.Deception.ID;
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.RaconteursReload.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.TenPaces.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.PistolerosRetort.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 9);
                });

            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.GrimSwagger.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });

            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 109
            };
        }
    }
}
