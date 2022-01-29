using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NoCauseForAlarm : Template
    {
        public static readonly Guid ID = Guid.Parse("027b78fb-6eb2-4273-925a-b85da5767dc3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "No Cause for Alarm",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5e5f2ae-88b1-484e-a312-a3333b537f85"), Type = TextBlockType.Text, Text = $"You attempt to reduce panic. Attempt a Diplomacy check, comparing it to the Will DC of creatures in a 10-foot emanation around you who are frightened. Each of them is temporarily immune for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("820e1632-7a9f-4e16-a232-a02859a91c38"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Linguistic.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("d5fbd5d7-3c21-44af-8d83-6488e176c1be"),
                CriticalSuccess = "Reduce the creature's frightened value by 2.",
                Success = "Reduce the creature's frightened value by 1.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ae442ad-98b3-45be-b6d4-708f95a25003"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
