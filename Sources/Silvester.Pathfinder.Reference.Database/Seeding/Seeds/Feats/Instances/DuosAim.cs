using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuosAim : Template
    {
        public static readonly Guid ID = Guid.Parse("91adcdc7-d25a-4d7d-86b3-39c3b698d27b");

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
            yield return new TextBlock { Id = Guid.Parse("e1596232-67c8-4904-a589-4ed0b3824756"), Type = TextBlockType.Text, Text = "With assistance from your spotter, you aim for an especially accurate attack. Make a ranged weapon (action: Strike) against a foe either within your spotter’s melee reach or the first range increment of a ranged weapon your spotter is wielding. On this (action: Strike), you gain a +2 circumstance bonus to the attack roll and ignore the target’s concealment. If you’re using a firearm with the (trait: kickback) trait, you don’t take the normal circumstance penalty to this (action: Strike) for not having the required Strength score or firing without using a (item: tripod)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d0d94253-a04d-4ce6-ac82-ad2a455fbbfc"), Feats.Instances.SnipingDuoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d338618-e94c-453c-a244-642c1cf7d3c4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
