using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Love : Template
    {
        public static readonly Guid ID = Guid.Parse("02c888c5-7874-4da6-afb2-ecb51de3c6f7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Love",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("66512c8e-f5b8-4752-a5df-a8ceafb15d9c"), Type = TextBlockType.Text, Text = "You’re joined by the bonds of love and nothing can break that, but love can distract you from other things in your life. Your (feat: emotional focus) is someone you’re in love with; they aren’t required to love you back." };
            yield return new TextBlock { Id = Guid.Parse("31941438-e1cf-4d61-9465-5f0a2b01855f"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: Your emotional focus takes damage from an enemy while within 30 feet of you." };
            yield return new TextBlock { Id = Guid.Parse("af64ff62-0931-486a-9204-50edcb41a10c"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: If either you or your emotional focus is confused or controlled, one of you can attempt a new saving throw against one confusing or controlling effect (if it allowed a save), ending the condition if the new save is a success. If both of you are eligible, your emotional focus gets the new save." };
            yield return new TextBlock { Id = Guid.Parse("49e0ab87-f672-486b-a284-2c321dea1040"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: You gain a +1 status bonus to Will saves. If you cast a spell to benefit your emotional focus, this bonus increases to +3 until the start of your next turn. Spell: (spell: soothe)" };
            yield return new TextBlock { Id = Guid.Parse("a88b3432-d310-493d-a306-192dc0da02a8"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You’re fascinated with your emotional focus for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("71dbf883-d3ef-4c2a-8b20-4574713946fd"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: soothing words)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84ecf4f0-54e8-4604-8986-7c96465b9d52"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
