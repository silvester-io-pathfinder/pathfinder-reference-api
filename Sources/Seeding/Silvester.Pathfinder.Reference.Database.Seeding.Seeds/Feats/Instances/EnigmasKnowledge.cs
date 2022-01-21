using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnigmasKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("393f822b-beea-47e6-a6ab-5ec39423786b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enigma's Knowledge",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79aa4ca5-9642-496f-a7ab-6b4cfb2b705f"), Type = TextBlockType.Text, Text = "Your muse whispers knowledge to you at all the right times. You gain the benefits of the (feat: Automatic Knowledge) skill feat with any skill you can use to (action: Recall Knowledge). As per the special clause in the (feat: Automatic Knowledge) feat, you can still only use (feat: Automatic Knowledge) once per round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c1899a67-6bde-4ae3-a813-0465d39c8ac4"), Feats.Instances.AssuredKnowledge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76f47a55-490c-407b-b51e-f33585ceb7b1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
