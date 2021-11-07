using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LitanyOfSelfInterest : Template
    {
        public static readonly Guid ID = Guid.Parse("ea4a46f1-1539-42dd-af33-213908282583");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Litany of Self-Interest",
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
            yield return new TextBlock { Id = Guid.Parse("3668ea9d-af26-41c5-bd00-2d0af15cc456"), Type = TextBlockType.Text, Text = "You compel a creature to act toward its own ends rather than consider others. You can cast the (spell: litany of self-interest) devotion spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("fa45bff3-83e6-4cbb-9259-ba01c9baa51b"), Classes.Instances.Champion.ID);
            builder.HaveSpecificTenet(Guid.Parse("eb43499e-13ec-4118-99e9-1564392d6501"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c40cab77-cf87-4b6e-b45d-0eb53c6c506a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
