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
    public class StudentOfTheDuelingArts : Template
    {
        public static readonly Guid ID = Guid.Parse("514b1f16-cca4-475d-99e8-d9c024fe6f74");

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
            yield return new TextBlock { Id = Guid.Parse("ab6bfb38-72cb-4776-a726-655f35e5467c"), Type = TextBlockType.Text, Text = $"You have studied a great many combat techniques, which you can review each day. During your daily preparations, you can swap out any number of your duelist archetype feats for other duelist archetype feats of the appropriate level for which you are qualified. You can't swap out {ToMarkdownLink<Models.Entities.Feat>("Duelist Dedication", Feats.Instances.DuelistDedication.ID)} or Student of the Dueling Arts in this way." };
            yield return new TextBlock { Id = Guid.Parse("3b909dcc-e0fb-4fd0-abd4-3bab98d45b32"), Type = TextBlockType.Text, Text = $"In addition, you can enter a stance from a duelist archetype feat you don't have by increasing the number of actions it takes to enter the stance by 1 (typically to 2 actions). You must still meet the feat's prerequisites." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2718e8a3-6b8f-4b1b-a669-e4620583a764"), Feats.Instances.DuelistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("648ade69-08f7-4491-b4d3-7ddff07c1b83"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
