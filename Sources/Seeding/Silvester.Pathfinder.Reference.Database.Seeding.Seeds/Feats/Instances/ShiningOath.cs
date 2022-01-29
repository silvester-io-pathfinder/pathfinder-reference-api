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
    public class ShiningOath : Template
    {
        public static readonly Guid ID = Guid.Parse("e8c33502-0384-454d-9339-04b4fcb340a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shining Oath",
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
            yield return new TextBlock { Id = Guid.Parse("623189ba-1b54-4c2b-9f13-86565fec83c1"), Type = TextBlockType.Text, Text = $"You've sworn an oath to put the undead to rest. Add the following tenet to your champion's code after the other tenets:" };
            yield return new TextBlock { Id = Guid.Parse("4e0a31fd-dafa-4351-a930-76e9f70ee9bf"), Type = TextBlockType.Enumeration, Text = $" : You must end the existence of undead you encounter as long as you have a reasonable chance of success; in the unlikely event you find a good undead, you can try to work out a more peaceful way to help it recover from its undead state rather than destroying it in combat, such as helping it complete its unfinished business and find peace." };
            yield return new TextBlock { Id = Guid.Parse("13581526-c94d-423a-b2ec-03367718d8e8"), Type = TextBlockType.Text, Text = $"Your {ToMarkdownLink<Models.Entities.Feat>("Retributive Strike", Feats.Instances.RetributiveStrike.ID)} gains a +4 circumstance bonus to damage against an undead, or +6 if you have master proficiency with the weapon you used." };
            yield return new TextBlock { Id = Guid.Parse("49cd1a73-0c87-4bac-8cbe-78fc98067bc8"), Type = TextBlockType.Text, Text = $"Your {ToMarkdownLink<Models.Entities.Feat>("Glimpse of Redemption", Feats.Instances.GlimpseOfRedemption.ID)}'s resistance against damage from an undead is 7 + your level." };
            yield return new TextBlock { Id = Guid.Parse("72170d5d-50e9-49d1-8483-f1ee52814201"), Type = TextBlockType.Text, Text = $"If you use {ToMarkdownLink<Models.Entities.Feat>("Liberating Step", Feats.Instances.LiberatingStep.ID)} triggered by an undead, your ally gains a +4 circumstance bonus to checks granted by your {ToMarkdownLink<Models.Entities.Feat>("Liberating Step", Feats.Instances.LiberatingStep.ID)}, and the ally can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} twice afterward." };
            yield return new TextBlock { Id = Guid.Parse("f4728111-2630-4baf-a4a7-5547a2e3dab8"), Type = TextBlockType.Text, Text = $"You don't consider undead to be legitimate authorities, even in nations ruled by undead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("30da0767-ea84-4f78-a230-3e688bea8668"), Tenets.Instances.Good.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30bb03ba-5ba8-4d40-84a5-e7948698d41b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
