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
    public class AttackOfOpportunity : Template
    {
        public static readonly Guid ID = Guid.Parse("01187ced-92b9-49f1-9fb4-b73afc85e5c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Attack of Opportunity",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your reach uses a manipulate action or a move action, makes a ranged attack, or leaves a square during a move action it's using.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4eb4cd9f-e6d9-49a3-8c07-4279f1992719"), Type = TextBlockType.Text, Text = $"You lash out at a vulnerable foe. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the triggering creature. If your attack is a critical hit and the trigger was a {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} action, you disrupt that action. This {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} doesn't count toward your multiple attack penalty, and your multiple attack penalty doesn't apply to this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("afd06024-367d-4b83-bb90-9b04bf05b325"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("340e970e-ccec-4126-93b2-f690ebb386e7"), Traits.Instances.Champion.ID);
            builder.Add(Guid.Parse("42b2e106-4a58-49e5-986f-7cda1bb71a6e"), Traits.Instances.Magus.ID);
            builder.Add(Guid.Parse("d851c315-3080-4876-b0bf-2046547b8b7d"), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b83a388f-fc6f-485b-9b9e-828f1e52316e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
