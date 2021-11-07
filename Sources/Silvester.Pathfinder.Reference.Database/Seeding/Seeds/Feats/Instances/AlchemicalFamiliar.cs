using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemicalFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("4c342681-c86d-4c0c-8e6f-ecf2e62f179d");

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
            yield return new TextBlock { Id = Guid.Parse("96837519-91cf-43b4-83bf-c53eddeaa593"), Type = TextBlockType.Text, Text = "You have used alchemy to create life, a simple creature formed from alchemical materials, reagents, and a bit of your own blood. This alchemical familiar appears to be a small creature of flesh and blood, though it might have some unusual or distinguishing aspects depending on your creative process. Like other familiars, your alchemical familiar assists you in your laboratory and on adventures. The familiar uses your Intelligence modifier to determine its Perception, Acrobatics, and Stealth modifiers (see Familiars on page 217 for more information)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0363f576-3271-4bbc-93fc-ded8492baed0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
