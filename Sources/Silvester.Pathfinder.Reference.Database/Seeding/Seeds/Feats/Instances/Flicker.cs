using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Flicker : Template
    {
        public static readonly Guid ID = Guid.Parse("f7af18df-fe81-428d-9c2c-db6ed38d767a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flicker",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c73b086d-8b5a-4b34-991c-8833ef516ddf"), Type = TextBlockType.Text, Text = "You use your movements and disguises to make yourself a flickering blur. You become concealed until your next turn. As usual for becoming concealed involving an obvious visual manifestation, you can’t use this concealment to (action: Hide)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("28a5578f-509b-474a-9257-0276e30d6514"), Feats.Instances.LionBladeDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0101c9fb-0a18-44f8-8061-8b89cda684fb"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
