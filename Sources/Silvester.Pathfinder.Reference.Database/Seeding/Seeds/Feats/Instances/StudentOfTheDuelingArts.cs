using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StudentOfTheDuelingArts : Template
    {
        public static readonly Guid ID = Guid.Parse("c2e27cc6-e375-4cb7-a922-5ffc23827e6a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Student of the Dueling Arts",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e91e4dc-d914-4134-9c96-9a7486e91104"), Type = TextBlockType.Text, Text = "You have studied a great many combat techniques, which you can review each day. During your daily preparations, you can swap out any number of your duelist archetype feats for other duelist archetype feats of the appropriate level for which you are qualified. You can’t swap out (feat: Duelist Dedication) or Student of the Dueling Arts in this way." };
            yield return new TextBlock { Id = Guid.Parse("70cc566b-fa7f-451d-a418-55ede76f1c25"), Type = TextBlockType.Text, Text = "In addition, you can enter a stance from a duelist archetype feat you don’t have by increasing the number of actions it takes to enter the stance by 1 (typically to 2 actions). You must still meet the feat’s prerequisites." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2789d817-cb93-45be-8805-2535e55ae7a1"), Feats.Instances.DuelistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b368c5a-9d20-417c-8332-879e9afda69b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
