using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Hatred : Template
    {
        public static readonly Guid ID = Guid.Parse("32afe70b-bab7-457a-bc78-85c67c0f085d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hatred",
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
            yield return new TextBlock { Id = Guid.Parse("9bfb092e-e410-4b47-b808-70c9b49d9047"), Type = TextBlockType.Text, Text = "Your unabashed hatred consumes your soul and causes your foe to falter. Your (feat: emotional focus) is an individual enemy you detest." };
            yield return new TextBlock { Id = Guid.Parse("c2cab14b-6b9f-4622-a96c-5a1599527f07"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: You start your first turn in an encounter against your emotional focus or one of their followers. If the encounter includes multiple eligible followers and doesn’t include your actual emotional focus, choose one of the followers to act as your emotional focus for this encounter (or until your actual emotional focus shows up)." };
            yield return new TextBlock { Id = Guid.Parse("bd9f6e9a-4a8c-4d59-a8cd-9d6d7cdc871f"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: You can (action: Step) or (action: Stride). You must end this movement closer to your emotional focus." };
            yield return new TextBlock { Id = Guid.Parse("b60e89f6-806f-47bf-b33c-3ecfe613aa5a"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: Your emotional focus is flat-footed to you and takes a –2 status penalty to saves against your spells. You’re flat-footed to your emotional focus and take a –2 status penalty to saves against it. Spell: (spell: blood vendetta)" };
            yield return new TextBlock { Id = Guid.Parse("3bd87acb-9c2a-4e35-b177-1bc0632eeba1"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You become stunned 2." };
            yield return new TextBlock { Id = Guid.Parse("f2d34258-48f6-4e72-a19f-0efd37853857"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: cry of destruction)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01b121ca-508e-49c8-a27a-800af0a0b34f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
