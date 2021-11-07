using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BonMot : Template
    {
        public static readonly Guid ID = Guid.Parse("5421ab09-8881-4d7c-851c-12e303b613e0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bon Mot",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3bd90e53-48af-4d87-a5d3-287265421647"), Type = TextBlockType.Text, Text = "You launch an insightful quip at a foe, distracting them. Choose a foe within 30 feet and roll a Diplomacy check against the target’s Will DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("601f02fc-c9e7-4e91-9246-df63a2cf88b1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("5cb58145-6efd-434b-bf73-00daf1fe903b"),
                CriticalSuccess = "The target is distracted and takes a -3 status penalty to Perception and Will saves for 1 minute. The target can end the effect early with a retort to your Bon Mot. This can either be a single action that has the (trait: concentrate) trait or an appropriate skill action to frame their retort. The GM determines which skill actions qualify, though they must take at least 1 action. Typically, the retort needs to use a (trait: linguistic) Charisma-based skill action.",
                Success = "As critical success, but the penalty is -2.",
                
                CriticalFailure = "Your quip is atrocious. You take the same penalty an enemy would take had you succeeded. This ends after 1 minute or if you issue another Bon Mot and succeed.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e31df51-0146-416a-92c2-32ffa67adbc0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
