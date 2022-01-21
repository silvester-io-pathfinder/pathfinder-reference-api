using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcanePropulsion : Template
    {
        public static readonly Guid ID = Guid.Parse("65291ccd-c838-479f-a89b-c822a9ceb103");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Propulsion",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59e4864e-a37a-4e84-88c3-e7d41dd2470a"), Type = TextBlockType.Text, Text = $"You redirect energy from your core to ports on your back or feet, allowing you to fly for a short time. You can maintain this redirected energy for 5 minutes. You gain a fly Speed equal to your Speed while redirecting the energy." };
            yield return new TextBlock { Id = Guid.Parse("c7d98110-9a12-4fbd-9830-d8085159b739"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("e776f05f-a6aa-4b0d-9d45-d17c52844ef9"), Type = TextBlockType.Text, Text = $"~ Enhancement: You can maintain your flight for longer. You can redirect your energy at all times, allowing you to fly whenever you want, rather than just once per day for 5 minutes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6857b7c-d274-4eb7-8f5a-344f8651f43b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
