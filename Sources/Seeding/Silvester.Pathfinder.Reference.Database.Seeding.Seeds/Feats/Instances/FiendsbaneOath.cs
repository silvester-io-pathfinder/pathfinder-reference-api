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
    public class FiendsbaneOath : Template
    {
        public static readonly Guid ID = Guid.Parse("0374ca41-845d-4076-a10a-d9d19b17b9c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiendsbane Oath",
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
            yield return new TextBlock { Id = Guid.Parse("c81864d9-9fd2-4666-8340-e7e91d41ce4d"), Type = TextBlockType.Text, Text = $"You've sworn an oath to banish the corruption of fiends to the dark planes they call home. Add the following tenet to your champion's code after the other tenets:" };
            yield return new TextBlock { Id = Guid.Parse("8b458fcd-34b6-4a79-9c0b-42774457bd8b"), Type = TextBlockType.Enumeration, Text = $" : You must banish or slay fiends you come across as long as you have a reasonable chance of success; in the incredibly unlikely event you find a good fiend, you don't have to banish or kill it." };
            yield return new TextBlock { Id = Guid.Parse("80d42237-7809-46f2-9b4a-69722d409e13"), Type = TextBlockType.Text, Text = $"Your {ToMarkdownLink<Models.Entities.Feat>("Retributive Strike", Feats.Instances.RetributiveStrike.ID)} gains a +4 circumstance bonus to damage against a fiend, or a +6 circumstance bonus if you have master proficiency with the weapon you used." };
            yield return new TextBlock { Id = Guid.Parse("9af2bc00-94c2-4ad2-a412-c6462fabeef0"), Type = TextBlockType.Text, Text = $"Your {ToMarkdownLink<Models.Entities.Feat>("Glimpse of Redemption", Feats.Instances.GlimpseOfRedemption.ID)}'s resistance against damage from a fiend is 7 + your level." };
            yield return new TextBlock { Id = Guid.Parse("3b989bc5-3d4f-4fac-b4a1-2c990f21ea34"), Type = TextBlockType.Text, Text = $"If you use {ToMarkdownLink<Models.Entities.Feat>("Liberating Step", Feats.Instances.LiberatingStep.ID)} triggered by a fiend, your ally gains a +4 circumstance bonus to checks granted by your {ToMarkdownLink<Models.Entities.Feat>("Liberating Step", Feats.Instances.LiberatingStep.ID)}, and the ally can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} twice afterward." };
            yield return new TextBlock { Id = Guid.Parse("ef06e288-c3d8-4b0c-a0a0-7dbe95ca83e7"), Type = TextBlockType.Text, Text = $"You don't consider fiends to be legitimate authorities, even in nations ruled by fiends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("68fe3ec0-e0f1-4b87-a5fd-e5abab349166"), Tenets.Instances.Good.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1289b826-fd59-4b43-989a-a0be13493ef3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
