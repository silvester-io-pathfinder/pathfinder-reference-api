using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DemolitionCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("8c814ef3-90ac-4ade-909d-7b4a4b545a9e");

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
            yield return new TextBlock { Id = Guid.Parse("da23c6de-e04c-4895-ba05-fd14080a3632"), Type = TextBlockType.Text, Text = "You can rig your bombs to inanimate objects in order to cause destruction to the surrounding area. As an activity that takes 1 minute, you attach between one and four bombs to an inanimate object within your reach, such as a chest, door, wall, or column. This creates a hazard in one square occupied by or adjacent to the inanimate object, and the hazard's Stealth DC to detect it and Thievery DC to disable it are equal to your class DC. The hazard has the following reaction, which you can also trigger as a single action so long as you are within 30 feet of the hazard. The hazard retains its potency until it's triggered, until the inanimate object moves from its space, or until you make your next daily preparations, whichever comes first. You gain the (feat: Fire in the Hole) reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73babe6e-bf71-4858-b967-0f67b97283d6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
