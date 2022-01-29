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
    public class DistractingExplosion : Template
    {
        public static readonly Guid ID = Guid.Parse("903c9b63-10c8-47ad-948e-75d8dc15e619");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distracting Explosion",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, it can take this reaction instead of you, even though minions can't normally take reactions or act when it's not their turn. It uses your reaction for the turn to do so.",
                Trigger = "A creature within your reach uses a concentrate action.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7515dcbd-c1fa-424a-9593-01ae226c200a"), Type = TextBlockType.Text, Text = $"Your enemies think they can concentrate on something else while you're nearby? Oh, you'll give them a distraction, all right! Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the triggering creature with a weapon or unarmed attack that is benefiting from your offensive boost. This {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} doesn't count toward your multiple attack penalty, and your multiple attack penalty doesn't apply to this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("89aa30e0-98a0-469d-96f0-4d0e2a022a25"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("3282e6d1-d548-4c3a-b346-a3b85e413a38"), Type = TextBlockType.Text, Text = $"~ Unstable Function: You pull out all the stops to create an explosive distraction. Add the {ToMarkdownLink<Models.Entities.Trait>("unstable", Traits.Instances.Unstable.ID)} trait to Distracting Explosion. If the attack hits, you disrupt the triggering {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("876c541e-87f1-47fc-bed4-a1f1baf4dca7"), ClassFeatures.Inventors.OffensiveBoost.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8af758dc-2281-4402-b6bb-0fbd92a971c8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
