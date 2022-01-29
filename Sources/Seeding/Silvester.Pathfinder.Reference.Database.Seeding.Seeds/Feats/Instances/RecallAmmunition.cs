using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecallAmmunition : Template
    {
        public static readonly Guid ID = Guid.Parse("45701186-b41e-4185-a8c4-ea4afafdb750");

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
            yield return new TextBlock { Id = Guid.Parse("b9a4b367-9f2f-4dfe-9e9a-5f8af7a9b0d0"), Type = TextBlockType.Text, Text = $"You amplify the connection between bullet and firearm, calling your missed shot back into your gun. The ammunition you just fired is reloaded back into your gun and immediately ready to fire again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26be75a3-79d6-4ca5-a01c-248e243ea09f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
