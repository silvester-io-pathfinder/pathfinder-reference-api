using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class ShortshanksHobgoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Shortshanks Hobgoblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have a longer torso and broader shoulders than most hobgoblins, making your legs seem short by comparison. This gives you a strong, muscular core and lowers your center of gravity—features that assist you in riding and climbing—and you've trained at riding in a saddle from an extremely early age. You gain the Ride feat. Additionally, you are not flat-footed while you Climb." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Ride.ID);
            builder.Manual(Guid.Parse(""), "You are not flat-footed while you Climb.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 33
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Hobgoblin.ID;
        }
    }
}
