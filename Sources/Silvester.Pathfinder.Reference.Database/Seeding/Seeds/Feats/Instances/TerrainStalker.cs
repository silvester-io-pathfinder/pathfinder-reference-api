using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TerrainStalker : Template
    {
        public static readonly Guid ID = Guid.Parse("6e0038b4-676b-492d-a9e8-26737b0874b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terrain Stalker",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times. Each time, choose a different type of terrain.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46443d0f-c239-48dd-ae9f-149aaeeceaf7"), Type = TextBlockType.Text, Text = "Select one type of difficult terrain from the following list: rubble, snow, or underbrush. While undetected by all non-allies in that type of terrain, you can (Action: Sneak) without attempting a Stealth check as long as you move no more than 5 feet and do not move within 10 feet of an enemy at any point during your movement. This also allows you to automatically approach creatures to within 15 feet while (Activity: Avoiding Notice | Avoid Notice) during exploration as long as they aren’t actively (Activity: Searching | Search) or on guard." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1bcd6a9c-9bb0-4b33-8291-74c2ba73955a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27dc459f-826b-41b8-b15d-f00875e100b1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
