using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

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

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        {
            builder.HaveSpecificClass(Guid.Parse(""), Classes.Instances.Gunslinger.ID);
        }

        protected override IEnumerable<Guid> GetWaySkills()
        {
            yield return Skills.Instances.Arcana.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ThoughtfulReload.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.EnergyShot.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.RecallAmmunition.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 9);
                });

            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.DispellingBullet.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
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
