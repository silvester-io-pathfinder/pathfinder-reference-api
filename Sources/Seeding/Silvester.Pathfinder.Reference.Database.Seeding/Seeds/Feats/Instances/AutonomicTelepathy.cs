using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutonomicTelepathy : Template
    {
        public static readonly Guid ID = Guid.Parse("db816e92-e0b5-419d-95b8-d93cec8b2718");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Autonomic Telepathy",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("574152a6-a88f-4f70-a15a-4b1b8447655f"), Type = TextBlockType.Text, Text = "You can use your mind to communicate at all times. You can communicate mentally with any creatures within a 15-foot aura as long as you share a language. This doesn’t give any special access to their thoughts and communicates no more information than normal speech would. The communication is two-way." };
            yield return new TextBlock { Id = Guid.Parse("2c49afba-fc0f-412b-ab50-c5143f145fec"), Type = TextBlockType.Text, Text = "In addition, when communicating via any form of telepathy, you gain a +1 circumstance bonus to Perception when attempting to (action: Sense Motive) or detect a (action: Lie)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5825a083-89ff-4634-9564-18cce850f2bf"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
