using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutonomicTelekinesis : Template
    {
        public static readonly Guid ID = Guid.Parse("7b0c706f-afb3-44f5-913d-e3a8a34cdc02");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Autonomic Telekinesis",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c6715c3d-0ce3-4a88-a46d-e913e989f35a"), Type = TextBlockType.Text, Text = "You can move objects even without casting a specific spell. You can telekinetically perform simple (action: Interact) actions within squares adjacent to you, such as opening a door. You can’t perform actions that require significant manual dexterity, including any action that would require a check to accomplish, and you can’t use it to hold items, though you can use an (action: Interact) action to telekinetically draw a nearby item to a hand to hold it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94ae3f25-b9d4-4b8d-a610-d584c87bcf7c"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
