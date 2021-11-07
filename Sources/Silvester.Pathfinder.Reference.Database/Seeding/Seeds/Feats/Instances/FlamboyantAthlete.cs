using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlamboyantAthlete : Template
    {
        public static readonly Guid ID = Guid.Parse("cbb6ec13-ffad-4f8d-9c41-eef91db6358c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flamboyant Athlete",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46084bc3-2df5-441d-a199-a14c701f06f4"), Type = TextBlockType.Text, Text = "Your panache allows you to perform incredible feats: climbing, swimming, and leaping far beyond your normal capacity. While you have panache, you gain the following benefits." };
            yield return new TextBlock { Id = Guid.Parse("13ecae8e-9c3a-4dc7-8a75-a0241e68c45f"), Type = TextBlockType.Enumeration, Text = " : You gain climb and swim Speeds equal to half your land Speed." };
            yield return new TextBlock { Id = Guid.Parse("372e0417-1ad8-426e-a1f2-07806b9e9f0c"), Type = TextBlockType.Enumeration, Text = " : The DCs of your (action: High Jumps | High Jump) and (action: Long Jumps | Long Jump) decrease by 10. This doesn’t combine with other abilities that reduce those DCs." };
            yield return new TextBlock { Id = Guid.Parse("4296ee87-188b-48f9-b0c3-9d965b07a976"), Type = TextBlockType.Enumeration, Text = " : The distance you can move with a vertical (action: Leap) increases to 5 feet. Your distance for a horizontal (action: Leap) increases to 15 feet if your Speed is at least 15 feet, or to 20 feet if your Speed is at least 30 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("deab59c9-feee-497e-b66c-7e97b4a01bb3"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bdeec46-38f8-432b-b66b-eb25c3a47b9e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
