using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BonMot : Template
    {
        public static readonly Guid ID = Guid.Parse("fa6935e8-8015-4303-b43f-8098b2f27e1e");

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
            yield return new TextBlock { Id = Guid.Parse("b66cd4cc-edc8-4cc1-8b9f-fd3ef4d77139"), Type = TextBlockType.Text, Text = "You launch an insightful quip at a foe, distracting them. Choose a foe within 30 feet and roll a Diplomacy check against the target’s Will DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c57630d8-2283-4ac3-a646-ede47c9eb651"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("d36b0a05-e348-4df2-b820-b6e08546895e"),
                CriticalSuccess = "The target is distracted and takes a -3 status penalty to Perception and Will saves for 1 minute. The target can end the effect early with a retort to your Bon Mot. This can either be a single action that has the (trait: concentrate) trait or an appropriate skill action to frame their retort. The GM determines which skill actions qualify, though they must take at least 1 action. Typically, the retort needs to use a (trait: linguistic) Charisma-based skill action.",
                Success = "As critical success, but the penalty is -2.",
                
                CriticalFailure = "Your quip is atrocious. You take the same penalty an enemy would take had you succeeded. This ends after 1 minute or if you issue another Bon Mot and succeed.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9bfc44b-b902-4f54-881d-dccaaba4ecf8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
