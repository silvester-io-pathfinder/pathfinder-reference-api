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
        public static readonly Guid ID = Guid.Parse("ae997e36-72a2-4771-b19c-59b1483956bc");

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
            yield return new TextBlock { Id = Guid.Parse("7dddd268-7839-41aa-b1a2-4dcf80ac33fd"), Type = TextBlockType.Text, Text = "You have a longer torso and broader shoulders than most hobgoblins, making your legs seem short by comparison. This gives you a strong, muscular core and lowers your center of gravity�features that assist you in riding and climbing�and you've trained at riding in a saddle from an extremely early age. You gain the Ride feat. Additionally, you are not flat-footed while you Climb." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("fa4db354-ea07-4144-a42a-fb08f760c23a"), Feats.Instances.Ride.ID);
            builder.Manual(Guid.Parse("8fca8fad-6cea-4e61-b538-8c52d260b1cf"), "You are not flat-footed while you Climb.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51cd07ec-1368-4dbc-9ca6-7a3271a4e1aa"),
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
