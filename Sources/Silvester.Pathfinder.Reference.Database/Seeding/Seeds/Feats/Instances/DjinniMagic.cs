using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DjinniMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("d475872d-ef68-4be6-9fe6-328b84139628");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Djinni Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6762e8d6-8d9c-4d8a-b276-71ed8e4f69de"), Type = TextBlockType.Text, Text = "The magic of djinn runs through your blood. You can cast (spell: gust of wind) and (spell: invisibility) once per day each as 2nd-level arcane innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c99409b-6664-4d0b-a063-8963d38a65fd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
