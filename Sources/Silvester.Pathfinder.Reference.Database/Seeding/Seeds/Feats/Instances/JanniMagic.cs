using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JanniMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("ca7ab7bb-33c4-4ff7-a6e3-7e2b5c6d6582");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Janni Magic",
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
            yield return new TextBlock { Id = Guid.Parse("c4f60038-cf95-41fb-9c6d-8e1f03300e0b"), Type = TextBlockType.Text, Text = "The magic of jann runs through your blood. You can cast (spell: enlarge) and (spell: speak with animals) once per day each as 2nd-level arcane innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43a26348-db12-4bad-aab9-17c8565c88f5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
