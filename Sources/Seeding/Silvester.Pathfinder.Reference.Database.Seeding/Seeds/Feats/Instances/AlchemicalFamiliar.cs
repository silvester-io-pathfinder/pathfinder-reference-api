using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemicalFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("c319fd8f-f0aa-47c6-987e-5e962569a13f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alchemical Familiar",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4a799a15-2d76-454f-a6d6-17e567acde5b"), Type = TextBlockType.Text, Text = "You have used alchemy to create life, a simple creature formed from alchemical materials, reagents, and a bit of your own blood. This alchemical familiar appears to be a small creature of flesh and blood, though it might have some unusual or distinguishing aspects depending on your creative process. Like other familiars, your alchemical familiar assists you in your laboratory and on adventures. The familiar uses your Intelligence modifier to determine its Perception, Acrobatics, and Stealth modifiers (see Familiars on page 217 for more information)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49cc44f5-e433-4192-914e-1463fb83769e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
