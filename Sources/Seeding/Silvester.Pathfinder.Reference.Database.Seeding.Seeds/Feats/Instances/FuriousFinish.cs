using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FuriousFinish : Template
    {
        public static readonly Guid ID = Guid.Parse("329d5341-1a18-4baf-a00f-a2a17081517f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Furious Finish",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6db168ab-62a7-4233-913c-120c27cfc3ae"), Type = TextBlockType.Text, Text = $"Desperate to finish the fight, you pour all your rage into one final blow. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If it hits, you gain a circumstance bonus to damage equal to the number of rounds remaining in your {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)} (maximum 10). After this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, your {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)} immediately ends, and you are fatigued until you rest for at least 10 minutes." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("1c5885aa-9036-43b1-82e8-a3e7316de73e"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("70ed3439-a6ba-4510-8b8a-500cd6b50e7c"), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72918226-f579-4bfe-9df9-29050819cedb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
