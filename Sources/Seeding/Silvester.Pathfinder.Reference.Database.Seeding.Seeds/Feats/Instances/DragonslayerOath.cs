using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonslayerOath : Template
    {
        public static readonly Guid ID = Guid.Parse("b1f184f3-119f-4595-a646-87772ae0b313");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragonslayer Oath",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd042479-fe5b-4e9e-82c1-173e2f600023"), Type = TextBlockType.Text, Text = $"You've sworn to slay evil dragons. Add the following tenet to your code after the others:" };
            yield return new TextBlock { Id = Guid.Parse("7a9c2a9a-0ab5-41f2-ac64-553744933661"), Type = TextBlockType.Enumeration, Text = $" : You must slay evil dragons you encounter as long as you have a reasonable chance of success." };
            yield return new TextBlock { Id = Guid.Parse("cdcdbf4c-6d03-413b-9555-b1f573c3b309"), Type = TextBlockType.Text, Text = $"Your {ToMarkdownLink<Models.Entities.Feat>("Retributive Strike", Feats.Instances.RetributiveStrike.ID)} gains a +4 circumstance bonus to damage against an evil dragon, or +6 if you have master proficiency with the weapon you used." };
            yield return new TextBlock { Id = Guid.Parse("f20b1795-364c-43d4-a342-c79103be437d"), Type = TextBlockType.Text, Text = $"Your {ToMarkdownLink<Models.Entities.Feat>("Glimpse of Redemption", Feats.Instances.GlimpseOfRedemption.ID)}'s resistance against damage from an evil dragon is 7 + your level." };
            yield return new TextBlock { Id = Guid.Parse("0d25b02b-fe8f-4fc6-80ae-599569aec6fa"), Type = TextBlockType.Text, Text = $"If you use {ToMarkdownLink<Models.Entities.Feat>("Liberating Step", Feats.Instances.LiberatingStep.ID)} triggered by an evil dragon, your ally gains a +4 circumstance bonus to checks granted by your {ToMarkdownLink<Models.Entities.Feat>("Liberating Step", Feats.Instances.LiberatingStep.ID)}, and the ally can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} twice afterward." };
            yield return new TextBlock { Id = Guid.Parse("2d5d82da-b3a1-42ad-a49f-b6dc30664461"), Type = TextBlockType.Text, Text = $"You don't consider evil dragons to be legitimate authorities, even in nations they rule." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("59e3659b-52d0-476c-b843-4b6323ebd2f2"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc1bb0d1-9d12-4e1b-99c4-eefa4d4156b7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
