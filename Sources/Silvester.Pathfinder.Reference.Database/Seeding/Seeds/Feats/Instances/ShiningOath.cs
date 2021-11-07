using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShiningOath : Template
    {
        public static readonly Guid ID = Guid.Parse("1ea7879d-eb29-485a-86ba-a3c0b71d8b9e");

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
            yield return new TextBlock { Id = Guid.Parse("28494e3a-a36f-4aa5-9161-02efd845b1a1"), Type = TextBlockType.Text, Text = "You’ve sworn an oath to put the undead to rest. Add the following tenet to your champion’s code after the other tenets:" };
            yield return new TextBlock { Id = Guid.Parse("073c0822-5308-4ac8-b213-cbd11ea88610"), Type = TextBlockType.Enumeration, Text = " : You must end the existence of undead you encounter as long as you have a reasonable chance of success; in the unlikely event you find a good undead, you can try to work out a more peaceful way to help it recover from its undead state rather than destroying it in combat, such as helping it complete its unfinished business and find peace." };
            yield return new TextBlock { Id = Guid.Parse("6ea6560b-10ca-4b84-bd21-b0cc031e7e1c"), Type = TextBlockType.Text, Text = "Your (feat: Retributive Strike) gains a +4 circumstance bonus to damage against an undead, or +6 if you have master proficiency with the weapon you used." };
            yield return new TextBlock { Id = Guid.Parse("621bd4b9-c4eb-4e99-86f7-bbfe1244bfb1"), Type = TextBlockType.Text, Text = "Your (feat: Glimpse of Redemption)’s resistance against damage from an undead is 7 + your level." };
            yield return new TextBlock { Id = Guid.Parse("bf0bacbb-ae3f-4393-a235-515a14905ec8"), Type = TextBlockType.Text, Text = "If you use (feat: Liberating Step) triggered by an undead, your ally gains a +4 circumstance bonus to checks granted by your (feat: Liberating Step), and the ally can (action: Step) twice afterward." };
            yield return new TextBlock { Id = Guid.Parse("dc672f0e-9f01-4334-b374-1d0c2c577268"), Type = TextBlockType.Text, Text = "You don’t consider undead to be legitimate authorities, even in nations ruled by undead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("e2f6eb11-f22c-4414-a854-7609381eefa7"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16343783-0a95-4d1f-b787-b6bad3519d78"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
