using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Hatred : Template
    {
        public static readonly Guid ID = Guid.Parse("8540f65b-559c-4233-8c3a-61abd7c0e7db");

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
            yield return new TextBlock { Id = Guid.Parse("e950f341-6378-4326-b955-1936b6f6de46"), Type = TextBlockType.Text, Text = "Your unabashed hatred consumes your soul and causes your foe to falter. Your (feat: emotional focus) is an individual enemy you detest." };
            yield return new TextBlock { Id = Guid.Parse("487cd814-91a1-4c9c-9868-8b182468e7d6"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: You start your first turn in an encounter against your emotional focus or one of their followers. If the encounter includes multiple eligible followers and doesn't include your actual emotional focus, choose one of the followers to act as your emotional focus for this encounter (or until your actual emotional focus shows up)." };
            yield return new TextBlock { Id = Guid.Parse("1bfcf7bd-96d6-46e1-af4d-4022eb7f023d"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: You can (action: Step) or (action: Stride). You must end this movement closer to your emotional focus." };
            yield return new TextBlock { Id = Guid.Parse("601fb187-d424-4067-b21f-18649ae4ac8b"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: Your emotional focus is flat-footed to you and takes a –2 status penalty to saves against your spells. You're flat-footed to your emotional focus and take a –2 status penalty to saves against it. Spell: (spell: blood vendetta)" };
            yield return new TextBlock { Id = Guid.Parse("0269188f-4937-4351-a91a-122f75a00222"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You become stunned 2." };
            yield return new TextBlock { Id = Guid.Parse("d20266e5-f27e-41c7-a908-8f27b38bc7dc"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: cry of destruction)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01471f07-8e3a-4916-9916-5f04df316613"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
