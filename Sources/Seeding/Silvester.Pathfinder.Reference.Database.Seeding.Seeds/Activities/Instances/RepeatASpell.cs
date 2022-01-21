using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Activities.Instances
{
    public class RepeatASpell : Template
    {
        public static readonly Guid ID = Guid.Parse("324e9bc6-3608-40dd-b5ef-a355ae2c833b");
        
        protected override Activity GetActivity()
        {
            return new Activity
            {
                Id = ID, 
                Name = "Repeat a Spell",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ce663dc0-f42a-40df-8ce8-c895abbb33d5"), Type = TextBlockType.Text, Text = "You repeatedly cast the same spell while moving at half speed. Typically, this spell is a cantrip that you want to have in effect in the event a combat breaks out, and it must be one you can cast in 2 actions or fewer. In order to prevent fatigue due to repeated casting, you�ll likely use this activity only when something out of the ordinary occurs." };
            yield return new TextBlock { Id = Guid.Parse("0c12106b-0727-48f6-9553-accb33dc1849"), Type = TextBlockType.Text, Text = "You can instead use this activity to continue Sustaining a Spell or Activation with a sustained duration. Most such spells or item effects can be sustained for 10 minutes, though some specify they can be sustained for a different duration." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b79b306f-0335-4b76-a6ad-94bb8da27f16"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 480
            };
        }
    }
}
