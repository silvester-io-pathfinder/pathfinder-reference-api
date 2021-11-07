using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PreciousArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("c35b5148-a303-449f-931d-3c5f34dcc530");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Precious Arrow",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("632c6e5e-5a31-4431-9e79-425e64c15d1e"), Type = TextBlockType.Text, Text = "You enchant a piece of ammunition with the magical essence of a precious material, allowing you to leverage certain creatures’ weaknesses. Choose cold iron or silver; if you shoot the arrow before the end of your turn, it counts as that material. At 14th level, add adamantine to the list of materials you can choose from." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0324d345-1afd-4eca-a3f4-aa09d246b60a"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("280ab175-d1cc-464b-a9e9-1e4253ba594a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
