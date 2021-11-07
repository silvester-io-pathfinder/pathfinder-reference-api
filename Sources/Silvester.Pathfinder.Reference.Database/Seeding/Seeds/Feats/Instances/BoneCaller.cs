using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoneCaller : Template
    {
        public static readonly Guid ID = Guid.Parse("37f4f49e-e7bd-4856-9d34-1b25c4a205ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bone Caller",
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
            yield return new TextBlock { Id = Guid.Parse("065abe5a-5ec3-4862-915d-8018cda2a6ec"), Type = TextBlockType.Text, Text = "Using a mixture of dinosaur bones and the bones of your ancestors to focus your magic, you animate lizards and dinosaurs to carry messages or serve as mounts. You can cast (spell: animal messenger) and (spell: phantom steed) as primal innate spells once per day each. The animal messenger is always a Tiny dinosaur or lizard, and your innate spell transforms it from bones to flesh, even if there are no dinosaurs or lizards nearby. The phantom steed looks like a dinosaur rather than a horse but functions identically." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1783d6fe-7d6f-4e29-831c-d2af3378bd25"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
