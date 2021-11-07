using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DemolitionCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("3fd16eaf-7abe-4568-bb81-d42a6ba6be55");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demolition Charge",
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
            yield return new TextBlock { Id = Guid.Parse("c2e284a9-3cc7-4ca7-bf2d-e3a35617c12e"), Type = TextBlockType.Text, Text = "You can rig your bombs to inanimate objects in order to cause destruction to the surrounding area. As an activity that takes 1 minute, you attach between one and four bombs to an inanimate object within your reach, such as a chest, door, wall, or column. This creates a hazard in one square occupied by or adjacent to the inanimate object, and the hazard’s Stealth DC to detect it and Thievery DC to disable it are equal to your class DC. The hazard has the following reaction, which you can also trigger as a single action so long as you are within 30 feet of the hazard. The hazard retains its potency until it’s triggered, until the inanimate object moves from its space, or until you make your next daily preparations, whichever comes first. You gain the (feat: Fire in the Hole) reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78854ca6-8c3d-4c04-a57b-e3729dff7e16"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
