using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class RoguesRacket : Template
    {
        public static readonly Guid ID = Guid.Parse("e3b85485-4e61-41bc-bcc8-9f52decc0ad3");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Rogue's Racket", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("66e326d9-311a-4740-b0a0-9113781db7ee"), Type = TextBlockType.Text, Text = "As you started on the path of the rogue, you began to develop your own style to pursue your illicit activities. Your racket shapes your rogue techniques and the way you approach a job, while building your reputation in the criminal underworld for a certain type of work. A client with deep pockets might even hire a team of rogues for a particular heist, each specializing in a different racket, in order to cover all the bases. Choose a rogue's racket." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyRoguesRacket(Guid.Parse("08ab2215-d9a4-4541-aedb-6fe29e3e3094"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("230f5d65-d25a-40a0-8b2a-a2cc97ac0770"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 180
            };
        }
    }
}
