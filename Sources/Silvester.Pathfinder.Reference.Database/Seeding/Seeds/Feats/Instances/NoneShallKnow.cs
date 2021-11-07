using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NoneShallKnow : Template
    {
        public static readonly Guid ID = Guid.Parse("39674dda-099e-46c3-88d3-8f2797586546");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "None Shall Know",
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
            yield return new TextBlock { Id = Guid.Parse("9d9f3fa9-ecc1-4115-b322-3b7e1859b664"), Type = TextBlockType.Text, Text = "Even magical means have a hard time prying information from you. You gain (spell: nondetection) as an innate occult spell once per day, which can only be cast on yourself and is automatically heightened to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81163cdb-e6af-4c0f-b71e-9092808602a4"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
