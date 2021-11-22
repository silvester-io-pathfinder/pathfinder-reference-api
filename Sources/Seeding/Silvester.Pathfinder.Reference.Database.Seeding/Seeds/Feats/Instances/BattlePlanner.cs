using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BattlePlanner : Template
    {
        public static readonly Guid ID = Guid.Parse("39d3cf19-32bb-4241-adfb-1d3b91f4c079");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Battle Planner",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5b5371c-0e9c-43f4-8929-34a7a77b8d52"), Type = TextBlockType.Text, Text = "You are constantly drawing up plans and battle scenarios, assembling strategies and gathered intelligence for later use. When you scout an enemy's position or receive a detailed report from an ally who scouted the enemy's position, if you have a clear indication of the number, position, and identities of your potential foes, you can spend 1 minute to come up with a battle plan that takes such potential factors into account and reduces the role luck plays in the equation. Roll a Warfare Lore check. As long as the information was accurate and remains accurate when you roll initiative against those enemies, you can use the Warfare Lore result you previously rolled for your initiative roll; if you do, this is a (trait: fortune) effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificLoreSpecificProficiency(Guid.Parse("d0e735fd-3acc-45fa-8b54-6f793c5bb8d8"), Proficiencies.Instances.Expert.ID, Lores.Instances.Warfare.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae1ac165-e3ba-4819-8c9f-93fd5587ec77"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
