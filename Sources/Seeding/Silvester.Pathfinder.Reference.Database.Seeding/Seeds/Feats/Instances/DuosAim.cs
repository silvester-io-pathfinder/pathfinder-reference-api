using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuosAim : Template
    {
        public static readonly Guid ID = Guid.Parse("03fd525b-5630-419f-a9ee-b9642cefd955");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Duo's aim",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("36f649d9-7e71-4ca4-8806-877284875725"), Type = TextBlockType.Text, Text = "With assistance from your spotter, you aim for an especially accurate attack. Make a ranged weapon (action: Strike) against a foe either within your spotter's melee reach or the first range increment of a ranged weapon your spotter is wielding. On this (action: Strike), you gain a +2 circumstance bonus to the attack roll and ignore the target's concealment. If you're using a firearm with the (trait: kickback) trait, you don't take the normal circumstance penalty to this (action: Strike) for not having the required Strength score or firing without using a (item: tripod)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cfe8dc7c-8e6a-4183-8bc9-9b0f7bec8d5d"), Feats.Instances.SnipingDuoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a40e98f-dcc5-40ce-8309-8a04535a711f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
