using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LongTongue : Template
    {
        public static readonly Guid ID = Guid.Parse("17fdd32a-3db6-4612-b9e2-cf7418752196");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Long Tongue",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7976ead8-1556-43b3-bf5f-fc8867014bec"), Type = TextBlockType.Text, Text = "You’ve learned to stretch your exceptionally long tongue beyond its original limits. When you use your tongue to deliver touch range spells or perform very simple (action: Interact) actions, you can do so at a distance that is 5 feet beyond your usual reach." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("fcd62cd2-7381-465e-8498-753f9c8bf92a"), Heritages.Instances.SnaptongueGrippli.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72c7c98f-6c7d-4ffe-aa0f-a7a4b33bf6e8"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
