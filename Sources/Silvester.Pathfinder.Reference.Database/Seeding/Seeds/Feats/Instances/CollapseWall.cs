using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CollapseWall : Template
    {
        public static readonly Guid ID = Guid.Parse("281f82a9-5ca3-452f-bbb4-4e32256f10ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Collapse Wall",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature moves into the bombs' splash area.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8ba361b-9adc-474c-a8fa-c155d2a7d27d"), Type = TextBlockType.Text, Text = "You detonate the required bombs in order to bring a wall down on a creature. If your bombs deal enough damage to reduce the wall’s Hit Points below its Broken Threshold, the wall partially collapses on the creature. The creature takes bludgeoning damage equal to the damage dealt to the wall (basic Reflex save; the DC for this save is equal to your class DC or spell DC, whichever is higher). On a failure, they must spend an Interact action to dig themselves out of the collapse, and on a critical failure, they must spend 2 Interact actions to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ffd1baa5-fccc-478a-9a1f-74fd393eb269"), Feats.Instances.DemolitionistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46f6446b-2c2b-4436-bc7b-f1645168e13b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
