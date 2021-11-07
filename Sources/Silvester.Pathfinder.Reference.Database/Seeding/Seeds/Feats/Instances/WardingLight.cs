using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardingLight : Template
    {
        public static readonly Guid ID = Guid.Parse("e259c7f1-976c-4786-8a3f-104783826ca0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warding Light",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e4ccc8f-b02c-44ae-8c6c-dff09cfd08df"), Type = TextBlockType.Text, Text = "You gain a tattoo that serves as a special ward to defend you against Walkena’s forces. The tattoo allows you to cast the (spell: light) cantrip as a divine innate spell at will. The cantrip is heightened to a spell level equal to half your level rounded up. If you die, the tattoo immediately casts (spell: gentle repose) on your corpse, heightened to the same spell level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("af93dbd3-e156-4d42-bd95-ad28b96071f9"), Feats.Instances.BrightLionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0298355-100f-45be-92d4-b1cc07be0f19"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
