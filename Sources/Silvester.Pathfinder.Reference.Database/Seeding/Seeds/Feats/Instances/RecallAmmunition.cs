using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecallAmmunition : Template
    {
        public static readonly Guid ID = Guid.Parse("81a68198-7d4c-47ff-9468-2f634e4c9bbc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recall Ammunition",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You miss with a firearm or crossbow Strike while using an ordinary level-0 bolt or bullet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("468384a3-0c6d-44b2-846c-9375bfc8d905"), Type = TextBlockType.Text, Text = "You amplify the connection between bullet and firearm, calling your missed shot back into your gun. The ammunition you just fired is reloaded back into your gun and immediately ready to fire again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("016dbebf-449a-4eca-95dc-e8af8d1f9989"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
