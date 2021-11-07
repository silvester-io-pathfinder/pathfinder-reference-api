using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutomatonArmamentPincer : Template
    {
        public static readonly Guid ID = Guid.Parse("7afea90d-18d8-4ae3-82ba-aa11f4aeb5de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Automaton Armament - Pincer",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2e9bf91-f2c2-4af2-af88-0be33bc7bae1"), Type = TextBlockType.Text, Text = "You gain a pincer unarmed attack which deals 1d6 piercing damage, is in the brawling group, and has the (trait: grapple) and (trait: unarmed) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c104d51-84b1-4540-ad1d-fac14841bcbe"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
