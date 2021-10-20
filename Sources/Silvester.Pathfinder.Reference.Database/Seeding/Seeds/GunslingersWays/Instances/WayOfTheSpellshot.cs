using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.GunslingersWays.Instances
{
    public class WayOfTheSpellshot : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override GunslingersWay GetGunslingersWay()
        {
            return new GunslingersWay
            {
                Id = ID, 
                Name = "Way of the Spellshot",
                InitialDeedId = Feats.Instances.EnergyShot.ID,
                AdvancedDeedId = Feats.Instances.RecallAmmunition.ID,
                GreaterDeedId = Feats.Instances.DispellingBullet.ID,
                SlingersReloadId = Feats.Instances.ThoughtfulReload.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You've learned the intricacies of magic and technology, blending the two together with deadly results. You combine a knowledge of arcane theories with a strong connection to your chosen weapon that allows you to manifest unique effects, though your knowledge doesn't extend as far as actual spellcasting. You can imbue energy into your weapon and conjure bullets from thin air. As you progress, you eventually learn to phase bullets through walls or even to teleport yourself along the path of your bullets." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You must select Spellshot Dedication from the Spellshot archetype as your 2nd-level class feat." };

            //TODO: Encapsulate the forced 2nd-level class feat pick somehow.
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificClassPrerequisite
            {
                Id = Guid.Parse(""),
                RequiredClassId = Classes.Instances.Gunslinger.ID
            };
        }

        protected override IEnumerable<Guid> GetWaySkills()
        {
            yield return Skills.Instances.Arcana.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.ThoughtfulReload.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.EnergyShot.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.RecallAmmunition.ID,
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
                FeatId = Feats.Instances.DispellingBullet.ID,
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
                SkillId = Skills.Instances.Arcana.ID,
                ProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 140
            };
        }
    }
}
