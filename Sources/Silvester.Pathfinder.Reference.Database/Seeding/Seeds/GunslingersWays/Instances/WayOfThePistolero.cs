using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
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
                AdvancedDeedId = Feats.Instances.PistolersRetort.ID,
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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.RaconteursReload.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.TenPaces.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.PistolersRetort.ID,
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
                FeatId = Feats.Instances.GrimSwagger.ID,
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

            yield return new ChoiceEffect
            {
                Id = Guid.Parse(""),
                Entries = new []
                {
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSkillProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            SkillId = Skills.Instances.Deception.ID,
                            ProficiencyId = Proficiencies.Instances.Trained.ID
                        }
                    },
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new GainSpecificSkillProficiencyEffect
                        {
                            Id = Guid.Parse(""),
                            SkillId = Skills.Instances.Intimidation.ID,
                            ProficiencyId = Proficiencies.Instances.Trained.ID
                        }
                    },
                }
            };
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
