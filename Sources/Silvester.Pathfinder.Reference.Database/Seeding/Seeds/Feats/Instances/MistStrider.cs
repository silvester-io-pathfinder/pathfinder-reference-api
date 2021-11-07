using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MistStrider : Template
    {
        public static readonly Guid ID = Guid.Parse("08e32983-4811-4a55-9591-db43d3368030");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mist Strider",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9920547-08a3-49ea-8502-09a465b5e4dd"), Type = TextBlockType.Text, Text = "You condense the moisture in the air, solidifying it so it can hold your weight. When you use (feat: Water Strider), you can walk on air. You can ascend and descend at a maximum of a 45-degree angle. You still fall at the end of your movement if you don’t end on a surface that can support you, as normal for (feat: Water Strider)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6bec818b-6224-4e3e-aea1-b665c8f1192f"), Feats.Instances.WaterStrider.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("919eabe2-7e58-40e9-82bd-e8f69c175d73"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
