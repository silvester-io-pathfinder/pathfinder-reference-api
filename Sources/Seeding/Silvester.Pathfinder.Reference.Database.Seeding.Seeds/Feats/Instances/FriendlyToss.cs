using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FriendlyToss : Template
    {
        public static readonly Guid ID = Guid.Parse("de048fbd-593c-44db-a42e-4e7706840098");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Friendly Toss",
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
            yield return new TextBlock { Id = Guid.Parse("c3261371-4d31-43cb-97cf-7a2067600e05"), Type = TextBlockType.Text, Text = "You toss your friends around the battlefield. Pick up an adjacent ally of your size or smaller and throw them to an unoccupied space you can see within 30 feet. Their movement doesn't trigger reactions. Your ally ends this movement on their feet and doesn't take damage from the fall. If your ally ends this movement within melee reach of at least one enemy, they can make a melee (action: Strike) against an enemy within their reach as a reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9fb79b0-26fa-4e41-81cb-1c5f08628295"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
