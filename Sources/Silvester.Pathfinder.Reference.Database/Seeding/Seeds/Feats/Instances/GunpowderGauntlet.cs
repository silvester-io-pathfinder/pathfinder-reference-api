using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GunpowderGauntlet : Template
    {
        public static readonly Guid ID = Guid.Parse("897e04b4-fc8d-41d8-9402-57b64ff7645e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gunpowder Gauntlet",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06715b81-e189-4799-9211-c555fe290ba5"), Type = TextBlockType.Text, Text = "Your flair keeps foes’ attention, as your motions with your gun draw your foes into a deadly game. As you toy with them and performatively brandish your weapon, you build their tunnel vision, leaving them trapped in a perceptual gauntlet of your own making. Attempt a Performance check against the Will DC of a single target within your one-handed firearm’s first range increment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("41f5fcef-8002-4654-960c-f9f48ce18086"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("01b83620-49c2-4b9c-aa50-52dc2f970f25"),
                CriticalSuccess = "The target takes a –2 status penalty to attack rolls against creatures other than you until the beginning of your next turn.",
                Success = "The target takes a –1 status penalty to attack rolls against creatures other than you until the beginning of your next turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9777644d-0591-451c-a6e3-03bc906c6ee0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
