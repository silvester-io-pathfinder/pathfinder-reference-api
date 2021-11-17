using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Love : Template
    {
        public static readonly Guid ID = Guid.Parse("5734761c-df71-45ed-8405-3a7c5fb71c47");

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
            yield return new TextBlock { Id = Guid.Parse("ee420239-a53f-40d0-b30b-88f13ae6f58e"), Type = TextBlockType.Text, Text = "You’re joined by the bonds of love and nothing can break that, but love can distract you from other things in your life. Your (feat: emotional focus) is someone you’re in love with; they aren’t required to love you back." };
            yield return new TextBlock { Id = Guid.Parse("e9a3d71a-836b-4d37-90ea-c640dead04d0"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: Your emotional focus takes damage from an enemy while within 30 feet of you." };
            yield return new TextBlock { Id = Guid.Parse("f9d4d629-3f6f-494e-8bf1-8bf11ce32a61"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: If either you or your emotional focus is confused or controlled, one of you can attempt a new saving throw against one confusing or controlling effect (if it allowed a save), ending the condition if the new save is a success. If both of you are eligible, your emotional focus gets the new save." };
            yield return new TextBlock { Id = Guid.Parse("ff8b3005-8be4-4c5b-8f99-b5d25de521af"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: You gain a +1 status bonus to Will saves. If you cast a spell to benefit your emotional focus, this bonus increases to +3 until the start of your next turn. Spell: (spell: soothe)" };
            yield return new TextBlock { Id = Guid.Parse("fd96f0df-0a83-4853-a7e2-7d186240ba7c"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You’re fascinated with your emotional focus for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("9e74c6d6-4b45-4231-9b4a-bf03667b33e4"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: soothing words)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce308585-e0af-4afc-b69f-77bb7baed291"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
