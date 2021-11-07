using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutonomicTelepathy : Template
    {
        public static readonly Guid ID = Guid.Parse("76e1090d-7ca7-46a0-bf64-00c0f3e86d4d");

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
            yield return new TextBlock { Id = Guid.Parse("7c0fb529-0f23-40a3-b5f0-7d3613d0937c"), Type = TextBlockType.Text, Text = "You can use your mind to communicate at all times. You can communicate mentally with any creatures within a 15-foot aura as long as you share a language. This doesn’t give any special access to their thoughts and communicates no more information than normal speech would. The communication is two-way." };
            yield return new TextBlock { Id = Guid.Parse("9bf51968-c07e-4908-9b9e-dc284a7ae800"), Type = TextBlockType.Text, Text = "In addition, when communicating via any form of telepathy, you gain a +1 circumstance bonus to Perception when attempting to (action: Sense Motive) or detect a (action: Lie)." };
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
                Id = Guid.Parse("ebf7c03a-b027-4266-b203-f46e51bc0e86"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
