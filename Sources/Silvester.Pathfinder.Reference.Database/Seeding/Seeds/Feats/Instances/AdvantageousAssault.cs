using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvantageousAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("7b24771b-892d-4635-8fbc-a000267a9d0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advantageous Assault",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b22d2347-9f63-434d-bc55-55f2b59f401b"), Type = TextBlockType.Text, Text = "When an enemy’s movement is compromised, you deliver a more deadly blow. Make a (Action: Strike) against a creature that is grabbed, prone, or restrained. You gain a circumstance bonus to damage on this (Action: Strike) equal to the number of weapon damage dice, or that number + 2 if you’re wielding the weapon in two hands. The (Action: Strike) gains the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("4fb1eb11-272e-4b29-8cf1-64d16c5ff19b"),
                
                
                Failure = "You deal damage to the target equal to the number of weapon damage dice, or that number + 2 if you’re wielding the weapon in two hands. This damage has the same damage type as the weapon.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("285a31df-89a8-4ea4-8825-c67104aeaf53"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
