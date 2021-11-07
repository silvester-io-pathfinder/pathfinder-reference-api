using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AxialRecall : Template
    {
        public static readonly Guid ID = Guid.Parse("4d8e0708-3bbd-41c9-99ba-99721c3c6ae2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Axial Recall",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de913cae-446b-4e3f-a882-6dfb373761dd"), Type = TextBlockType.Text, Text = "You have reconfigured the magical resonance of your core to attune to the planar energies of Axis. You can cast (spell: plane shift) twice per week as an arcane innate spell that can only target yourself; you can travel only to Axis or the Material Plane, and your body serves as the focus component." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f26e448-6a02-4ef9-ac73-5b08dde12a25"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
