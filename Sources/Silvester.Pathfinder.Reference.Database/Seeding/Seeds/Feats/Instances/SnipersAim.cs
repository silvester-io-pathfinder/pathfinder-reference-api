using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnipersAim : Template
    {
        public static readonly Guid ID = Guid.Parse("f7370536-92f0-4920-a787-03c9b84f798d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sniper's Aim",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a58ad8d3-bfbd-4050-93b9-dc3d7a5c75fd"), Type = TextBlockType.Text, Text = "You take an extra moment to carefully sync your aim and breathing, then fire a shot with great accuracy. Make a ranged weapon (action: Strike). You gain a +2 circumstance bonus to this (action: Strike’s|Strike) attack roll and ignore the target’s concealment. If you’re using a (trait: kickback) firearm, you don’t take the normal circumstance penalty on this (action: Strike) for not having the required Strength score or firing without using a stabilizer." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("cfccc6ef-6034-41f1-9e3d-1a3bf6fa6995"), GunslingerWays.Instances.WayOfTheSniper.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3db4683c-3ee4-4bcd-a5a2-16d09de54d05"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
