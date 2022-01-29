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
    public class EidolonsOpportunity : Template
    {
        public static readonly Guid ID = Guid.Parse("43dea77f-66e4-4a29-b6ce-64e4edceeafc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eidolon's Opportunity",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your eidolon's reach uses a manipulate action or a move action, makes a ranged attack, or leaves a square during a move action it's using.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dc87ff88-71ef-4632-96d7-e62f72759e82"), Type = TextBlockType.Text, Text = $"Your eidolon makes a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the triggering creature. If the attack is a critical hit and the trigger was a {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} action, your eidolon disrupts that action. This {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} doesn't count toward your multiple attack penalty, and your multiple attack penalty doesn't apply to this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Eidolon.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Evolution.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Summoner.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd477a47-8e3f-4029-b451-b3345ea83ccf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
